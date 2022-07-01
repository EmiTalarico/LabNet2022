import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EliminarShippersComponent } from './eliminar-shippers.component';

describe('EliminarShippersComponent', () => {
  let component: EliminarShippersComponent;
  let fixture: ComponentFixture<EliminarShippersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EliminarShippersComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EliminarShippersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
