using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DataService.DataObjects;
using DataService.BSService.BSServiceInt;
using Microsoft.Practices.Unity;

namespace DesktopIHM.GuiPresenters
{
    class SalariePresenter : INotifyPropertyChanged
    {

        private ISalarieService salarieService = Program.myContainer.Resolve<ISalarieService>();

        private int idSalarie;

        public int IdSalarie
        {
            get { return idSalarie; }
            set
            {
                RaisePropertyChanged("IdSalarie");
                idSalarie = value;
            }
        }

        private string nom;

        public string Nom
        {
            get { return nom; }
            set
            {
                RaisePropertyChanged("Nom");
                nom = value;
            }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set
            {
                RaisePropertyChanged("Prenom");
                prenom = value;
            }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                RaisePropertyChanged("Email");
                email = value;
            }
        }
        private string motDePasse;

        public string MotDePasse
        {
            get { return motDePasse; }
            set
            {
                RaisePropertyChanged("motDePasse");
                motDePasse = value;
            }
        }
        private DateTime dateEmbauche;

        public DateTime DateEmbauche
        {
            get { return dateEmbauche; }
            set
            {
                RaisePropertyChanged("DateEmbauche");
                dateEmbauche = value;
            }
        }
        private string rechercheString;

        public string RechercheString
        {
            get { return rechercheString; }
            set
            {
                rechercheString = value;
                RaisePropertyChanged("RechercheString");
            }
        }
        private IList<string> rechercheSelectedItems;

        public IList<string> RechercheSelectedItems
        {
            get { return rechercheSelectedItems; }
            set
            {
                rechercheSelectedItems = value;
                RaisePropertyChanged("RechercheSelectedItems");
            }
        }

        private BindingList<Salarie> _allSalaries;
        public BindingList<Salarie> AllSalaries
        {
            get
            {
                return _allSalaries;
            }
            set
            {
                _allSalaries = value;
                RaisePropertyChanged("AllSalaries");
            }
        }

        public void AddNewSalarie()
        {
            this.getAllSalaries();
            if (_allSalaries == null)
            {
                _allSalaries = new BindingList<Salarie>();
            }
            Salarie salarie = new Salarie() {IdSalarie= _allSalaries.Count +1 , Nom = nom, Prenom = prenom, Email = email, MotDePasse = motDePasse, DateEmbauche = dateEmbauche };
            _allSalaries.Add(salarie);
            salarieService.Insert(salarie);
            RaisePropertyChanged("AllSalaries");
            ClearData();
        }

        public void RemoveSalarie()
        {
            if (_allSalaries == null || IdSalarie == 0)
            {
                return;
            }
            _allSalaries = new BindingList<Salarie>(_allSalaries.Where(x => x.IdSalarie != IdSalarie).ToList());
            ClearData();
            RaisePropertyChanged("AllSalaries");
        }
        public void UpdateSalarie()
        {
            this.getAllSalaries();
            if (_allSalaries == null || IdSalarie == 0)
            {
                return;
            }
            Salarie s = _allSalaries.Where(x => x.IdSalarie == IdSalarie).FirstOrDefault();
            s.Nom = this.Nom;
            s.Prenom = this.Prenom;
            s.Email = this.Email;
            s.MotDePasse = this.MotDePasse;
            s.DateEmbauche = this.DateEmbauche;
            s.IdSalarie = this.IdSalarie;
            _allSalaries = new BindingList<Salarie>(_allSalaries);
            salarieService.Update(s, "IdSalarie");
            RaisePropertyChanged("AllSalaries");
            ClearData();
        }
        public void getSalarie()
        {
            if (_allSalaries == null || IdSalarie == 0)
            {
                return;
            }
            Salarie s = _allSalaries.Where(x => x.IdSalarie == IdSalarie).FirstOrDefault();
            this.Nom = s.Nom;
            this.Prenom = s.Prenom;
            this.Email = s.Email;
            this.MotDePasse = s.MotDePasse;
            this.DateEmbauche = s.DateEmbauche;
            this.IdSalarie = s.IdSalarie;
        }

        public void getAllSalaries()
        {
            AllSalaries = new BindingList<Salarie>(salarieService.SelectAll());
        }
        public void Search()
        {
            var lst = salarieService.SelectAll();
            if (!string.IsNullOrEmpty(RechercheString))
            {
                foreach (var item in RechercheSelectedItems)
                {
                    switch (item)
                    {
                        case "Nom":
                            {
                                lst = lst.Where(x => x.Nom.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Prenom":
                            {
                                lst = lst.Where(x => x.Prenom.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Email":
                            {
                                lst = lst.Where(x => x.Email.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Date Embauche":
                            {
                                DateTime dt;
                                DateTime.TryParse(RechercheString, out dt);
                                lst = lst.Where(x => x.DateEmbauche == dt).ToList();
                                break;
                            }
                        default:
                            break;
                    }
                }
                if (RechercheSelectedItems.Count == 0)
                {
                    DateTime dt;
                    DateTime.TryParse(RechercheString, out dt);
                    lst = lst.Where(x => x.Nom.ToLower() == RechercheString.ToLower() || x.Prenom.ToLower() == RechercheString.ToLower() || x.DateEmbauche == dt || x.Email.ToLower() == RechercheString.ToLower()).ToList();
                }
            }
            AllSalaries = new BindingList<Salarie>(lst);
            RaisePropertyChanged("AllSalaries");
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void Save()
        {

        }
        private void ClearData()
        {
            this.IdSalarie = 0;
            this.Nom = "";
            this.Prenom = "";
            this.Email = "";
            this.MotDePasse = "";
            this.DateEmbauche = new DateTime();

        }
    }
}
