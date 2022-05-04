import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatSelectModule } from '@angular/material/select';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatDialogModule } from '@angular/material/dialog';
import { MatNativeDateModule } from '@angular/material/core';
import { MatMomentDateModule } from '@angular/material-moment-adapter';

@NgModule({
  imports: [
    MatButtonModule,
    MatInputModule,
    MatCheckboxModule,
    MatDatepickerModule,
    MatGridListModule,
    MatSelectModule,
    MatSlideToggleModule,
    MatDialogModule,
    MatNativeDateModule,
    MatMomentDateModule,
  ],

  providers: [],

  exports: [
    MatButtonModule,
    MatInputModule,
    MatCheckboxModule,
    MatDatepickerModule,
    MatGridListModule,
    MatSelectModule,
    MatSlideToggleModule,
    MatDialogModule,
    MatNativeDateModule,
    MatMomentDateModule,
  ],
})
export class MaterialModule {}
