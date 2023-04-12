import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ParseJwtService } from '../auth/parse-jwt.service';
import { TokenDataModel } from '../auth/viewModels';
import { environment } from '../environment';
import { CreateBoardResultViewModel, CreateBoardViewModel, GetUserBoardByIdResultViewModel, GetUserBoardsResultViewModel } from './viewModels';

@Injectable({
  providedIn: 'root'
})
export class BoardsService {
  
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

  GetBoards(): Observable<GetUserBoardsResultViewModel>{
    var url = environment.Backend_API + "board/" + this.user?.id;

    return this.http.get<GetUserBoardsResultViewModel>(url, {
      headers: this.headers
    });
  }

  GetBoardById(idUser: number, boardId: number) : Observable<GetUserBoardByIdResultViewModel> {
    var url = environment.Backend_API + `board/${idUser}/${boardId}`;
    
    return this.http.get<GetUserBoardByIdResultViewModel>(url,{
      headers: this.headers
    });
  }

  GetOwnBoardById(boardId: number) : Observable<GetUserBoardByIdResultViewModel> {
    var url = environment.Backend_API + `board/${this.user?.id}/${boardId}`;
    
    return this.http.get<GetUserBoardByIdResultViewModel>(url,{
      headers: this.headers
    });
  }

  CreateBoard(name: string): Observable<CreateBoardResultViewModel>{
    var url = environment.Backend_API + "board/create";
    var payload = new CreateBoardViewModel(this.user?.id!, name);
    
    return this.http.post<CreateBoardResultViewModel>(url, payload,{
      headers: this.headers
    });
  }
}
