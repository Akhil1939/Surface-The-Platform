import { Component } from '@angular/core';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent {
ngOnInit(){

  document.addEventListener("DOMContentLoaded", function () {
    const navButtons = document.querySelectorAll(".nav-button");
  
    navButtons.forEach(function (button) {
      button.addEventListener("click", function (this: any) {
        // Remove "active" class from all buttons
        navButtons.forEach(function (btn) {
          btn.classList.remove("active");
        });
  
        // Add "active" class to the clicked button
        this.classList.add("active");
        
        // You can also use a data attribute to determine the target and perform further actions
        const target = this.getAttribute("data-target");
        console.log(`Button clicked: ${target}`);
      });
    });
  });
}
}
