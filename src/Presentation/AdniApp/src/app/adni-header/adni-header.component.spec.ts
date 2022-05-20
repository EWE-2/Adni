import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdniHeaderComponent } from './adni-header.component';

describe('AdniHeaderComponent', () => {
  let component: AdniHeaderComponent;
  let fixture: ComponentFixture<AdniHeaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdniHeaderComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdniHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
