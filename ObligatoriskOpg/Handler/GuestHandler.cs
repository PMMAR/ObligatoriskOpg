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

        //public string Name { get; set; }
        //public int Guest_No { get; set; }
        //public string Address { get; set; }
        public GuestClass guest  { get; set; }

        public GuestHandler(GuestViewModel guestViewModels)
        {
            GuestViewModels = guestViewModels;
        }

        public void GetGuest()
        {
            var facade = new GuestFacade();
            facade.GetGuest(guest.Guest_No);
        }

        public void PostGuest()
        {
            var facade = new GuestFacade();
            facade.PostGuest(guest);
        }

        public void UpdateGuest()
        {
            var facade = new GuestFacade();
            facade.GuestPut(guest);
        }

        public void DeleteGuest()
        {
            var facade = new GuestFacade();
            facade.GuestDelete(guest);
        }


    }
}
