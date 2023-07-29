import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TextFieldComponent } from './components/form/input/text-field/text-field.component';
import { MaterialUiModule } from '../material-ui/material-ui.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    TextFieldComponent,
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
  
    ReactiveFormsModule,
    TextFieldComponent
  ]
})
export class SharedModule { }
