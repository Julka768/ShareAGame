import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { GamePlatfromEnum } from '../models/enums/game-platform-enum';
import { CreateNewGameDto } from '../models/request/create-new-game-dto';
import { SelectOption } from '../models/select-options';
import { GamesService } from '../services/games.service';
import { PublishersService } from '../services/publishers.service';

@Component({
  selector: 'app-create-new-game-modal',
  templateUrl: './create-new-game-modal.component.html',
  styleUrls: ['./create-new-game-modal.component.scss'],
})
export class CreateNewGameModalComponent implements OnInit {
  gameForm!: FormGroup;
  publisherOptions: SelectOption[] = [];
  enumKeys: number[] = [];
  gamePlatfromEnum = GamePlatfromEnum;

  constructor(
    public gamesService: GamesService,
    private publisherService: PublishersService
  ) {}

  ngOnInit(): void {
    this.gameForm = this.createForm();
    this.publisherService
      .getAllPublusherSelectOptions()
      .subscribe((options) => (this.publisherOptions = options));

    this.enumKeys = Object.keys(this.gamePlatfromEnum)
      .filter((f) => !isNaN(Number(f)))
      .map((k) => Number(k));
  }

  createForm(): FormGroup {
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

  save() {
    const request: CreateNewGameDto = {
      ...this.gameForm.value,
    };
    this.gamesService.createNewGame(request).subscribe();
  }
}
