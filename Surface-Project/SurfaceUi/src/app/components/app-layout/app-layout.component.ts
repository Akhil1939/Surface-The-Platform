import { Component, ElementRef, ViewChild } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SidebarComponent } from './sidebar/sidebar.component';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-layout',
  standalone: true,
  imports: [CommonModule, SidebarComponent, RouterOutlet],
  templateUrl: './app-layout.component.html',
  styleUrl: './app-layout.component.css'
})
export class AppLayoutComponent {
  @ViewChild('body') body!: ElementRef;
  @ViewChild('sidebar') sidebar!: ElementRef;
  @ViewChild('toggle') toggle!: ElementRef;
  @ViewChild('searchBtn') searchBtn!: ElementRef;
  @ViewChild('modeSwitch') modeSwitch!: ElementRef;
  @ViewChild('modeText') modeText!: ElementRef;

  ngAfterViewInit() {
    this.toggle.nativeElement.addEventListener("click", () => {
      this.sidebar.nativeElement.classList.toggle("close");
    });

    this.searchBtn.nativeElement.addEventListener("click", () => {
      console.log("search")
      this.sidebar.nativeElement.classList.remove("close");
    });

    this.modeSwitch.nativeElement.addEventListener("click", () => {
      console.log("mode clicked")
      this.body.nativeElement.classList.toggle("dark");
      console.log("change mode to dark")
      if (this.body.nativeElement.classList.contains("dark")) {
        this.modeText.nativeElement.innerText = "Light mode";
      } else {
        this.modeText.nativeElement.innerText = "Dark mode";
      }
    });
  }
}
