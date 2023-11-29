import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import { RouterModule } from '@angular/router';
@Component({
  selector: 'app-dashboard-header',
  standalone: true,
  imports: [CommonModule, MatButtonModule, MatMenuModule, MatIconModule, RouterModule],
  templateUrl: './dashboard-header.component.html',
  styleUrl: './dashboard-header.component.css'
})
export class DashboardHeaderComponent {

}
