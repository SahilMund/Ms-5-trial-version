using System;
using System.Collections.Generic;

#nullable disable

namespace GitCard.API.Models
{
    public partial class GiftPurchaseDetail
    {
        public int Id { get; set; }
        public string BuyerName { get; set; }
        public string ShippingAddress { get; set; }
        public string City { get; set; }
        public int Amount { get; set; }
        public long Phone { get; set; }
    }
}
