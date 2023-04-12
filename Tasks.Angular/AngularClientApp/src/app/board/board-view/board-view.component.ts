import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ParseJwtService } from 'src/app/auth/parse-jwt.service';
import { ItemsService } from 'src/app/items/items.service';
import { Item, ItemState } from 'src/app/items/viewModels';
import { MessageBoxService } from 'src/app/message-box.service';
import { BoardsService } from '../boards.service';
import { Board } from '../viewModels';

@Component({
  selector: 'app-board-view',
  templateUrl: './board-view.component.html',
  styleUrls: ['./board-view.component.css']
})
export class BoardViewComponent implements OnInit {

  board: Board | undefined;
  columnsHeaders: Array<string>;

  itemTable: Array<ItemColumnViewModel>;
  indexes: Array<number>;

  constructor(private route: ActivatedRoute,
              private router: Router,
              private boardService: BoardsService,
              private itemService: ItemsService,
              private parser: ParseJwtService,
              private messageBox: MessageBoxService) { }

  ngOnInit() {
    this.columnsHeaders = Object.keys(ItemState).filter((item) => {
      return isNaN(Number(item));
    });

    const routeParams = this.route.snapshot.paramMap;
    const boardIdFromRoute = Number(routeParams.get('boardId'));

    this.parser.GetUserData().subscribe(respUser => {
      if(respUser?.name == undefined){
        return;
      }

      this.boardService.GetBoardById(respUser.id, boardIdFromRoute).subscribe(resp =>{
        if(resp.isFound){
          this.board = resp.board;
          this.FillItemTable();
        }
        else{
          this.messageBox.NotifyError("Board was not found.");
        }
      });

    });
  }

  FillItemTable() {
    var columns = Object.keys(ItemState).filter((item) => {
      return !isNaN(Number(item));
    }).map(item =>{
      return new Number(item);
    });

    this.itemTable = Array<ItemColumnViewModel>();
    columns.forEach(c => {

      var element = new ItemColumnViewModel(c as ItemState, 
        this.board?.items?.filter(o => o.state == c)!);
      this.itemTable.push(element);
    });

    var max = this.itemTable.reduce((item, curr) => {
      return item.items.length < curr.items.length ? curr : item;
    })?.items.length;

    this.indexes = new Array(max);
    for (let index = 0; index < max; index++) {
      this.indexes[index] = index;
    }
  }

  // GetItem(columnName: ItemState, index: number) : Item | null{
  //   return this.itemTable.find(x => x.column == columnName)?.items[index] ?? null;
  // }

  
  // GetItem(columnName: string, index: number) : Item | null{
  //   return this.itemTable?.find(x => ItemState[x.column] == columnName)?.items[index] ?? null;
  // }

  // GetItems(columnName: string): Array<Item> | undefined{
  //   return this.itemTable?.find(x => ItemState[x.column] == columnName)?.items;
  // }

  
  GoToBoardDetails(){
    this.router.navigate([`board/${this.board?.id}/details`]);
  }

  GoToAddNewTaskView(){
    this.router.navigate([`item/create/${this.board?.id}`]);
  }

  Drop(event: CdkDragDrop<Item[]>){
      //console.dir(event);
      //console.dir(event.item);
      //console.dir();
      // console.dir(event.previousContainer.element.nativeElement.className);
      // console.dir(event.container.element.nativeElement.className);


      // console.dir(event.previousContainer.data);
      // console.dir(event.container.data);
      // console.dir(event.previousIndex);
      // console.dir(event.currentIndex);

    if (event.previousContainer === event.container) {
      return;
      // moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
    } else {

      var item = event.item.data as Item;

      var idState = (new Number(event.container.element.nativeElement.className.match(/column \d/)?.[0].replace("column", ""))) as ItemState;
      //var newState = 

      this.itemService.ChangeItemState(this.board?.id!, item.id, idState).subscribe(
        resp =>{
          if(resp.isChanged){
            transferArrayItem(
              event.previousContainer.data,
              event.container.data,
              event.previousIndex,
              event.currentIndex,
            );

            this.messageBox.NotifyInfo(`Item '${resp.item?.name}' moved to '${ItemState[resp.item?.state!]}'`);
          }
        }
      );

      // console.dir(ItemState[item.state]);
      // console.dir(ItemState[idState]);


      
    }
  }
}


class ItemColumnViewModel
{
  constructor(public column: ItemState,
              public items: Array<Item>) {
  }
}