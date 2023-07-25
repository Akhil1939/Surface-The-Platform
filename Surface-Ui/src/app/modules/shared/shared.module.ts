import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


import { TextFieldComponent } from '../../components/form/input/text-field/text-field.component';
import { SubmitComponent } from '../../components/form/buttons/submit/submit.component';
import { CancelComponent } from '../../components/form/buttons/cancel/cancel.component';
import { TextAreaComponent } from '../../components/form/input/text-area/text-area.component';
import { MaterialModule } from '../material/material.module';


@NgModule({
  declarations: [
    TextFieldComponent,
    SubmitComponent,
    CancelComponent,
    TextAreaComponent
  ],
  imports: [
    CommonModule,
    MaterialModule
  ],
  exports: [
    TextFieldComponent,
  ]
})
export class SharedModule { }
