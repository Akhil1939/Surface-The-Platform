import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SharedRoutingModule } from './shared-routing.module';
import { TextFieldComponent } from '../../components/form/input/text-field/text-field.component';
import { SubmitComponent } from '../../components/form/buttons/submit/submit.component';
import { CancelComponent } from '../../components/form/buttons/cancel/cancel.component';
import { TextAreaComponent } from '../../components/form/input/text-area/text-area.component';


@NgModule({
  declarations: [
    TextFieldComponent,
    SubmitComponent,
    CancelComponent,
    TextAreaComponent
  ],
  imports: [
    CommonModule,
    SharedRoutingModule
  ]
})
export class SharedModule { }
