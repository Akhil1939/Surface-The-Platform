import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from 'src/app/components/accounts/login/login.component';
import { RegisterComponent } from 'src/app/components/accounts/register/register.component';
import { AccountComponent } from 'src/app/layout/account/account.component';

const routes: Routes = [
  {
    path:"",
    component:AccountComponent,
    
    children:[
      {
        path:"",
        component:LoginComponent,
      },
      {
        path:"register",
        component:RegisterComponent,
      }
    ]

  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AccountRoutingModule { }
