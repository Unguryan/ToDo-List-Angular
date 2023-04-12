import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { MessageBoxService } from 'src/app/message-box.service';
import { BoardsService } from '../boards.service';

@Component({
  selector: 'app-create-board',
  templateUrl: './create-board.component.html',
  styleUrls: ['./create-board.component.css']
})
export class CreateBoardComponent implements OnInit{

  formBoard: FormGroup;
  boardNameControl: FormControl;

  constructor(private builder: FormBuilder,
              private boardService: BoardsService,
              private messageBox: MessageBoxService,
              private router: Router) {
      
  }

  ngOnInit(){
    this.createForm();
  }

  createForm() {
    this.boardNameControl = this.builder.control('', [Validators.required, Validators.minLength(4)]);
    this.formBoard = this.builder.group(
    {
      boardName: this.boardNameControl,
    });
  }
  
  onSubmit(){
    this.boardService.CreateBoard(this.boardNameControl.value).subscribe(resp => {
      if(resp.createdBoard != null){
        this.messageBox.NotifySuccess(`Board '${resp.createdBoard.name}' is created. Redirecting to the board...`);
        
        setTimeout(()=>{
         this.router.navigate([`/board/${resp.createdBoard.id}`]);
        }, 5000);
      }
      else{
        this.messageBox.NotifyError("Internal Server Error");
        setTimeout(()=>{
          window.location.reload();
        }, 3000);
      }
    });
  }
}
