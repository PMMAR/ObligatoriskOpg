using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ObligatoriskOpg.Annotations;
using ObligatoriskOpg.Common;
using ObligatoriskOpg.Handler;
using ObligatoriskOpg.Model;

namespace ObligatoriskOpg.ViewModel
{
    public class GuestViewModel : INotifyPropertyChanged
    {
        private int _guestId;
        private string _navn;
        private string _address;
        public Handler.GuestHandler GuestHandler { get; set; }

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
            GuestHandler = new Handler.GuestHandler(this);
            gs = GuestSingleton.Instance;
            AddGuestCommand = new RelayCommand(GuestHandler.PostGuest);
            GetGuestCommand = new RelayCommand(GuestHandler.GetGuest);
            UpdateGuestCommand = new RelayCommand(GuestHandler.UpdateGuest);
            DeleteGuestCommand = new RelayCommand(GuestHandler.DeleteGuest);
        }



        


        #region Property Options
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
