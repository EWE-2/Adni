import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsertionProComponent } from './insertion-pro.component';

describe('InsertionProComponent', () => {
  let component: InsertionProComponent;
  let fixture: ComponentFixture<InsertionProComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsertionProComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(InsertionProComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
