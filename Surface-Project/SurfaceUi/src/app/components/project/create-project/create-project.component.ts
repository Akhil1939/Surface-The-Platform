import { MatIconModule } from '@angular/material/icon';
import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormArray,
  FormBuilder,
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatButtonModule } from '@angular/material/button';
import { iCreateProject, newProject } from '../../../interfaces/project_interfaces/iCreateProject.interface';
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
    MatIconModule,
  ],
  templateUrl: './create-project.component.html',
  styleUrl: './create-project.component.css',
})
export class CreateProjectComponent {
  createProjectForm: FormGroup = new FormGroup({});
  
  project:iCreateProject = newProject;

  constructor(private fb: FormBuilder) {
    console.log('create project loaded');
  }

 
  ngOnInit() {
    this.createProjectForm = this.fb.group({
      name: [this.project.name, [Validators.required]], 
      description:[''],
      teams: this.fb.array([]),
      startDate: [''],
      endDate: [''], 
      repoLink:[''],
      budget: [''],
    });
    console.log(this.Teams)
  } 
  get Teams():FormArray{
return this.createProjectForm.controls['teams'] as FormArray
  }
  AddTeam(){
    this.Teams.push(this.fb.control('')); 
    console.log(this.Teams)
  }
  RemoveTeam(id:number){
    this.Teams.controls.splice(id,1)
  }
  createProject() {
    if(this.createProjectForm.valid){

      this.project = this.createProjectForm.value;
    }
  console.log(this.project)
  }
}
