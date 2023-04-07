import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthRoutingModule } from './auth-routing.module';
import { AuthNavMenuComponent } from './auth-nav-menu/auth-nav-menu.component';
import { HttpClientModule } from '@angular/common/http';

import { ButtonModule } from 'primeng/button';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AuthNavMenuComponent,
    LoginComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    AuthRoutingModule,

    ButtonModule
  ],
  exports: [
    AuthNavMenuComponent
  ]
})
export class AuthModule { }
