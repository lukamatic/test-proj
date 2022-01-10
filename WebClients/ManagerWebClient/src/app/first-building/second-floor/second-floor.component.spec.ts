import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SecondFloorComponent } from './second-floor.component';

describe('SecondFloorComponent', () => {
  let component: SecondFloorComponent;
  let fixture: ComponentFixture<SecondFloorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SecondFloorComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SecondFloorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
