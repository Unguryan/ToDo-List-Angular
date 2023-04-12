import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ParseJwtService } from '../auth/parse-jwt.service';
import { TokenDataModel } from '../auth/viewModels';
import { environment } from '../environment';
import { ChangeItemResultViewModel, ChangeItemStateViewModel, CreateItemResultViewModel, CreateItemViewModel, ItemState } from './viewModels';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  user: TokenDataModel | undefined = undefined;
  headers: HttpHeaders;

  constructor(private http: HttpClient,
              private parser: ParseJwtService) { 

    this.parser.GetUserData().subscribe(resp => {
      this.user = resp;
    });

    var authToken = localStorage.getItem('token');

    this.headers = new HttpHeaders({ 'Authorization': `Bearer ${authToken}` });
  }

  CreateItem(name: string, boardId: number): Observable<CreateItemResultViewModel>{
    var url = environment.Backend_API + "item/create";
    var payload = new CreateItemViewModel(this.user?.id!, boardId, name);
    
    return this.http.post<CreateItemResultViewModel>(url, payload,{
      headers: this.headers
    });
  }

  ChangeItemState(boardId: number, itemId: number, newState: ItemState): Observable<ChangeItemResultViewModel>{
    var url = environment.Backend_API + "item/change/state";
    var payload = new ChangeItemStateViewModel(this.user?.id!, boardId, itemId, newState);
    
    return this.http.post<ChangeItemResultViewModel>(url, payload,{
      headers: this.headers
    });
  }
}
