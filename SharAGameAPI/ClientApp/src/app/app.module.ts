import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MyGamesComponent } from './my-games/my-games.component';
import { CreateNewGameModalComponent } from './create-new-game-modal/create-new-game-modal.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './shared/material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DetailsGameComponent } from './details-game/details-game.component';
import { EditGameModalComponent } from './edit-game-modal/edit-game-modal.component';

@NgModule({
  declarations: [
    AppComponent,
    MyGamesComponent,
    CreateNewGameModalComponent,
    DetailsGameComponent,
    EditGameModalComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
