import { Component } from '@angular/core';
import { AuthService } from '../auth/auth.service';
import { ParseJwtService } from '../auth/parse-jwt.service';
import { TokenDataModel } from '../auth/viewModels';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  user: TokenDataModel | undefined = undefined;
  
  constructor(private parser: ParseJwtService,
              private auth: AuthService) {
}

  ngOnInit() {
    this.parser.GetUserData().subscribe(resp => {
      this.user = resp;
    });
  }

}
