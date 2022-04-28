import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MyGamesComponent } from './my-games/my-games.component';
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
