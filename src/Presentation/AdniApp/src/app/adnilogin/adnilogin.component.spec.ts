import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdniloginComponent } from './adnilogin.component';

describe('AdniloginComponent', () => {
  let component: AdniloginComponent;
  let fixture: ComponentFixture<AdniloginComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdniloginComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdniloginComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
