import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BoardRoutingModule } from './board-routing.module';
import { BoardViewComponent } from './board-view/board-view.component';
import { BoardDetailsComponent } from './board-details/board-details.component';
import { CreateBoardComponent } from './create-board/create-board.component';
import { BoardListComponent } from './board-list/board-list.component';

import { DragDropModule } from '@angular/cdk/drag-drop';
import { DropdownModule } from 'primeng/dropdown';
import { ButtonModule } from 'primeng/button';
import { TooltipModule } from 'primeng/tooltip';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HoverDirective } from './hover.directive';
import { ItemMiniComponent } from '../items/item-mini/item-mini.component';


@NgModule({
  declarations: [
    BoardViewComponent,
    BoardDetailsComponent,
    CreateBoardComponent,
    BoardListComponent,
    HoverDirective,
    ItemMiniComponent
  ],
  imports: [
    CommonModule,
    BoardRoutingModule,
    FormsModule,
    ReactiveFormsModule,

    DragDropModule,
    DropdownModule,
    ButtonModule,
    TooltipModule
  ]
})
export class BoardModule { }
