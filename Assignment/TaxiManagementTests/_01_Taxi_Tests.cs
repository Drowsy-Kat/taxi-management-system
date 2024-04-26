using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxiManagement;

namespace TaxiManagementTests
{
    [TestClass]
    public class _01_Taxi_Tests
    {
        /*
         * Uncomment from line 21
         */

        [TestMethod]
        public void _01_When_NewTaxi_Expect_NumberIsSet()
        {
            Taxi t = new Taxi(1);
            Assert.AreEqual(1, t.Number);
        }

        //[TestMethod]
        //public void _02_When_NewTaxi_Expect_CurrentFareIsZero()
        //{
        //    Taxi t = new Taxi(1);
        //    Assert.AreEqual(0, t.CurrentFare);
        //}

        //[TestMethod]
        //public void _03_When_NewTaxi_Expect_DestinationIsEmpty()
        //{
        //    Taxi t = new Taxi(1);
        //    Assert.AreEqual(0, t.Destination.Length);
        //}

        //[TestMethod]
        //public void _04_When_NewTaxi_Expect_LocationIsOnRoad()
        //{
        //    Taxi t = new Taxi(1);
        //    Assert.AreEqual("on the road", t.Location);
        //}

        //[TestMethod]
        //public void _05_When_NewTaxi_Expect_TotalMoneyPaidIsZero()
        //{
        //    Taxi t = new Taxi(1);
        //    Assert.AreEqual(0, t.TotalMoneyPaid);
        //}

        //[TestMethod]
        //public void _06_When_AddFare_Expect_AgreedPriceIsAddedToCurrentFare()
        //{
        //    Taxi t = new Taxi(1);
        //    t.AddFare("", 1.23);
        //    Assert.AreEqual(1.23, t.CurrentFare);
        //}

        //[TestMethod]
        //public void _07_When_AddFare_Expect_DestinationIsSet()
        //{
        //    Taxi t = new Taxi(1);
        //    t.AddFare("New destination", 0);
        //    Assert.AreEqual("New destination", t.Destination);
        //}

        //[TestMethod]
        //public void _08_When_AddFare_Expect_LocationIsChangedToOnRoad()
        //{
        //    Taxi t = new Taxi(1);
        //    t.AddFare("", 0);
        //    Assert.AreEqual("on the road", t.Location);
        //}

        //[TestMethod]
        //public void _09_When_DropFare_Expect_DestinationIsCleared()
        //{
        //    Taxi t = new Taxi(1);
        //    t.AddFare("New destination", 0);
        //    t.DropFare(true);
        //    Assert.AreEqual("", t.Destination);
        //}

        //[TestMethod]
        //public void _10_When_DropFare_Expect_CurrentFareSetToZero()
        //{
        //    Taxi t = new Taxi(1);
        //    t.AddFare("", 1.23);
        //    t.DropFare(true);
        //    Assert.AreEqual(0, t.CurrentFare);
        //}

        //[TestMethod]
        //public void _11_When_DropFare_Expect_LocationDoesNotChange()
        //{
        //    Taxi t = new Taxi(1);
        //    t.AddFare("Here and there", 1.23);
        //    t.DropFare(true);
        //    Assert.AreEqual(Taxi.ON_ROAD, t.Location);
        //}

        //[TestMethod]
        //public void _12_When_DropFareAndPriceWasPaidIsTrue_Expect_CurrentFareIsAddedToTotalMoneyTaken()
        //{
        //    Taxi t = new Taxi(1);
        //    t.AddFare("", 1.23);
        //    t.DropFare(true);
        //    Assert.AreEqual(1.23, t.TotalMoneyPaid);
        //}

        //[TestMethod]
        //public void _13_When_DropFareAndPriceWasPaidIsFalse_Expect_TotalMoneyTakenDoesNotChange()
        //{
        //    Taxi t = new Taxi(1);
        //    t.AddFare("", 1.23);
        //    t.DropFare(false);
        //    Assert.AreEqual(0, t.TotalMoneyPaid);
        //}
    }
}
