import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SectorchartComponent } from './sectorchart.component';

describe('SectorchartComponent', () => {
  let component: SectorchartComponent;
  let fixture: ComponentFixture<SectorchartComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SectorchartComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SectorchartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
