import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RapportStageComponent } from './rapport-stage.component';

describe('RapportStageComponent', () => {
  let component: RapportStageComponent;
  let fixture: ComponentFixture<RapportStageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RapportStageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RapportStageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
