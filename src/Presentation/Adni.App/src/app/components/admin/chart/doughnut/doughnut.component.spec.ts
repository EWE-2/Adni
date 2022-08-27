import { waitForAsync, ComponentFixture, TestBed } from '@angular/core/testing';
import { NgChartsModule } from 'ng2-charts';

import { DoughnutComponent } from './doughnut.component';

describe('DoughnutComponent', () => {
  let component: DoughnutComponent;
  let fixture: ComponentFixture<DoughnutComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ DoughnutComponent ],
      imports: [ NgChartsModule ]
    }).compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DoughnutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should compile', () => {
    expect(component).toBeTruthy();
  });
});
