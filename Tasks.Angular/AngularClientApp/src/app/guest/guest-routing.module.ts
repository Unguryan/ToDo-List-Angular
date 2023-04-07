import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GuestMainMenuComponent } from './guest-main-menu/guest-main-menu.component';

const routes: Routes = [
  {path: "guest", component: GuestMainMenuComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GuestRoutingModule { }
