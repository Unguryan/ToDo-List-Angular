import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GuestRoutingModule } from './guest-routing.module';
import { GuestMainMenuComponent } from './guest-main-menu/guest-main-menu.component';


@NgModule({
  declarations: [
    GuestMainMenuComponent
  ],
  imports: [
    CommonModule,
    GuestRoutingModule
  ]
})
export class GuestModule { }
