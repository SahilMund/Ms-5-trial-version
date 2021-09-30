import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { GiftOrderDetailsService } from 'src/app/services/gift-order-details.service';

@Component({
  selector: 'app-add-view-gift',
  templateUrl: './add-view-gift.component.html',
  styleUrls: ['./add-view-gift.component.css']
})
export class AddViewGiftComponent implements OnInit {

  constructor(public service:GiftOrderDetailsService) { }

  ngOnInit(): void {
  }


  resetForm(form?:NgForm){
    if(form!=null)
    form.resetForm();

    this.service.formData = {
      id:0,
      buyerName:'',
      shippingAddress : '',
      city : '',
      amount:0,
      phone:0
    }
  }


  
  onSubmit(form:NgForm){
    
    console.log(form.value);
    this.service.addGiftData(form.value).subscribe(res=>{
      this.resetForm(form);
      
      alert(form.value);
      
    });
  }
}
