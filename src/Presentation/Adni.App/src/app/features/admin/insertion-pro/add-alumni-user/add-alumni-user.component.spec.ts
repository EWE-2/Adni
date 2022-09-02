import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddAlumniUserComponent } from './add-alumni-user.component';

describe('AddAlumniUserComponent', () => {
  let component: AddAlumniUserComponent;
  let fixture: ComponentFixture<AddAlumniUserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddAlumniUserComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddAlumniUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
