import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListadoShippersComponent } from './listado-shippers.component';

describe('ListadoShippersComponent', () => {
  let component: ListadoShippersComponent;
  let fixture: ComponentFixture<ListadoShippersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListadoShippersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListadoShippersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
