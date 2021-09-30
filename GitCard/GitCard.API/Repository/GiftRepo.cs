using GitCard.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitCard.API.Repository
{
    public class GiftRepo : IGiftRepo
    {
        private readonly GiftCardDBContext _dbcontext;

        // GiftCardDBContext _dbcontxt = new GiftCardDBContext();
        public GiftRepo(GiftCardDBContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void AddEmp(GiftPurchaseDetail gift)
        {
            if (gift == null)
            {
                throw new ArgumentNullException(nameof(gift));
            }
            _dbcontext.GiftPurchaseDetails.Add(gift);
            _dbcontext.SaveChanges();
        }

        public IEnumerable<GiftPurchaseDetail> GetAll()
        {
            return _dbcontext.GiftPurchaseDetails.ToList();
        }
    }
}
