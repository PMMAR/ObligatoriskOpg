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

namespace ObligatoriskOpg.ViewModel
{
    class GuestViewModel : INotifyPropertyChanged
    {
        public ICommand GetGuest { get; set; }  
        public event PropertyChangedEventHandler PropertyChanged;
        public GuestSingleton gs { get; set; }
        public GuestViewModel()
        {
            gs = GuestSingleton.Instance;
            //GetGuest = new RelayCommand();
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
