using GitCard.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCard.API.Services
{
    public  interface IGiftServices
    {
        IEnumerable<GiftPurchaseDetail> GetAll();
        string AddEmp(GiftPurchaseDetail gift);
    }
}
