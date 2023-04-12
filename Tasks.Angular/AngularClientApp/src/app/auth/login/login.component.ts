import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MessageBoxService } from 'src/app/message-box.service';
import { SignalRService } from 'src/app/signal-r.service';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{

  loginWindow: Window | null;
  loadingTelegram: boolean = false;
  loadingGitHub: boolean = false;
  disabledButtons: boolean = false;

  constructor(private auth: AuthService,
              private signalR: SignalRService,
              private messageBox: MessageBoxService,
              private router: Router) {

  }
  ngOnInit() {
    localStorage.removeItem("auth");
    this.signalR.loggedByTelegramMessage.subscribe(resp =>{
      if(resp != null){
        var authCode = localStorage.getItem("auth");
        if(authCode == resp.AuthCode){
          localStorage.removeItem("auth");
          localStorage.setItem("token", resp.TokenData);

          if(this.loginWindow != null){
            this.loginWindow.close();
            this.loginWindow = null;
          }

          this.messageBox.NotifySuccess("Success. You`ll redirect in a second.")

          setTimeout(()=> {
            this.loadingTelegram = false;
            this.router.navigate(['/boards'])
            .then(() => {
              window.location.reload();
            });;
          }, 3000);
        }
      }
    });
  }

  LoginByTelegram() {
    if(this.loadingGitHub == true){
      return;
    }

    this.loadingTelegram = true;
    this.auth.LoginByTelegram().subscribe(resp =>{
      if(resp.key != null){
        localStorage.removeItem("auth");
        localStorage.setItem("auth", resp.key);

        this.loginWindow = window.open(resp.url);
      }
    });
  }

  LoginByGitHub() {
    if(this.loadingTelegram == true){
      return;
    }
    this.loadingGitHub = true;
  }
}
