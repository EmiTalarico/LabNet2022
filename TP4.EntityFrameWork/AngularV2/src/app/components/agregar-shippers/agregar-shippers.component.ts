import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Shippers } from 'src/app/interface/IShippers';
import { ShippersServicesService } from 'src/app/services/shippers-services.service';
import { ActivatedRoute, Router } from '@angular/router';
import { switchMap } from 'rxjs';

@Component({
  selector: 'app-agregar-shippers',
  templateUrl: './agregar-shippers.component.html',
  styleUrls: ['./agregar-shippers.component.css']
})
export class AgregarShippersComponent implements OnInit {

  formulario:FormGroup;
  shippers:Shippers = {
    Id:0,
    Nombre:'',
    Telefono:''    
  }

  mensaje: string = ''

  constructor(private fb:FormBuilder , private service: ShippersServicesService,
              private activateRoute:ActivatedRoute,
              private router:Router) 
  {
    this.formulario= this.fb.group({
      Id:[0],
      Nombre:['', [Validators.required]],
      Telefono:['', [Validators.required]]
    })

   }

  ngOnInit(): void {
    if (this.router.url.includes('editar')) {
      this.activateRoute.params
          .pipe(
            switchMap(({id})=> this.service.getShippersById(id))
          )
          .subscribe(s => {
            this.shippers = s
            this.formulario.setValue(s)
          })
    }
  }


  Guardar(){
    
    if (this.formulario.invalid) {
      return;
    }
    let shipper: Shippers = {
      Nombre: this.formulario.get('Nombre')?.value,
      Telefono: this.formulario.get('Telefono')?.value
    }
    if (this.shippers.Id ==0) {
      this.service.postShippers(shipper).subscribe(resp => {
        this.mensaje = 'Agregado con exito'
        setTimeout(() => {
          this.mensaje = '';
        }, 3000);
      });
      this.formulario.reset();      
    }
    else{
      shipper.Id = this.formulario.get('Id')?.value
      this.service.patchShippers(shipper).subscribe();
    }
    this.router.navigate(['/listado'])
  }

  

}
