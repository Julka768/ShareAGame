import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MyGamesComponent } from './my-games/my-games.component';
import { CreateNewGameComponent } from './create-new-game/create-new-game.component';

@NgModule({
  declarations: [AppComponent, MyGamesComponent, CreateNewGameComponent],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
