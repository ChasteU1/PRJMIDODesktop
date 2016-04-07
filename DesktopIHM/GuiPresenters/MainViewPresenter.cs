using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopIHM.GuiPresenters
{
    class MainViewPresenter : INotifyPropertyChanged
    {
        public VoiturePresenter VoiturePresenter { get; set; }
        public SalariePresenter SalariePresenter { get; set; }
        public ClientPresenter ClientPresenter { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
