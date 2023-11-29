import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';
import { AppLayoutComponent } from './app/components/app-layout/app-layout.component';

bootstrapApplication(AppLayoutComponent, appConfig)
  .catch((err) => console.error(err));
