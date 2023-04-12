import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { SelectItem, SelectItemGroup } from 'primeng/api';
import { ParseJwtService } from 'src/app/auth/parse-jwt.service';
import { MessageBoxService } from 'src/app/message-box.service';
import { BoardsService } from '../boards.service';
import { Board } from '../viewModels';

@Component({
  selector: 'app-board-list',
  templateUrl: './board-list.component.html',
  styleUrls: ['./board-list.component.css']
})
export class BoardListComponent {

  private ownBoards: Array<Board> | undefined;
  private sharedBoards: Array<Board> | undefined;

  public selectedBoard: Board | undefined;
  public boards: SelectItemGroup[];

  constructor(private parser: ParseJwtService,
              private boardService: BoardsService,
              private messsageBox: MessageBoxService,
              private router: Router) {
  }

  ngOnInit(){
    this.parser.GetUserData().subscribe(respUser =>{
      if(respUser == null || respUser.name == undefined){
        return;
      }

      this.boardService.GetBoards().subscribe(resp =>{
        this.ownBoards = resp.boards?.filter(b => b.owner.id == respUser.id);
        this.sharedBoards = resp.boards?.filter(b => b.owner.id != respUser.id);
        this.FillBoards();
      });
    });
  }

  FillBoards() {
    var ownBoards = new Array<SelectItem>();
    this.ownBoards?.forEach(b => {
      var item = {
        label: b.name,
        value: b
      };

      ownBoards.push(item);
    });

    var sharedBoards = new Array<SelectItem>();
    this.sharedBoards?.forEach(b => {
      var item = {
        label: b.name,
        value: b
      };

      sharedBoards.push(item);
    });

    console.dir(ownBoards);
    console.dir(sharedBoards);

    this.boards = [
      {
        label: 'Own Boards',
        items: ownBoards
      },
      {
        label: 'Shared Boards',
        items: sharedBoards
      }
    ];
    console.dir(this.boards);
  }

  SelectBoard(){
    if(this.selectedBoard == null){
      this.messsageBox.NotifyError("Error. You need to select board.")
    }
    else{
      var url = "/board/" + this.selectedBoard.id;
      this.router.navigate([url]);
    }
  }
}



