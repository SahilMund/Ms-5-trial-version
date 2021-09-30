import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddViewGiftComponent } from './gitcard/add-view-gift/add-view-gift.component';
import { ViewGiftCardComponent } from './gitcard/view-gift-card/view-gift-card.component';
import { LandingPageComponent } from './home/landing-page/landing-page.component';

const routes: Routes = [
  {path:'',component:LandingPageComponent},
  {path:'viewData',component:ViewGiftCardComponent},
  {path:'addData',component:AddViewGiftComponent},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
