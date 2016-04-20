using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ObligatoriskOpg.Annotations;

namespace ObligatoriskOpg.ViewModel
{
    class GuestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public GuestSingleton gs { get; set; }
        public GuestViewModel()
        {
            gs = GuestSingleton.Instance;
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
