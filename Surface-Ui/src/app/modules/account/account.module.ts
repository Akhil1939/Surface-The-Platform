import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountRoutingModule } from './account-routing.module';
import { AccountComponent } from '../../layout/account/account.component';
import { LoginComponent } from '../../components/accounts/login/login.component';
import { RegisterComponent } from '../../components/accounts/register/register.component';
import { GoogleLoginProvider, SocialAuthServiceConfig } from '@abacritt/angularx-social-login';
import { environment } from 'src/environments/environment.development';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [
    AccountComponent,
    LoginComponent,
    RegisterComponent
  ],
  imports: [
    CommonModule,
    AccountRoutingModule,
    SharedModule
  ],
  providers:[
    
  ]
})
export class AccountModule {
  
 }
