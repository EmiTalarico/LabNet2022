import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AgregarShippersComponent } from './agregar-shippers.component';

describe('AgregarShippersComponent', () => {
  let component: AgregarShippersComponent;
  let fixture: ComponentFixture<AgregarShippersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AgregarShippersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AgregarShippersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
