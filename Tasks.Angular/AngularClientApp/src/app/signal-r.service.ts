import { Injectable } from '@angular/core';
import * as signalR from '@microsoft/signalr';

import { BehaviorSubject } from 'rxjs';
import { environment } from './environment';
import { LoggedByTelegramEvent } from './signal-r.models';

@Injectable({
  providedIn: 'root'
})
export class SignalRService {

  hubUrl: string;
  connection: any;

  authErrorMessage: BehaviorSubject<string>;
  loggedByTelegramMessage: BehaviorSubject<LoggedByTelegramEvent | null>;
  //loggedByTelegramMessage: BehaviorSubject<string>;

  constructor() {
    this.hubUrl = environment.signalRHub;

    this.authErrorMessage = new BehaviorSubject<string>('');
    this.loggedByTelegramMessage = new BehaviorSubject<LoggedByTelegramEvent | null>(null);
    //this.loggedByTelegramMessage = new BehaviorSubject<string>('');
  }

  public async initiateSignalrConnection(): Promise<void> {
    try {
      this.connection = new signalR.HubConnectionBuilder()
        .withUrl(this.hubUrl)
        .withAutomaticReconnect()
        .build();

      await this.connection.start();
      this.setSignalrClientMethods();

      console.log(`SignalR connection success! connectionId: ${this.connection.connectionId}`);
    }
    catch (error) {
      console.log(`SignalR connection error: ${error}`);
    }
  }

  private setSignalrClientMethods(): void {
    this.connection.on('AuthErrorNotification', (message: string) => {
      this.authErrorMessage.next(message);
    });

    this.connection.on('LoggedByTelegramNotification', (message: string) => {
      var obj = JSON.parse(message) as LoggedByTelegramEvent;
      this.loggedByTelegramMessage.next(obj);
    });

    //TODO:More Events
    // this.connection.on('LoggedByTelegramNotification', (message: string) => {
    //   this.loggedByTelegramMessage.next(message);
    // });
  }
}
