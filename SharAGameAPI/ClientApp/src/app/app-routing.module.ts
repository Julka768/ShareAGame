import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetailsGameComponent } from './details-game/details-game.component';
import { MyGamesComponent } from './my-games/my-games.component';
import { GetGameByIdResolverService } from './resolvers/get-game-by-id-resolver.service';
import { GetGamesResolverService } from './resolvers/get-games-resolver.service';

const defaultPath = 'my-games';

const routes: Routes = [
  {
    path: 'home',
    component: MyGamesComponent,
  },

  {
    path: defaultPath,
    component: MyGamesComponent,
    resolve: { games: GetGamesResolverService },
  },
  // {
  //   path: 'details/:gameId',
  //   component: DetailsGameComponent,
  //   resolve: { game: GetGameByIdResolverService },
  // },

  {
    path: '',
    redirectTo: defaultPath,
    pathMatch: 'full',
  },

  {
    path: '**',
    redirectTo: defaultPath,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
