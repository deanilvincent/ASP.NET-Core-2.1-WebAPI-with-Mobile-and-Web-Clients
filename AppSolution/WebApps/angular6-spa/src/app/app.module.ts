import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ListOfLoveteamsComponent } from './_loveteam/list-of-loveteams/list-of-loveteams.component';
import { LoveteamService } from './_services/loveteam.service';
import { NavBarComponent } from './_app-layout/nav-bar/nav-bar.component';

const appRoutes: Routes = [
  { path: '', component: ListOfLoveteamsComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    ListOfLoveteamsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes, {useHash: true})
  ],
  providers: [LoveteamService],
  bootstrap: [AppComponent]
})
export class AppModule { }
