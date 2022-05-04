import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  Resolve,
  RouterStateSnapshot,
} from '@angular/router';
import { Observable } from 'rxjs';
import { Game } from '../models/game';
import { GamesService } from '../services/games.service';

@Injectable({
  providedIn: 'root',
})
export class GetGameByIdResolverService implements Resolve<Game> {
  constructor(private gamesService: GamesService) {}

  resolve(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<Game> {
    const gameId = route.params['gameId'];
    return this.gamesService.getGameById(gameId);
  }
}
