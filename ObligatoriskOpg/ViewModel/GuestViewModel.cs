using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ObligatoriskOpg.Annotations;
using ObligatoriskOpg.Common;
using ObligatoriskOpg.Handler;

namespace ObligatoriskOpg.ViewModel
{
    class GuestViewModel : INotifyPropertyChanged
    {
        private int _guestId;
        private string _navn;
        private string _address;
        public ICommand AddGuestCommand { get; set; }
        public ICommand GetGuestCommand { get; set; }
        public ICommand UpdateGuestCommand { get; set; }
        public ICommand DeleteGuestCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public GuestSingleton gs { get; set; }

        public int Guest_Id
        {
            get { return _guestId; }
            set { _guestId = value; OnPropertyChanged();}
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; OnPropertyChanged();}
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged(); }
        }

        public GuestViewModel()
        {
            gs = GuestSingleton.Instance;
            //GetGuest = new RelayCommand();
            //AddGuestCommand = new RelayCommand();
            //GetGuestCommand = new RelayCommand();
            //UpdateGuestCommand = new RelayCommand();
            //DeleteGuestCommand = new RelayCommand();
        }



        #region MyRegion
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
