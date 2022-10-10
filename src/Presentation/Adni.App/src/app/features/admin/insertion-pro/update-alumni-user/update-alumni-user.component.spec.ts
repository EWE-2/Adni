import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateAlumniUserComponent } from './update-alumni-user.component';

describe('UpdateAlumniUserComponent', () => {
  let component: UpdateAlumniUserComponent;
  let fixture: ComponentFixture<UpdateAlumniUserComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateAlumniUserComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdateAlumniUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
