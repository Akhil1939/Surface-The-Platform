import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatDialog, MatDialogModule} from '@angular/material/dialog';
import { FormGroup, FormBuilder, Validators, FormArray } from '@angular/forms';
import { iCreateProject, newProject } from '../../../interfaces/project_interfaces/iCreateProject.interface';

@Component({
  selector: 'app-edit-project-dialog',
  standalone: true,
  imports: [CommonModule, MatDialogModule],
  templateUrl: './edit-project-dialog.component.html',
  styleUrl: './edit-project-dialog.component.css'
})
export class EditProjectDialogComponent {
  updateProjectForm: FormGroup = new FormGroup({});
  
  project:iCreateProject = newProject;

  constructor(private fb: FormBuilder) {
    
  }

 
  ngOnInit() {
    this.updateProjectForm = this.fb.group({
      id:[''],
      name: [this.project.name, [Validators.required]], 
      description:[''],
      actualStartDate: [''],
      actualEndDate: [''], 
      repoLink:[''],
      budget: [''],
    }); 
  } 
  
  
  updateProject() {
    if(this.updateProjectForm.valid){

      this.project = this.updateProjectForm.value;
    }
  console.log(this.project)
  }
}
