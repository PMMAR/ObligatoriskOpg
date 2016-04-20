using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ObligatoriskOpg.Model;

namespace ObligatoriskOpg.ViewModel
{
    class GuestSingleton
    {
        public ObservableCollection<Guest> Guests { get; set; }
        private static GuestSingleton instance = new GuestSingleton();
        public int SelectedIndex  { get; set; }

        public GuestSingleton()
        {
            Guests = new ObservableCollection<Guest>();

        }   

        public static GuestSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void AddGuest(string name, int Guest_No, string address)
        {
            Guests.Add(new Guest(name, Guest_No, address));
        }
    }
}
