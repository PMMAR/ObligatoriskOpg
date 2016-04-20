using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatoriskOpg.Facade;
using ObligatoriskOpg.Model;
using ObligatoriskOpg.ViewModel;

namespace ObligatoriskOpg.Handler
{
    class GuestHandler
    {
        public static GuestViewModel GuestViewModels { get; set; }
        public static GuestSingleton GuestSingletons { get; set; }
        public static GuestFacade GuestFacades { get; set; }

        public string Name { get; set; }
        public int Guest_No { get; set; }
        public string Address { get; set; }


        public GuestHandler(GuestViewModel guestViewModels)
        {
            GuestViewModels = guestViewModels;
        }

        public void GetGuest()
        {
            var facade = new GuestFacade();
            facade.GetGuest();
        }

        public void PostGuest()
        {
            var facade = new GuestFacade();
            facade.PostGuest(new GuestClass(Name, Guest_No, Address));
        }

        public void UpdateGuest()
        {
            var facade = new GuestFacade();
            facade.GuestPut(new GuestClass(Name, Guest_No, Address));

        }


    }
}
