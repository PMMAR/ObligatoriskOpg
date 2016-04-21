using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using ObligatoriskOpg.Facade;
using ObligatoriskOpg.Model;

namespace UnitTestFacadeGuest
{
    [TestClass]
    public class FacadeGuestUnitTest
    {

        [TestMethod]
        public void GetGuestTest()
        {
            //Arrange
            GuestFacade guestFacade = new GuestFacade();
            Guest guest = new Guest("Eva", 1, "Paradisvej 3, 1111 Bispeborg");


            //Act
           var guestAct = guestFacade.GetGuest(guest);

            //Assert
            Assert.IsNotNull(guestAct);
            //Assert.AreEqual();

        }
    }
}
