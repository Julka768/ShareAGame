import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute } from '@angular/router';
import { EditGameModalComponent } from '../edit-game-modal/edit-game-modal.component';
import { Game } from '../models/game';

@Component({
  selector: 'app-details-game',
  templateUrl: './details-game.component.html',
  styleUrls: ['./details-game.component.scss'],
})
export class DetailsGameComponent implements OnInit {
  game!: Game;

  constructor(private route: ActivatedRoute, public dialog: MatDialog) {}

  ngOnInit(): void {
    this.route.data.subscribe((data) => {
      this.game = data['game'];
    });
  }

  editGame() {
    this.dialog.open(EditGameModalComponent);
  }
}
