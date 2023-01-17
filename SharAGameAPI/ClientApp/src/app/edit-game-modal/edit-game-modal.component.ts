import { Component, OnInit } from '@angular/core';
import {
  Form,
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { GamePlatfromEnum } from '../models/enums/game-platform-enum';
import { EditGameDto } from '../models/request/edit-game-dto';
import { SelectOption } from '../models/select-options';
import { GamesService } from '../services/games.service';
import { PublishersService } from '../services/publishers.service';

@Component({
  selector: 'app-edit-game-modal',
  templateUrl: './edit-game-modal.component.html',
  styleUrls: ['./edit-game-modal.component.scss'],
})
export class EditGameModalComponent implements OnInit {
  editGameForm!: FormGroup;
  publisherOptions: SelectOption[] = [];
  enumKeys: number[] = [];
  gamePlatfromEnum = GamePlatfromEnum;

  constructor(
    public gamesService: GamesService,
    private publisherService: PublishersService
  ) {}

  ngOnInit(): void {
    this.editGameForm = this.editForm();
    this.publisherService
      .getAllPublusherSelectOptions()
      .subscribe((options) => (this.publisherOptions = options));

    this.enumKeys = Object.keys(this.gamePlatfromEnum)
      .filter((f) => !isNaN(Number(f)))
      .map((k) => Number(k));
  }

  editForm(): FormGroup {
    const form = new FormGroup({
      name: new FormControl('', Validators.required),
      isDigital: new FormControl(false, Validators.required),
      releaseDate: new FormControl(new Date(), Validators.required),
      imageUrl: new FormControl('', Validators.required),
      publisherId: new FormControl(null, Validators.required),
      gamePlatform: new FormControl(GamePlatfromEnum.Pc, Validators.required),
    });

    return form;
  }

  save(gameId: string): void {
    const request: EditGameDto = {
      ...this.editGameForm.value,
    };
    this.gamesService.update(request, gameId).subscribe();
  }
}
