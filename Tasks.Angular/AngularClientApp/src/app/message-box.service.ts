import { Injectable } from '@angular/core';
import { NotifierService } from 'angular-notifier';

@Injectable({
  providedIn: 'root'
})
export class MessageBoxService {

  constructor(private notify: NotifierService) { }

  NotifySuccess(message: string){
    this.notify.notify('success', message);
  }

  NotifyInfo(message: string){
    this.notify.notify('info', message);
  }

  NotifyError(message: string){
    this.notify.notify('error', message);
  }
}
