import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardFeatureComponent } from './dashboard-feature.component';

describe('DashboardFeatureComponent', () => {
  let component: DashboardFeatureComponent;
  let fixture: ComponentFixture<DashboardFeatureComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DashboardFeatureComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DashboardFeatureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
