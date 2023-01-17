import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { CreateNewGameDto } from '../models/request/create-new-game-dto';
import { Game } from '../models/game';
import { EditGameDto } from '../models/request/edit-game-dto';

@Injectable({
  providedIn: 'root',
})
export class GamesService {
  constructor(private http: HttpClient) {}

  getAllGames(): Observable<Game[]> {
    return this.http.get<Game[]>('https://localhost:44352/Game/GetAll').pipe();
  }

  createNewGame(request: CreateNewGameDto) {
    return this.http
      .post('https://localhost:44352/Game/CreateNewGame', request)
      .pipe();
  }

  delete(gameId: string) {
    return this.http.delete('https://localhost:44352/Game/' + gameId).pipe();
  }

  getGameById(gameId: string): Observable<Game> {
    return this.http
      .get<Game>('https://localhost:44352/Game/GetById/' + gameId)
      .pipe();
  }

  update(request: EditGameDto, gameId: string): Observable<Game> {
    return this.http
      .put<Game>('https://localhost:44352/Game/' + gameId, request)
      .pipe();
  }
}
