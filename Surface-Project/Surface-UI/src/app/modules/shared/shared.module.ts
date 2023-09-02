import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TextFieldComponent } from './components/form/input/text-field/text-field.component';
import { MaterialUiModule } from '../material-ui/material-ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { SnackbarComponent } from './components/snackbar/snackbar.component';
import { SpinnerComponent } from './components/spinner/spinner.component';



@NgModule({
  declarations: [
    TextFieldComponent,
    SnackbarComponent,
  SpinnerComponent,
  ],
  imports: [
    FormsModule,
    ReactiveFormsModule,
    CommonModule,
    MaterialUiModule,
    FormsModule,
    ReactiveFormsModule,
    
  ],
  exports: [
    FormsModule,
  SnackbarComponent,
  SpinnerComponent,
    ReactiveFormsModule,
    TextFieldComponent,
    MaterialUiModule
  ]
})
export class SharedModule { }
