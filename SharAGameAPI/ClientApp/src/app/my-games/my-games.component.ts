import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GamesService } from '../services/games.service';
import { MatDialog } from '@angular/material/dialog';
import { CreateNewGameModalComponent } from '../create-new-game-modal/create-new-game-modal.component';
import { Game } from '../models/game';

@Component({
  selector: 'app-my-games',
  templateUrl: './my-games.component.html',
  styleUrls: ['./my-games.component.scss'],
})
export class MyGamesComponent implements OnInit {
  games!: Game[];

  constructor(
    private gamesService: GamesService,
    private route: ActivatedRoute,
    public dialog: MatDialog
  ) {}

  ngOnInit() {
    this.route.data.subscribe((data) => (this.games = data['games']));
  }

  addNewGame() {
    this.dialog.open(CreateNewGameModalComponent);
  }

  delete(gameId: string): void {
    console.log('click');
    this.gamesService.delete(gameId).subscribe((data) => {
      const index = this.games.findIndex((game) => game.id === gameId);
      if (index > -1) {
        this.games.splice(index, 1);
      }
    });
  }
}
