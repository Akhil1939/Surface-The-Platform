import { Routes } from '@angular/router';
import { CreateProjectComponent } from './components/project/create-project/create-project.component';
import { AppComponent } from './app.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AppLayoutComponent } from './components/app-layout/app-layout.component';

export const routes: Routes = [
  {
    path: '',

   
    children: [
      {
        path: '',
        redirectTo: 'dashboard',
        pathMatch: 'full',
      },
      {
        path: 'dashboard',
        component: DashboardComponent,
      },
      {
        path: 'project/create',
        component: CreateProjectComponent,
      },
    ],
  },
];
