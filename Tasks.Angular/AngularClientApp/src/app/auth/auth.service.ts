import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { environment } from '../environment';
import { LoginByTelegramResultViewModel, LogoutResultViewModel, LogoutViewModel } from './viewModels';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  LoginByTelegram(): Observable<LoginByTelegramResultViewModel>{
    var url = environment.Backend_API + "auth/login/telegram";
    return this.http.get<LoginByTelegramResultViewModel>(url);
  }

  LoginByGitHub(): Observable<LoginByTelegramResultViewModel>{
    var url = environment.Backend_API + "auth/login/github";
    return this.http.get<LoginByTelegramResultViewModel>(url);
  }

  LogOut(req: LogoutViewModel): Observable<LogoutResultViewModel>{
    var url = environment.Backend_API + "auth/logout";
    return this.http.post<LogoutResultViewModel>(url, req);
  }
}
