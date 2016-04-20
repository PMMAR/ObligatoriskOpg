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

        public Guest Guest  { get; set; }

        public GuestHandler(GuestViewModel guestViewModels)
        {
            GuestViewModels = guestViewModels;
        }

        public void GetGuest()
        {
            var facade = new GuestFacade();
            facade.GetGuest(Guest);
        }

        public void PostGuest()
        {
            var facade = new GuestFacade();
            facade.PostGuest(Guest);
        }

        public void UpdateGuest()
        {
            var facade = new GuestFacade();
            facade.GuestPut(Guest);
        }

        public void DeleteGuest()
        {
            var facade = new GuestFacade();
            facade.GuestDelete(Guest);
        }


    }
}
