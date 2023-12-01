import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header/header.component';

@Component({
  selector: 'app-project-detail-layout',
  standalone: true,
  imports: [CommonModule, HeaderComponent],
  templateUrl: './project-detail-layout.component.html',
  styleUrl: './project-detail-layout.component.css'
})
export class ProjectDetailLayoutComponent {

}
