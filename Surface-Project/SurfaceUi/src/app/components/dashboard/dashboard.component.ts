import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardHeaderComponent } from '../app-layout/header/dashboard-header/dashboard-header.component';
import { DateServiceService } from '../../services/date-service.service';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [CommonModule, DashboardHeaderComponent],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {

  constructor(private dateService:DateServiceService) {
  }
   date:string = "";
   greeting:string="";
   ngOnInit(){
    this.date = this.dateService.getFormattedDate();
    this.greeting = this.dateService.getGreeting();
   }
}
