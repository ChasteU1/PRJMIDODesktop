using DataService.BSService.BSServiceInt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace DesktopIHM.GuiPresenters
{
    class LoginFormPresenter : INotifyPropertyChanged 
    {
        private ISalarieService salarieService = Program.myContainer.Resolve<ISalarieService>();
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value;
            RaisePropertyChanged("Email");
            }
        }
        private string motDePasse;

        public string MotDePasse
        {
            get { return motDePasse; }
            set { motDePasse = value;
            RaisePropertyChanged("MotDePasse");
            }
        }

        private string erreurAuthentification;

        public string ErreurAuthentification
        {
            get { return erreurAuthentification; }
            set
            {
                erreurAuthentification = value;
            RaisePropertyChanged("ErreurAuthentification");
            }
        }

        public bool LogIn()
        {
            bool res = salarieService.Authentifier(email, motDePasse);
            if (!res)
            {
                this.ErreurAuthentification = "Erreur d'authentification: Le nom d'utilisateur et ou le mot de passe sont erronés";
            }
            return res;
        }

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
