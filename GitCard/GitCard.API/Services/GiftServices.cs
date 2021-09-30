using GitCard.API.Models;
using GitCard.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCard.API.Services
{
    public class GiftServices : IGiftServices
    {
        private readonly IGiftRepo _giftrepo;

        //GiftRepo _giftrepo = new GiftRepo();
        public GiftServices(IGiftRepo giftRepo)
        {
            _giftrepo = giftRepo;
        }
        public string AddEmp(GiftPurchaseDetail gift)
        {
            
            if (gift == null)
            {
                return "Gift card addition unsuccessfull";
            }
            _giftrepo.AddEmp(gift);
            return "Gift card added successfully";
        }

        public IEnumerable<GiftPurchaseDetail> GetAll()
        {
            return _giftrepo.GetAll();
        }
    }
}
