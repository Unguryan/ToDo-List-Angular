import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UnauthedGuard } from '../guards/unauthed.guard';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  { path: "login", component: LoginComponent, canActivate: [UnauthedGuard]}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthRoutingModule { }
