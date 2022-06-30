import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import { Shippers } from '../interface/IShippers';
@Injectable({
  providedIn: 'root'
})
export class ShippersServicesService {

  readonly urlBase = 'https://localhost:44347/api/shippers'

  constructor(private http: HttpClient) { }

  getShippers():Observable<Shippers[]>{
    return this.http.get<Shippers[]>(this.urlBase)
  }

  postShippers(shipper: Shippers):Observable<Shippers>{
    return this.http.post<Shippers>(this.urlBase,shipper)
  }

  deleteShippers(id:Number):Observable<Shippers> {
    return this.http.delete<Shippers>(this.urlBase+'/'+id)
  }


  }


  

