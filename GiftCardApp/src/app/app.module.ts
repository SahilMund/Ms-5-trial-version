import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LandingPageComponent } from './home/landing-page/landing-page.component';
import { GiftOrderDetailsService } from './services/gift-order-details.service';
import { ViewGiftCardComponent } from './gitcard/view-gift-card/view-gift-card.component';
import { AddViewGiftComponent } from './gitcard/add-view-gift/add-view-gift.component';
import {MatTableModule} from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http'; 


@NgModule({
  declarations: [
    AppComponent,
    LandingPageComponent,
    ViewGiftCardComponent,
    AddViewGiftComponent,
    ViewGiftCardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatTableModule,
    HttpClientModule
    
 
  ],
  providers: [GiftOrderDetailsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
