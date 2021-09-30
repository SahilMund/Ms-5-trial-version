import { Component, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { GiftOrderDetailsService } from 'src/app/services/gift-order-details.service';

@Component({
  selector: 'app-view-gift-card',
  templateUrl: './view-gift-card.component.html',
  styleUrls: ['./view-gift-card.component.css']
})
export class ViewGiftCardComponent implements OnInit {

  
  constructor(private service:GiftOrderDetailsService) {
    this.service.listen().subscribe((m:any)=>{
      this.getAllData();
    })
  }
  listData :any;

  ngOnInit(): void {
    this.getAllData()
  }

  
  getAllData(){
    this.service.getGiftList().subscribe(data=>{
      this.listData=data;
      console.log(data);
    })

}}
