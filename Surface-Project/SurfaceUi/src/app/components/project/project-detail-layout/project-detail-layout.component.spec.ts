import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectDetailLayoutComponent } from './project-detail-layout.component';

describe('ProjectDetailLayoutComponent', () => {
  let component: ProjectDetailLayoutComponent;
  let fixture: ComponentFixture<ProjectDetailLayoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ProjectDetailLayoutComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ProjectDetailLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
