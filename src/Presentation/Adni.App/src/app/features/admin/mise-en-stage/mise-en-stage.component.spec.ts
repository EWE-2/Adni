import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MiseEnStageComponent } from './mise-en-stage.component';

describe('MiseEnStageComponent', () => {
  let component: MiseEnStageComponent;
  let fixture: ComponentFixture<MiseEnStageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MiseEnStageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MiseEnStageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
