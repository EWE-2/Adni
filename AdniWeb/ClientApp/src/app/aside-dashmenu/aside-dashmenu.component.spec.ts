import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AsideDashmenuComponent } from './aside-dashmenu.component';

describe('AsideDashmenuComponent', () => {
  let component: AsideDashmenuComponent;
  let fixture: ComponentFixture<AsideDashmenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AsideDashmenuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AsideDashmenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
