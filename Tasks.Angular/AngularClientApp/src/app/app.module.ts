import { APP_INITIALIZER, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';

import { AuthModule } from './auth/auth.module';
import { GuestModule } from './guest/guest.module';

import { SignalRService } from './signal-r.service';
import { NotifierModule } from 'angular-notifier';
import { notifierOptions } from './environment';
import { BoardModule } from './board/board.module';
import { ItemsModule } from './items/items.module';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    NotifierModule.withConfig(notifierOptions),

    ItemsModule,
    BoardModule,
    GuestModule,
    AuthModule
  ],
  providers: [
    SignalRService,
    {
      provide: APP_INITIALIZER,
      useFactory: (signalrService: SignalRService) => () => signalrService.initiateSignalrConnection(),
      deps: [SignalRService],
      multi: true,
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
