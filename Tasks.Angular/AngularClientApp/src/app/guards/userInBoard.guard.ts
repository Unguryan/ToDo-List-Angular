import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { BoardsService } from '../board/boards.service';

@Injectable({
  providedIn: 'root'
})
export class UserInBoardGuard implements CanActivate {
  constructor(private boardService: BoardsService) { }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        const routeParams = route.paramMap;
        const boardIdFromRoute = Number(routeParams.get('boardId'));

        return new Observable<boolean>((observer) => {
            this.boardService.GetOwnBoardById(boardIdFromRoute).subscribe(resp =>{
                if(resp == undefined){
                    observer.next(false);
                    observer.complete();
                }
          
                if(!resp?.isFound){
                    observer.next(false);
                    observer.complete();
                }

                observer.next(true);
                observer.complete();
            });
        });
  }
}