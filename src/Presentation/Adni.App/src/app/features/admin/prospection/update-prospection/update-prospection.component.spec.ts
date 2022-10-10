import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateProspectionComponent } from './update-prospection.component';

describe('UpdateProspectionComponent', () => {
  let component: UpdateProspectionComponent;
  let fixture: ComponentFixture<UpdateProspectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateProspectionComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateProspectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
