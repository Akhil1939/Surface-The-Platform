import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-text-field',
  templateUrl: './text-field.component.html',
  styleUrls: ['./text-field.component.css']
})
export class TextFieldComponent {
  @Input() parentForm: any ;
  @Input() controlName: string = '';
  @Input() label: string = '';
  @Input() placeholder: string = '';
  @Input() type: string = '';
  @Input() disabled: boolean = false;
 


 


  get control(): FormControl {
    return this.parentForm.get(this.controlName) as FormControl;
  }
}
