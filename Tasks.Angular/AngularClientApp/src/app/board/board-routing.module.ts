import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthedGuard } from '../guards/authed.guard';
import { BoardDetailsComponent } from './board-details/board-details.component';
import { BoardListComponent } from './board-list/board-list.component';
import { BoardViewComponent } from './board-view/board-view.component';
import { CreateBoardComponent } from './create-board/create-board.component';

const routes: Routes = [
  { path: "boards", component: BoardListComponent, canActivate: [AuthedGuard]},
  { path: "board/create", component: CreateBoardComponent, canActivate: [AuthedGuard]},
  { path: "board/:boardId/details", component: BoardDetailsComponent, canActivate: [AuthedGuard]},
  { path: "board/:boardId", component: BoardViewComponent, canActivate: [AuthedGuard]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BoardRoutingModule { }
