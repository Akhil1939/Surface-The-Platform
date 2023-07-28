import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountRoutingModule } from './account-routing.module';
import { LoginComponent } from './components/login/login.component';
import { AccountLayoutComponent } from './components/layout/account-layout/account-layout.component';
import { SharedModule } from '../shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RegisterComponent } from './components/register/register.component';
import { GoogleLoginProvider } from '@abacritt/angularx-social-login';
import { environment } from 'src/environments/environment.development';
import { GoogleComponent } from './components/socialLogins/google/google.component';
import { FacebookComponent } from './components/socialLogins/facebook/facebook.component';
import { MicrosoftComponent } from './components/socialLogins/microsoft/microsoft.component';
import { ResetPasswordComponent } from './components/reset-password/reset-password.component';
import { ForgotPasswordComponent } from './components/forgot-password/forgot-password.component';


@NgModule({
  declarations: [
    LoginComponent,
    AccountLayoutComponent,
    RegisterComponent,
    GoogleComponent,
    FacebookComponent,
    MicrosoftComponent,
    ResetPasswordComponent,
    ForgotPasswordComponent,

  ],
  imports: [
    
    SharedModule,
    CommonModule,
    AccountRoutingModule
  ],
  
})
export class AccountModule { }
