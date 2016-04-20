using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatoriskOpg.ViewModel;

namespace ObligatoriskOpg.Handler
{
    class GuestHandler
    {
        public static GuestViewModel GuestViewModels { get; set; }
        public static GuestSingleton GuestSingletons { get; set; }

        public GuestHandler(GuestViewModel guestViewModels)
        {
            GuestViewModels = guestViewModels;
        }

        public void GetGuest()
        {
            //GuestViewModels.
        }
    }
}
