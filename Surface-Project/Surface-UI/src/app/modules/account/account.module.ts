import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AccountRoutingModule } from './account-routing.module';
import { LoginComponent } from './components/login/login.component';
import { AccountLayoutComponent } from './components/layout/account-layout/account-layout.component';
import { SharedModule } from '../shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    LoginComponent,
    AccountLayoutComponent,

  ],
  imports: [
    
    SharedModule,
    CommonModule,
    AccountRoutingModule
  ]
})
export class AccountModule { }
