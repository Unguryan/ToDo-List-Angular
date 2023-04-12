import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthedGuard } from '../guards/authed.guard';
import { UserInBoardGuard } from '../guards/userInBoard.guard';
import { CreateItemComponent } from './create-item/create-item.component';
import { ItemDetailsComponent } from './item-details/item-details.component';

const routes: Routes = [
  { path: "item/create/:boardId", component: CreateItemComponent, canActivate: [AuthedGuard, UserInBoardGuard]},
  { path: "item/:boardId/:itemId", component: ItemDetailsComponent, canActivate: [AuthedGuard, UserInBoardGuard]},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ItemsRoutingModule { }
