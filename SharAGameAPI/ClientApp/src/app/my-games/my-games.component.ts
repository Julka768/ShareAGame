import { StringMapWithRename } from '@angular/compiler/src/compiler_facade_interface';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GamesService } from '../services/games.service';

@Component({
  selector: 'app-my-games',
  templateUrl: './my-games.component.html',
  styleUrls: ['./my-games.component.scss'],
})
export class MyGamesComponent implements OnInit {
  games!: Game[];

  constructor(
    private gamesService: GamesService,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.route.data.subscribe((data) => (this.games = data['games']));
    //   this.games = [
    //     {
    //       id: 'c5703113-5f0a-4f17-af4f-83b330fa9c8a',
    //       name: 'Lara Croft Tomb Raider',
    //       isDigital: true,
    //       imageUrl: 'https://www.gry-online.pl/galeria/gry13/413147859.jpg',
    //       publisherId: '82642b42-06f4-43e5-847c-5433ce42b31b',
    //       publisher: null,
    //       gamePlatform: 'pc',
    //     },
    //     {
    //       id: '3c54248d-572c-4e2f-861c-d8eb90fcf74d',
    //       name: 'Assasin Creed Valhalla',
    //       isDigital: true,
    //       imageUrl:
    //         'https://cdn1.epicgames.com/400347196e674de89c23cc2a7f2121db/offer/AC%20KINGDOM%20PREORDER_STANDARD%20EDITION_EPIC_Key_Art_Portrait_640x854-640x854-288120c5573756cb988b6c1968cebd86.png',
    //       publisherId: '7c7bc643-b767-4614-8724-fe96ecc57eb2',
    //       publisher: null,
    //       gamePlatform: 'ps5',
    //     },
    //     {
    //       id: '9db8341c-dc54-41cb-8ccb-72443da96f0e',
    //       name: 'Watch Dog',
    //       isDigital: true,
    //       imageUrl:
    //         'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaaud_5UmER7n84qaagoWadSzdUnahTfDRNw&usqp=CAU',
    //       publisherId: '7c7bc643-b767-4614-8724-fe96ecc57eb2',
    //       publisher: null,
    //       gamePlatform: 'ps4',
    //     },
    //   ];
  }
}

export interface Game {
  id: string;
  name: string;
  isDigital: boolean;
  imageUrl: string;
  publisherId: string;
  publisher: null;
  gamePlatform: string;
}
