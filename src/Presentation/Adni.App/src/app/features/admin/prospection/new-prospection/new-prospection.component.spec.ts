import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewProspectionComponent } from './new-prospection.component';

describe('NewProspectionComponent', () => {
  let component: NewProspectionComponent;
  let fixture: ComponentFixture<NewProspectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewProspectionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewProspectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
