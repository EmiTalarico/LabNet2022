import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Shippers } from 'src/app/interface/IShippers';
import { ShippersServicesService } from 'src/app/services/shippers-services.service';

@Component({
  selector: 'app-agregar-shippers',
  templateUrl: './agregar-shippers.component.html',
  styleUrls: ['./agregar-shippers.component.css']
})
export class AgregarShippersComponent implements OnInit {

  formulario:FormGroup;

  constructor(private fb:FormBuilder , private service: ShippersServicesService) 
  {
    this.formulario= this.fb.group({
      Nombre:['', [Validators.required]],
      Telefono:['', [Validators.required]]
    })

   }

  ngOnInit(): void {
    console.log(this.formulario.status);
  }

  Guardar(){
    
    if (this.formulario.invalid) {
      return;
    }
    let shipper: Shippers = {
      Nombre: this.formulario.get('Nombre')?.value,
      Telefono: this.formulario.get('Telefono')?.value
    }
    this.service.postShippers(shipper).subscribe();
    this.formulario.reset();
    console.log(this.formulario.status);
  }

  

}
