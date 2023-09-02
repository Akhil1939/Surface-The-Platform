import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatIconModule} from '@angular/material/icon';
import { MatSnackBar, MatSnackBarModule } from '@angular/material/snack-bar';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatFormFieldModule, MatInputModule , MatIconModule,
    MatSnackBarModule,
  ],
  exports: [
    MatFormFieldModule, MatInputModule, MatIconModule,   MatSnackBarModule,
  ]
})
export class MaterialUiModule { }
