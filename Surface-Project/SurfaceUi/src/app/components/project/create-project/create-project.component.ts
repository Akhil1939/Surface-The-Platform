import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
@Component({
  selector: 'app-create-project',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
  ],
  templateUrl: './create-project.component.html',
  styleUrl: './create-project.component.css',
})
export class CreateProjectComponent {
  constructor() {
    console.log('create project loaded');
  }
  createProjectForm: FormGroup = new FormGroup({});

  ngOnInit() {
    this.createProjectForm = new FormGroup({
      title: new FormControl('', [Validators.required]),
    });
  }
  createProject(){
    console.log("form value",this.createProjectForm.value)
  } 
  dummy(){
    console.log("object")
  }
}
