import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AlumniLogInComponent } from './alumni-log-in.component';

describe('AlumniLogInComponent', () => {
  let component: AlumniLogInComponent;
  let fixture: ComponentFixture<AlumniLogInComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AlumniLogInComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AlumniLogInComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
