import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdniloadingComponent } from './adniloading.component';

describe('AdniloadingComponent', () => {
  let component: AdniloadingComponent;
  let fixture: ComponentFixture<AdniloadingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdniloadingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdniloadingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
