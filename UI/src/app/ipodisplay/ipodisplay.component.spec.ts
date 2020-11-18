import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { IpodisplayComponent } from './ipodisplay.component';

describe('IpodisplayComponent', () => {
  let component: IpodisplayComponent;
  let fixture: ComponentFixture<IpodisplayComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IpodisplayComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IpodisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
