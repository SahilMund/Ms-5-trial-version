using GitCard.API.Controllers;
using GitCard.API.Models;
using GitCard.API.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace GiftCard.MsTest
{
    [TestClass]
   public class GiftCardControllerTest
    {
        [TestMethod]
        //IEnumerable<GiftPurchaseDetail>
        public void GetAllTest()
        {
            Mock<IGiftServices> mockGet = new Mock<IGiftServices>();

            List<GiftPurchaseDetail> giftCardList = new List<GiftPurchaseDetail>();

            GiftPurchaseDetail giftCard = new GiftPurchaseDetail()
            {
                Id = 2,
                BuyerName = "Test Person",
                ShippingAddress = "XYZ Street, PQR City, __Country",
                City = "PQR City",
                Amount = 4000,
                Phone = 9876543211
            };

            giftCardList.Add(giftCard);
                
            mockGet.Setup(p => p.GetAll()).Returns(giftCardList);

            GiftCardContoller controller = new GiftCardContoller(mockGet.Object);

            List<GiftPurchaseDetail> output = (List<GiftPurchaseDetail>) controller.GetAllEmp();

            Console.WriteLine(output[0].BuyerName);
            Console.WriteLine(giftCardList[0].BuyerName);

            Assert.IsTrue(Helper.CheckList(output, giftCardList));

            //Assert.AreEqual(2, giftCard.Id);

        }

        [TestMethod]
        public void AddDataSuccess()
        {
            Mock<IGiftServices> mockPost = new Mock<IGiftServices>();
            GiftPurchaseDetail giftcarddata = new GiftPurchaseDetail()
            {
               
                BuyerName = "PQR",
                ShippingAddress = "XYZ Street, PQR City, __Country",
                City = "PQR City",
                Amount = 20000,
                Phone = 9876543211
            };

            string passOutput = "Gift card addeded successfully";

            mockPost.Setup(p => p.AddEmp(giftcarddata)).Returns(passOutput);

            GiftCardContoller controller = new GiftCardContoller(mockPost.Object);

            string output = controller.AddEmp(giftcarddata).ToString();

            Assert.AreEqual(passOutput, output);
        }

        [TestMethod]
        public void AdddataFailed()
        {
            Mock<IGiftServices> mockPost = new Mock<IGiftServices>();

            GiftPurchaseDetail giftCard = new GiftPurchaseDetail();
            string failOutput = "Gift card addition unsuccessfull";

            mockPost.Setup(p => p.AddEmp(giftCard)).Returns(failOutput);
         

            GiftCardContoller controller = new GiftCardContoller(mockPost.Object);

            string output = controller.AddEmp(giftCard).ToString();
          

         Assert.AreEqual(failOutput, output);
       
        }

    }
}
