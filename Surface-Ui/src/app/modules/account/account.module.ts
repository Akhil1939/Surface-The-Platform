import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountRoutingModule } from './account-routing.module';
import { AccountComponent } from '../../layout/account/account.component';
import { LoginComponent } from '../../components/accounts/login/login.component';
import { RegisterComponent } from '../../components/accounts/register/register.component';
import { GoogleLoginProvider, SocialAuthServiceConfig } from '@abacritt/angularx-social-login';
import { environment } from 'src/environments/environment.development';


@NgModule({
  declarations: [
    AccountComponent,
    LoginComponent,
    RegisterComponent
  ],
  imports: [
    CommonModule,
    AccountRoutingModule
  ],
  providers:[
    
  ]
})
export class AccountModule {
  
 }
