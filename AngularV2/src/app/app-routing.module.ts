import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgregarShippersComponent } from './components/agregar-shippers/agregar-shippers.component';
import { EliminarShippersComponent } from './components/eliminar-shippers/eliminar-shippers.component';
import { ListadoShippersComponent } from './components/listado-shippers/listado-shippers.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  {
    path:'',
    component: HomeComponent
  },

  {
    path:'listado',
    component: ListadoShippersComponent
  },

  {
    path:'agregar',
    component: AgregarShippersComponent
  },

  {
    path:'editar/:id',
    component: AgregarShippersComponent
  },

  {
    path:'eliminar/:id',
    component: EliminarShippersComponent
  },

  {
    path:'**',
    redirectTo: 'listado'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
