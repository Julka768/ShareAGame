import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Game } from '../my-games/my-games.component';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class GamesService {
  constructor(private http: HttpClient) {}

  getAllGames(): Observable<Game[]> {
    return this.http.get<Game[]>('https://localhost:44352/Game').pipe();
  }
}
