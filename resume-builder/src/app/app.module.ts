import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {
  MatFormFieldModule,
  MatStepperModule,
  MatDatepickerModule,
  MatExpansionModule,
  MatSidenavModule,
  MatBottomSheetModule,
  MatDialogModule,
  MatSnackBarModule,
  MatCardModule,
} from '@angular/material';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatStepperModule,
    MatDatepickerModule,
    MatExpansionModule,
    MatSidenavModule,
    MatBottomSheetModule,
    MatDialogModule,
    MatSnackBarModule,
    MatCardModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
