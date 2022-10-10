import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheminComponent } from './chemin.component';

describe('CheminComponent', () => {
  let component: CheminComponent;
  let fixture: ComponentFixture<CheminComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CheminComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CheminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
