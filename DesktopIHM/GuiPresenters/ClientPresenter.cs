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
    class ClientPresenter : INotifyPropertyChanged
    {
        private IClientService clientService = Program.myContainer.Resolve<IClientService>();

        private int idClient;

        public int IdClient
        {
            get { return idClient; }
            set
            {
                idClient = value;
                RaisePropertyChanged("IdClient");
            }
        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
                RaisePropertyChanged("Nom");
            }
        }
        private string prenom;

        public string Prenom
        {
            get { return prenom; }
            set
            {
                prenom = value;
                RaisePropertyChanged("Prenom");
            }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChanged("Email");
            }
        }
        private string nomSociete;

        public string NomSociete
        {
            get { return nomSociete; }
            set
            {
                nomSociete = value;
                RaisePropertyChanged("NomSociete");
            }
        }
        private string codeIban;

        public string CodeIban
        {
            get { return codeIban; }
            set
            {
                codeIban = value;
                RaisePropertyChanged("CodeIban");
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

        private BindingList<Client> _allClients;
        public BindingList<Client> AllClients
        {
            get
            {
                return _allClients;
            }
            set
            {
                _allClients = value;
                RaisePropertyChanged("AllClients");
            }
        }

        public void AddNewClient()
        {
            this.getAllClient();
            if (_allClients == null)
            {
                _allClients = new BindingList<Client>();
            }
            Client client = new Client() { IdClient = _allClients.Count + 1, Nom = nom, Prenom = prenom, Email = email, NomSociete = nomSociete, CodeIban = codeIban };
            _allClients.Add(client);
            clientService.Insert(client);
            RaisePropertyChanged("AllClients");
            ClearData();
        }

        public void RemoveClient()
        {
            if (_allClients == null || IdClient == 0)
            {
                return;
            }
            _allClients = new BindingList<Client>(_allClients.Where(x => x.IdClient != idClient).ToList());
            ClearData();
            RaisePropertyChanged("AllClients");
        }
        public void UpdateClient()
        {
            this.getAllClient();
            if (_allClients == null || IdClient == 0)
            {
                return;
            }
            Client c = _allClients.Where(x => x.IdClient == idClient).FirstOrDefault();
            c.Nom = this.Nom;
            c.Prenom = this.Prenom;
            c.Email = this.Email;
            c.CodeIban = this.CodeIban;
            c.NomSociete = this.NomSociete;
            _allClients = new BindingList<Client>(_allClients);
            clientService.Update(c,"IdClient");
            RaisePropertyChanged("AllClients");
            ClearData();
        }
        public void getClient()
        {
            if (_allClients == null || IdClient == 0)
            {
                return;
            }
            Client c = _allClients.Where(x => x.IdClient == idClient).FirstOrDefault();
            this.Nom = c.Nom;
            this.Prenom = c.Prenom;
            this.Email = c.Email;
            this.CodeIban = c.CodeIban;
            this.NomSociete = c.NomSociete;
        }

        public void getAllClient()
        {
            AllClients = new BindingList<Client>(clientService.SelectAll());
        }
        public void Search()
        {
            var lst = clientService.SelectAll();
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
                        case "Société":
                            {
                                lst = lst.Where(x => x.NomSociete.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Email":
                            {
                                lst = lst.Where(x => x.Email.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        default:
                            break;
                    }
                }
                if (RechercheSelectedItems.Count == 0)
                {
                    lst = lst.Where(x => x.Nom.ToLower() == RechercheString.ToLower() || x.Prenom.ToLower() == RechercheString.ToLower() || x.NomSociete.ToLower() == RechercheString.ToLower() || x.Email.ToLower() == RechercheString.ToLower()).ToList();
                }
            }
            AllClients = new BindingList<Client>(lst);
            RaisePropertyChanged("AllClients");
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
            this.Nom = "";
            this.Prenom = "";
            this.Email = "";
            this.CodeIban = "";
            this.NomSociete = "";
            this.IdClient = 0;
        }
    }
}
