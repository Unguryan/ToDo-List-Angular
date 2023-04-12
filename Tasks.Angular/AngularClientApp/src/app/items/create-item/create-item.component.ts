import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { MessageBoxService } from 'src/app/message-box.service';
import { ItemsService } from '../items.service';

@Component({
  selector: 'app-create-item',
  templateUrl: './create-item.component.html',
  styleUrls: ['./create-item.component.css']
})
export class CreateItemComponent {

  formItem: FormGroup;
  itemNameControl: FormControl;

  private boardId: number;
  
  constructor(private builder: FormBuilder,
    private itemService: ItemsService,
    private messageBox: MessageBoxService,
    private router: Router,
    private activeRoute: ActivatedRoute) {
      const routeParams = this.activeRoute.snapshot.paramMap;
      this.boardId = Number(routeParams.get('boardId'));
}
  
  ngOnInit(){
    this.createForm();
  }

  createForm() {
    this.itemNameControl = this.builder.control('', [Validators.required]);
    this.formItem = this.builder.group(
    {
      itemName: this.itemNameControl,
    });
  }
  
  onSubmit(){
    this.itemService.CreateItem(this.itemNameControl.value, this.boardId).subscribe(resp => {
      console.dir(resp);
      if(resp.isCreated){
        this.messageBox.NotifySuccess(`Item '${resp.createdItem?.name}' is created. Redirecting to the board...`);
        
        setTimeout(()=>{
         this.router.navigate([`/board/${this.boardId}`]);
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
