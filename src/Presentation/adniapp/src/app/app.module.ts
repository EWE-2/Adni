import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AdniHeaderComponent } from './adni-header/adni-header.component';
import { AppRoutingModule } from './app-router.module';
import { AdnipageComponent } from './adnipage/adnipage.component';
import { AdniloadingComponent } from './adniloading/adniloading.component';

@NgModule({
  declarations: [
    AppComponent,
    AdnipageComponent,
    AdniloadingComponent,
    AdniHeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
