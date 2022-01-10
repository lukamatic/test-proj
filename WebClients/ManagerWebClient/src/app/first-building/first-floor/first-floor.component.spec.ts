import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FirstFloorComponent } from './first-floor.component';

describe('FirstFloorComponent', () => {
  let component: FirstFloorComponent;
  let fixture: ComponentFixture<FirstFloorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FirstFloorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FirstFloorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
