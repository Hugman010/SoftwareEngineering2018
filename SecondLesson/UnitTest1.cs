using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace carRent
{
    [TestClass]
    public class carRentTests
    {

        [TestMethod]
        public void addCountOfRents_CountPlusOne()
        {
            car newCar = new car();
            newCar.totalCountOfRents = 1;
            int expected = 2;

            car.addCountOfRents(newCar);

            Assert.AreEqual(expected, newCar.totalCountOfRents);
        }

        [TestMethod]
        public void checkСheckupNeed_CountEqual10()
        {
            car newCar = new car();
            newCar.totalCountOfRents = 10;
            int expected = 0;

            car.checkСheckupNeed(newCar);

            Assert.AreEqual(expected, newCar.totalCountOfRents);
        }

        [TestMethod]
        public void checkСheckupNeed_CountEqualCurrentCount()
        {
            car newCar = new car();
            newCar.totalCountOfRents = 8;
            int expected = 8;

            car.checkСheckupNeed(newCar);

            Assert.AreEqual(expected, newCar.totalCountOfRents);
        }

        [TestMethod]
        public void sendCarToCheckup_availabilityDatePlus7Days()
        {
            car newCar = new car();

            newCar.availabilityDate = new DateTime(2018, 1, 1);
            DateTime expected = new DateTime(2018,1,8);

            car.sendCarToCheckup(newCar);

            Assert.AreEqual(expected, newCar.availabilityDate);
        }

        [TestMethod]
        public void checkAvailableStatus_AvailableStatusTrue()
        {
            car newCar = new car();
            newCar.availabilityDate = new DateTime(2018, 1, 1);
            DateTime expectedDate = new DateTime(2019, 1, 1);

            bool expected = true;
            bool result = car.checkAvailableStatus(newCar, expectedDate);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void checkAvailableStatus_AvailableStatusFalse()
        {
            car newCar = new car();
            newCar.availabilityDate = new DateTime(2020, 1, 1);
            DateTime expectedDate = new DateTime(2019, 1, 1);

            bool expected = false;
            bool result = car.checkAvailableStatus(newCar, expectedDate);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void checkRentStatus_RentStatusTrue()
        {
            rent newRent = new rent();
            newRent.endRent = new DateTime(2019, 1, 1);
            DateTime expectedDate = new DateTime(2020, 1, 1);

            bool expected = true;
            bool result = rent.checkRentStatus(newRent, expectedDate);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void checkRentStatus_RentStatusFalse()
        {
            rent newRent = new rent();
            newRent.endRent = new DateTime(2020, 1, 1);
            DateTime expectedDate = new DateTime(2019, 1, 1);

            bool expected = false;
            bool result = rent.checkRentStatus(newRent, expectedDate);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void checkAvailibleStatusToNextRent_RentStatusTrue()
        {
            rent Rent1 = new rent();
            rent Rent2 = new rent();
            Rent1.endRent = new DateTime(2018, 1, 1);
            Rent2.startRent = new DateTime(2018, 1, 2);

            bool expected = true;
            bool result = rent.availibleStatusToNextRent(Rent1, Rent2);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void checkAvailibleStatusToNextRent_RentStatusFalse()
        {
            rent Rent1 = new rent();
            rent Rent2 = new rent();
            Rent1.endRent = new DateTime(2018, 1, 1);
            Rent2.startRent = new DateTime(2017, 1, 1);

            bool expected = false;
            bool result = rent.availibleStatusToNextRent(Rent1, Rent2);

            Assert.AreEqual(expected, result);
        }
    }
}
