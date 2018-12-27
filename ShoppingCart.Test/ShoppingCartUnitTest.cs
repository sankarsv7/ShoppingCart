using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;

namespace ShoppingCart.Test
{
    [TestClass]
    public class ShoppingCartUnitTest
    {
        int apple = 0;
        int orange = 0;
        int appleCountAfterOffer = 0;
        int orangecountAfterOffer = 0;
        decimal applePrice = 0.60m;
        decimal orangePrice = 0.25m;
        decimal totalAmount = 0;
        string[] fruitList;
        FruitsCount fruitsCount = new FruitsCount();
        Calculate calculate = new Calculate();
        Offer offer = new Offer();

        [TestMethod]
        public void Count_Number_Of_Fruits_By_Category_TestMethod()
        {
            fruitList = new string[] { "Orange", "apple", "orange", "apple", "orange" };
            fruitsCount.Fruits(fruitList, ref apple, ref orange);
            Assert.AreEqual(orange, 3);
            Assert.AreEqual(apple, 2);
        }
        [TestMethod]
        public void Exclude_Non_Organge_Apple_Fruits_TestMethod()
        {
            fruitList = new string[] { "orange", "orange", "apple", "banana", "manga", "xyz", "orange", "apple", "orange" };
            fruitsCount.Fruits(fruitList, ref apple, ref orange);
            Assert.AreEqual(orange, 4);
            Assert.AreEqual(apple, 2);
        }
        [TestMethod]
        public void Junk_Fruits_List_TestMethod()
        {
            fruitList = new string[] { "orange", " ", "", "banana", "manga", "AbCdE", "$$*&", "apple", "orange" };
            fruitsCount.Fruits(fruitList, ref apple, ref orange);
            Assert.AreEqual(orange, 2);
            Assert.AreEqual(apple, 1);
        }

        [TestMethod]
        public void Total_Cost_NonOffer_TestMethod()
        {
            fruitList = new string[] { "orange", "apple", "orange", "apple", "orange", "orange", "orange", "orange", "apple", "orange", "orange", "apple", "apple" };
            fruitsCount.Fruits(fruitList, ref apple, ref orange);
            totalAmount = calculate.CalculateTotal(apple, orange, applePrice, orangePrice);
            Assert.AreEqual(totalAmount, 5.00m);
        }
        [TestMethod]
        public void Total_Cost_Offer_TestMethod()
        {
            fruitList = new string[] { "orange", "apple", "orange", "apple", "orange", "orange", "orange", "orange", "apple", "orange", "orange", "apple", "apple" };
            fruitsCount.Fruits(fruitList, ref apple, ref orange);
            appleCountAfterOffer = offer.BuyOneGetOne(apple);
            orangecountAfterOffer = offer.ThreeForTwo(orange);
            totalAmount = calculate.CalculateTotal(appleCountAfterOffer, orangecountAfterOffer, applePrice, orangePrice);
            Assert.AreEqual(totalAmount, 3.30m);
        }
        [TestMethod]
        public void Junk_Fruits_Exclude_From_Total_Cost_Offer_TestMethod()
        {
            fruitList = new string[] { "orange", "   ", "897897", "%%£!&*£", "apple", "apple", "orange", "Orange", "Apple" };
            fruitsCount.Fruits(fruitList, ref apple, ref orange);
            appleCountAfterOffer = offer.BuyOneGetOne(apple);
            orangecountAfterOffer = offer.ThreeForTwo(orange);
            totalAmount = calculate.CalculateTotal(appleCountAfterOffer, orangecountAfterOffer, applePrice, orangePrice);
            Assert.AreEqual(totalAmount, 1.70m);
        }
        [TestMethod]
        public void Junk_Fruits_Exclude_From_Total_Cost_Non_Offer_TestMethod()
        {
            fruitList = new string[] { "orange", "   ", "897897", "%%£!&*£", "apple", "apple", "orange", "Orange", "Apple" };
            fruitsCount.Fruits(fruitList, ref apple, ref orange);
            totalAmount = calculate.CalculateTotal(apple, orange, applePrice, orangePrice);
            Assert.AreEqual(totalAmount, 2.55m);
        }
    }
}
