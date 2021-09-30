using GitCard.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCard.API.Repository
{
    public interface IGiftRepo
    {
        IEnumerable<GiftPurchaseDetail> GetAll();
        void AddEmp(GiftPurchaseDetail gift);
        
    }
}
