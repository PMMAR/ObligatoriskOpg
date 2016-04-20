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
    public class GuestHandler
    {
        public static GuestViewModel GuestViewModels { get; set; }
        public static GuestSingleton GuestSingletons { get; set; }
        public static GuestFacade GuestFacades { get; set; }

        public Guest Guest  { get; set; }

        public GuestHandler(GuestViewModel guestViewModels)
        {
            GuestViewModels = guestViewModels;
        }

        public async void GetGuestList()
        {
            var facade = new GuestFacade();
            await facade.GetGuestList();

        }

        public async void GetGuest()
        {
            var facade = new GuestFacade();
            await facade.GetGuest(Guest);
        }

        public async void PostGuest()
        {
            var facade = new GuestFacade();
            await facade.PostGuest(Guest);
        }

        public async void UpdateGuest()
        {
            var facade = new GuestFacade();
            await facade.GuestPut(Guest);
        }

        public async void DeleteGuest()
        {
            var facade = new GuestFacade();
            await facade.GuestDelete(Guest);
        }


    }
}
