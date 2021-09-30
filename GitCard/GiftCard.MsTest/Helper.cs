using GitCard.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GiftCard.MsTest
{
    public class Helper
    {
            public static bool CheckList(List<GiftPurchaseDetail> list1, List<GiftPurchaseDetail> list2)
            {
           
            if (list1.Count != list2.Count)
                {
                    return false;
                }
                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1[i].Id == list2[i].Id && list1[i].BuyerName == list2[i].BuyerName && list1[i].ShippingAddress == list2[i].ShippingAddress &&
                        list1[i].City == list2[i].City && list1[i].Amount == list2[i].Amount && list1[i].Phone == list2[i].Phone)
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }

        public static bool CheckObject(GiftPurchaseDetail giftCard1, GiftPurchaseDetail giftCard2)
        {
            Console.WriteLine(giftCard1.Id + " | " + giftCard2.Id);
            Console.WriteLine(giftCard1.BuyerName + " | " + giftCard2.BuyerName);
            Console.WriteLine(giftCard1.ShippingAddress + " | " + giftCard2.ShippingAddress);
            Console.WriteLine(giftCard1.City + " | " + giftCard2.City);
            Console.WriteLine(giftCard1.Amount + " | " + giftCard2.Amount);
            Console.WriteLine(giftCard1.Phone + " | " + giftCard2.Phone);

            if (giftCard1.Id == giftCard2.Id && giftCard1.BuyerName == giftCard2.BuyerName && giftCard1.ShippingAddress == giftCard2.ShippingAddress &&
                giftCard1.City == giftCard2.City && giftCard1.Amount == giftCard2.Amount && giftCard1.Phone == giftCard2.Phone)
            {
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }






    }
}
