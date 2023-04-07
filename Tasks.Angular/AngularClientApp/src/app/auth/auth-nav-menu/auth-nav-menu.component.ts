import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../auth.service';
import { ParseJwtService } from '../parse-jwt.service';
import { LogoutViewModel, TokenDataModel } from '../viewModels';

@Component({
  selector: 'app-auth-nav-menu',
  templateUrl: './auth-nav-menu.component.html',
  styleUrls: ['./auth-nav-menu.component.css']
})
export class AuthNavMenuComponent {
  user: TokenDataModel | undefined = undefined;
  loading: boolean = false;


  constructor(private parser: ParseJwtService,
              private auth: AuthService,
              private router: Router) {

  }

  ngOnInit() {
    this.parser.GetUserData().subscribe(resp => {
      this.user = resp;
      if(this.user?.name == undefined){
          this.LogOut(false);
         }
    });
  }

  LogOut(showMessage: boolean = true) {
    if (this.user != undefined){
      this.loading = true;
      this.auth.LogOut(new LogoutViewModel(this.user.token, this.user.id)).subscribe(resp =>{
        if(resp.isSuccess){
          localStorage.removeItem('token');

          setTimeout(() => {
            this.loading = false;
            if (showMessage) {
                alert("Success");
                window.location.reload();
            }
            else {
              window.location.reload();
            }
          }, 3000);

        }
      });
    }
  }
}
