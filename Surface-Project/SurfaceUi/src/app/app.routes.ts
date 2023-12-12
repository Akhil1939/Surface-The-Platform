import { Component } from '@angular/core';
import { Routes } from '@angular/router';
import { CreateProjectComponent } from './components/project/create-project/create-project.component';
import { AppComponent } from './app.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AppLayoutComponent } from './components/app-layout/app-layout.component';
import { RegisterComponent } from './components/account/register/register.component';
import { LayoutComponent } from './components/account/layout/layout.component';
import { LoginComponent } from './components/account/login/login.component';
import { ProjectDetailLayoutComponent } from './components/project/project-detail-layout/project-detail-layout.component';

export const routes: Routes = [
  {
    path: 'account',
    component: LayoutComponent,
    children: [
      {
        path: '',
        redirectTo: 'login',
        pathMatch: 'full',  
      },
      {
        path: 'register',
        component: RegisterComponent,
      },
      {
        path: 'login',
        component: LoginComponent,
      },
    ],
  },
  {
    path: '',
    component: AppLayoutComponent,
    children: [
      {
        path: 'dashboard',
        component: DashboardComponent,
      },
      {
        path: 'create',
        children: [
          {
            path: '',
            redirectTo: 'project',
            pathMatch: 'full',
          },
          {
            path: 'project',
            component: CreateProjectComponent,
          },
        ],
      },
      {
        path:"project/:id",
        component:ProjectDetailLayoutComponent,
      }
    ],
  },
];
