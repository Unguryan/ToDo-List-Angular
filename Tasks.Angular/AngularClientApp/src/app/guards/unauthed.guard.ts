import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { ParseJwtService } from '../auth/parse-jwt.service';

@Injectable({
  providedIn: 'root'
})
export class UnauthedGuard implements CanActivate {
  constructor(private parser: ParseJwtService) { }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      var res = false;
      this.parser.GetUserData().subscribe(resp =>{
        if(resp == undefined){
          res = true;
        }
  
        if(resp?.name == undefined){
          res = true;
          }
      });
  
      return res;
  }
}
