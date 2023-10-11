import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './container/layout/layout.component';

const routes: Routes = [
  {path: '', redirectTo: 'account', pathMatch: 'full'},
  {path: 'account', loadChildren: () => import('./modules/account/account.module').then(m => m.AccountModule)},
  {path:'dashboard',
  component:LayoutComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
