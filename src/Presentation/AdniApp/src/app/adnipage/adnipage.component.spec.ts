import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdnipageComponent } from './adnipage.component';

describe('AdnipageComponent', () => {
  let component: AdnipageComponent;
  let fixture: ComponentFixture<AdnipageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdnipageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdnipageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
