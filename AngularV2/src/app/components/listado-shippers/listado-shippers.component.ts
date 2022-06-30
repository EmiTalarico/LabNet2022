import { Component, OnInit } from '@angular/core';
import { Shippers } from 'src/app/interface/IShippers';
import { ShippersServicesService } from 'src/app/services/shippers-services.service';

@Component({
  selector: 'app-listado-shippers',
  templateUrl: './listado-shippers.component.html',
  styleUrls: ['./listado-shippers.component.css']
})
export class ListadoShippersComponent implements OnInit {

  shippers!:Shippers[]

  constructor(private services:ShippersServicesService) 
  { 
    this.services.getShippers().subscribe(s => this.shippers = s);
  }

  ngOnInit(): void {

  }

  eliminar(id:number){
    
    this.services.deleteShippers(id).subscribe(resp => {this.shippers = this.shippers.filter(s => s.Id != id)}); 
                 
}


}


