import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AlmniSignUpComponent } from './almni-sign-up.component';

describe('AlmniSignUpComponent', () => {
  let component: AlmniSignUpComponent;
  let fixture: ComponentFixture<AlmniSignUpComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AlmniSignUpComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AlmniSignUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
