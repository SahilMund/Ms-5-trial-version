using GitCard.API.Models;
using GitCard.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCard.API.Controllers
{
    [Route("GiftCard")]
    [ApiController]
    public class GiftCardContoller : ControllerBase
    {
        
        private readonly IGiftServices _giftservice;
        public GiftCardContoller(IGiftServices giftservice)
        {
            _giftservice = giftservice;
        }
        [HttpGet]
        public IEnumerable<GiftPurchaseDetail> GetAllEmp()
        {
            var gift = _giftservice.GetAll();
            if (gift == null)
            {
                return null;
            }
            return gift;
        }

        [HttpPost]
        public string AddEmp(GiftPurchaseDetail gift)
        {
            if (gift == null)
            {
                throw new ArgumentNullException(nameof(gift));
            }
          var msg =  _giftservice.AddEmp(gift);

            return msg;

           
        }

    }
}
