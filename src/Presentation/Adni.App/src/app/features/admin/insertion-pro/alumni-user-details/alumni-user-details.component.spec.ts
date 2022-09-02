import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AlumniUserDetailsComponent } from './alumni-user-details.component';

describe('AlumniUserDetailsComponent', () => {
  let component: AlumniUserDetailsComponent;
  let fixture: ComponentFixture<AlumniUserDetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AlumniUserDetailsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AlumniUserDetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
