import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { CreateNewGameDto } from '../models/request/create-new-game-dto';
import { Game } from '../models/game';

@Injectable({
  providedIn: 'root',
})
export class GamesService {
  constructor(private http: HttpClient) {}

  getAllGames(): Observable<Game[]> {
    return this.http.get<Game[]>('https://localhost:44352/Game').pipe();
  }

  createNewGame(request: CreateNewGameDto) {
    return this.http
      .post('https://localhost:44352/Game/CreateNewGame', request)
      .pipe();
  }

  delete(gameId: string) {
    return this.http.delete('https://localhost:44352/Game/' + gameId).pipe();
  }

  getGameById(gameId: string) {
    return this.http.get<Game>('https://localhost:44352/Game/' + gameId).pipe();
  }
}
