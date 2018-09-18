import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ListOfLoveteamsComponent } from './_loveteam/list-of-loveteams/list-of-loveteams.component';
import { LoveteamService } from './_services/loveteam.service';
import { NavBarComponent } from './_app-layout/nav-bar/nav-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    ListOfLoveteamsComponent,
    NavBarComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [LoveteamService],
  bootstrap: [AppComponent]
})
export class AppModule { }
