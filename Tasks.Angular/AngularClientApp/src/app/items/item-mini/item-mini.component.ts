import { Component, Input } from '@angular/core';
import { Item } from '../viewModels';

@Component({
  selector: 'app-item-mini',
  templateUrl: './item-mini.component.html',
  styleUrls: ['./item-mini.component.css']
})
export class ItemMiniComponent {
  @Input('selectedItem') selectedItem: Item | null;
}
