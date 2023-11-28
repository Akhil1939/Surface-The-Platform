import { AfterViewInit, Component, ElementRef, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidebarComponent } from './sidebar/sidebar.component';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './header/header.component';

@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [CommonModule, SidebarComponent, RouterOutlet, HeaderComponent],
  templateUrl: './app-layout.component.html',
  styleUrl: './app-layout.component.css'
})
export class AppLayoutComponent {
  @ViewChild('body') body!: ElementRef;
  @ViewChild('sidebar') sidebar!: ElementRef;
@ViewChild(SidebarComponent) sidebarComponent:SidebarComponent |undefined ;

  ngAfterViewInit() {
    console.log("body",this.body);
    if (this.sidebarComponent) {
       
     const toggle:ElementRef|undefined = this.sidebarComponent.toggle;
     const searchBtn :ElementRef|undefined = this.sidebarComponent.searchBtn;
     const modeSwitch :ElementRef|undefined = this.sidebarComponent.modeSwitch;
     const modeText:ElementRef|undefined = this.sidebarComponent.modeText;


     toggle.nativeElement.addEventListener("click", () => {
       this.sidebar?.nativeElement.classList.toggle("close");
     });
 
     searchBtn.nativeElement.addEventListener("click", () => {
       console.log("search")
       this.sidebar?.nativeElement.classList.remove("close");
     });
 
     modeSwitch?.nativeElement.addEventListener("click", () => {
       console.log("mode clicked")
       this.body.nativeElement.classList.toggle("dark");
       console.log("change mode to dark")
       if (this.body.nativeElement.classList.contains("dark")) {
         modeText.nativeElement.innerText = "Light mode";
       } else {
         modeText.nativeElement.innerText = "Dark mode";
       }
     });
    }









  }
}
