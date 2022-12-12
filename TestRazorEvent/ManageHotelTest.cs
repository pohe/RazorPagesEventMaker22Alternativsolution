using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPagesEventMaker22.Interfaces;
using RazorPagesEventMaker22.Services;
using RazorPagesEventMaker22.Models;
using System.Collections.Generic;

namespace TestRazorEvent
{
    [TestClass]
    public class ManageHotelTest
    {
        [TestMethod]
        public void TestCreateHotel()
        {
            //Arrange
            IHotelRepository hotelRepository;
            hotelRepository = new HotelRepository();

            //Act
            List<Hotel> hotelsBefore = hotelRepository.GetAllHotels();
            int antalBefore = hotelsBefore.Count;
            hotelRepository.AddHotel(new Hotel());
            List<Hotel> hotelsAfter = hotelRepository.GetAllHotels();
            int antalAfter = hotelsAfter.Count;

            //Assert
            Assert.AreEqual(antalBefore + 1, antalAfter);
        }
    }
}