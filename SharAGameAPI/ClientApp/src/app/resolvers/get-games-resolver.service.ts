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
export class GetGamesResolverService implements Resolve<Game[]> {
  constructor(private gamesService: GamesService) {}

  resolve(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<Game[]> {
    return this.gamesService.getAllGames();
  }
}
