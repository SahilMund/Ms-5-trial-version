import { Injectable } from '@angular/core';


import {HttpClient} from '@angular/common/http';
import { BehaviorSubject, Observable, Subject } from 'rxjs';

import { GiftCard } from '../models/gift-card';

@Injectable({
  providedIn: 'root'
})
export class GiftOrderDetailsService {

  
  formData:GiftCard ={
    id:0,
    buyerName:'',
    shippingAddress : '',
    city : '',
    amount:0,
    phone:0
  };
  

  constructor(private http:HttpClient) { }

  
  readonly APIurL = "https://localhost:44316";
  
  // private dataSource = new BehaviorSubject({});
  // currmsg = this.dataSource.asObservable();

  // dataChange(emp:GiftCard){
  //   this.dataSource.next(emp);
  // }
  
  getGiftList() :Observable<any>{
    return this.http.get< any>(this.APIurL + '/GiftCard');
  }

  addGiftData(gift:GiftCard){
    return this.http.post(this.APIurL+'/GiftCard',gift);
  }


  private _listeners = new Subject<any>();
  listen():Observable<any>{
    return this._listeners.asObservable();
  }
  filter(filterBy:string){
    this._listeners.next(filterBy);
  }
}

// 





