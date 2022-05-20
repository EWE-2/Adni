import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdnidashboardComponent } from './adnidashboard.component';

describe('AdnidashboardComponent', () => {
  let component: AdnidashboardComponent;
  let fixture: ComponentFixture<AdnidashboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdnidashboardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdnidashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
