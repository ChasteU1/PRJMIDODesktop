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
    class ContratPresenter : INotifyPropertyChanged
    {
        private IContratService contratService = Program.myContainer.Resolve<IContratService>();
        private IVoitureService voitureService = Program.myContainer.Resolve<IVoitureService>();
        private IClientService clientService = Program.myContainer.Resolve<IClientService>();

        private int numContrat;

        public int NumContrat
        {
            get { return numContrat; }
            set {
                numContrat = value;
                RaisePropertyChanged("NumContrat");
            }
        }
        private DateTime dateDebutContrat;

        public DateTime DateDebutContrat
        {
            get { return dateDebutContrat; }
            set {
                dateDebutContrat = value;
                RaisePropertyChanged("DateDebutContrat");
            }
        }
        private DateTime dateFinContrat;

        public DateTime DateFinContrat
        {
            get { return dateFinContrat; }
            set { 
                dateFinContrat = value;
                RaisePropertyChanged("DateFinContrat");
            }
        }
        private float tarifContrat;

        public float TarifContrat
        {
            get { return tarifContrat; }
            set {
                tarifContrat = value;
                RaisePropertyChanged("TarifContrat");
            }
        }
        private DateTime? dateRetourContrat;

        public DateTime ? DateRetourContrat
        {
            get { return dateRetourContrat; }
            set {
                dateRetourContrat = value;
                RaisePropertyChanged("DateRetourContrat");
            }
        }

       
        private string immatriculationVoitureContrat;

        public string ImmatriculationVoitureContrat
        {
            get { return immatriculationVoitureContrat; }
            set {
                immatriculationVoitureContrat = value;
                RaisePropertyChanged("ImmatriculationVoitureContrat");
            }
        }

        private string marqueVoitureContrat;

        public string MarqueVoitureContrat
        {
            get { return marqueVoitureContrat; }
            set {
                marqueVoitureContrat = value;
                RaisePropertyChanged("MarqueVoitureContrat");
            }
        }


        private string modeleVoitureContrat;

        public string ModeleVoitureContrat
        {
            get { return modeleVoitureContrat; }
            set {
                modeleVoitureContrat = value;
                RaisePropertyChanged("ModeleVoitureContrat");
            }
        }


        private int kilometrageVoitureContrat;

        public int KilometrageVoitureContrat
        {
            get { return kilometrageVoitureContrat; }
            set { 
                kilometrageVoitureContrat = value;
                RaisePropertyChanged("KilometrageVoitureContrat");
            }
        }

        private string couleurVoitureContrat;

        public string CouleurVoitureContrat
        {
            get { return couleurVoitureContrat; }
            set { 
                couleurVoitureContrat = value;
                RaisePropertyChanged("CouleurVoitureContrat");
            }
        }


        private string carburantVoitureContrat;

        public string CarburantVoitureContrat
        {
            get { return carburantVoitureContrat; }
            set {
                carburantVoitureContrat = value;
                RaisePropertyChanged("CarburantVoitureContrat");
            }
        }
        private string dateFuturCtContratVoitre;

        public string DateFuturCtContratVoitre
        {
            get { return dateFuturCtContratVoitre; }
            set {
                dateFuturCtContratVoitre = value;
                RaisePropertyChanged("DateFuturCtContratVoitre");
            }
        }
       

        private int idClientContrat;

        public int IdClientContrat
        {
            get { return idClientContrat; }
            set
            {
                idClientContrat = value;
                RaisePropertyChanged("IdClientContrat");
            }
        }
        private string nomContrat;

        public string NomContrat
        {
            get { return nomContrat; }
            set
            {
                nomContrat = value;
                RaisePropertyChanged("NomContrat");
            }
        }
        private string prenomContrat;

        public string PrenomContrat
        {
            get { return prenomContrat; }
            set
            {
                prenomContrat = value;
                RaisePropertyChanged("PrenomContrat");
            }
        }
        private string emailContrat;

        public string EmailContrat
        {
            get { return emailContrat; }
            set { 
                emailContrat = value;
                RaisePropertyChanged("EmailContrat");
            }
        }


        private string nomSocieteContrat;

        public string NomSocieteContrat
        {
            get { return nomSocieteContrat; }
            set { 
                nomSocieteContrat = value;
                RaisePropertyChanged("NomSocieteContrat");
            }
        }

        private string codeIbanContrat;

        public string CodeIbanContrat
        {
            get { return codeIbanContrat; }
            set {
                codeIbanContrat = value;
                RaisePropertyChanged("CodeIbanContrat");
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

        private bool _isReturned;

        public bool IsReturned
        {
            get { return _isReturned; }
            set {
                _isReturned = value;
                RaisePropertyChanged("IsReturned");
            }
        }

        private BindingList<Contrat> _allContrats;
        public BindingList<Contrat> AllContrats
        {
            get
            {
                return _allContrats;
            }
            set
            {
                _allContrats = value;
                RaisePropertyChanged("AllContrats");
            }
        }
        private BindingList<Contrat> _contractByClient;

        public BindingList<Contrat> ContractByClient
        {
            get { return _contractByClient; }
            set { 
                _contractByClient = value;
                RaisePropertyChanged("ContractByClient");
            }
        }

        private BindingList<Voiture> _allVoitures;
        public BindingList<Voiture> AllVoitures
        {
            get
            {
                return _allVoitures;
            }
            set
            {
                _allVoitures = value;
                RaisePropertyChanged("AllVoitures");
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

        private BindingList<Contrat> _allAlertedContrats;
        public BindingList<Contrat> AllAlertedContrats
        {
            get
            {
                return _allAlertedContrats;
            }
            set
            {
                _allAlertedContrats = value;
                RaisePropertyChanged("AllAlertedContrats");
            }
        }

        public void AddNewContract()
        {
            if (_allContrats == null)
            {
                _allContrats = new BindingList<Contrat>();
            }
            Contrat contrat = new Contrat() {  IdClient = IdClientContrat, NumContrat = _allContrats.Count+1, Immatriculation = immatriculationVoitureContrat, DateDebut = dateDebutContrat, DateFin = DateFinContrat , Tarif = TarifContrat};
            _allContrats.Add(contrat);
            contratService.Insert(contrat);
            RaisePropertyChanged("AllContrats");
            ClearData();
        }

        public void RemoveContrat()
        {
            if (_allContrats == null || NumContrat == 0)
            {
                return;
            }
            _allContrats = new BindingList<Contrat>(_allContrats.Where(x => x.NumContrat != NumContrat).ToList());
            ClearData();
            RaisePropertyChanged("AllContrats");
        }
        public void UpdateContrat()
        {
            if (_allContrats == null || NumContrat == 0)
            {
                return;
            }
            Contrat c = _allContrats.Where(x => x.NumContrat == NumContrat).FirstOrDefault();
            c.NumContrat = this.NumContrat;
            c.IdClient = this.IdClientContrat;
            c.Immatriculation = this.ImmatriculationVoitureContrat;
            c.DateDebut = this.DateDebutContrat ;
            c.DateFin = this.dateFinContrat;
            c.Tarif = this.TarifContrat;
            c.DateRetour = IsReturned ? this.DateRetourContrat.Value :(DateTime?) null;
            _allContrats = new BindingList<Contrat>(_allContrats);
            contratService.Update(c, "NumContrat");
            RaisePropertyChanged("AllContrats");
            ClearData();
        }
        public void getContrat()
        {
            if (_allContrats == null || NumContrat == 0)
            {
                return;
            }
            Contrat c = contratService.getFullContratData().Where(x => x.NumContrat == NumContrat).FirstOrDefault();
            this.NumContrat = c.NumContrat;
            this.IdClientContrat = c.IdClient;
            this.ImmatriculationVoitureContrat = c.Immatriculation;
            this.DateDebutContrat = c.DateDebut;
            this.dateFinContrat = c.DateFin;
            this.TarifContrat = c.Tarif;
            this.DateRetourContrat = c.DateRetour;
            this.IsReturned = c.DateRetour.HasValue;
            this.NomContrat = c.Client.Nom;
            this.PrenomContrat = c.Client.Prenom;
            this.EmailContrat = c.Client.Email;
            this.NomSocieteContrat = c.Client.NomSociete;
            this.CodeIbanContrat = c.Client.CodeIban;
            this.ModeleVoitureContrat = c.Voiture.Modele;
            this.MarqueVoitureContrat = c.Voiture.Marque;
            this.KilometrageVoitureContrat = c.Voiture.Kilometrage;
            this.DateFuturCtContratVoitre = c.Voiture.DateFutureCT.ToShortDateString() ;
            this.CarburantVoitureContrat = c.Voiture.Carburant;
            this.CouleurVoitureContrat = c.Voiture.Couleur;
            }

        public void getContractByClient()
        {
            ContractByClient = new BindingList<Contrat>(contratService.SelectAll().Where(x => x.IdClient == IdClientContrat).ToList());
        }

        public void getAllContrat()
        {
            AllContrats = new BindingList<Contrat>(contratService.SelectAll());
            AllClients = new BindingList<Client>(clientService.SelectAll());
            AllVoitures = new BindingList<Voiture>(voitureService.SelectAll());
            AllClients.Insert(0, new Client { IdClient = 0, Nom = "", Prenom = "" }); //empty row for the inti combo
            AllVoitures.Insert(0, new Voiture { Immatriculation = "0", Marque=""}); //empty row for the inti combo
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

        public void Search()
        {
            var lst = contratService.getFullContratData();
            if (!string.IsNullOrEmpty(RechercheString))
            {
                foreach (var item in RechercheSelectedItems)
                {
                    switch (item)
                    {
                        case "Nom client":
                            {
                                lst = lst.Where(x => x.Client.Nom.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Prenom client":
                            {
                                lst = lst.Where(x => x.Client.Prenom.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Immatriculation voiture":
                            {
                                lst = lst.Where(x => x.Immatriculation.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Marque voiture":
                            {
                                lst = lst.Where(x => x.Voiture.Marque.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        default:
                            break;
                    }
                }
                if (RechercheSelectedItems.Count == 0)
                {
                    lst = lst.Where(x => x.Immatriculation.ToLower() == RechercheString.ToLower() || x.Voiture.Marque.ToLower() == RechercheString.ToLower() || x.Client.Nom.ToLower() == RechercheString.ToLower() || x.Client.Prenom.ToLower() == RechercheString.ToLower()).ToList();
                }
            }
            AllContrats = new BindingList<Contrat>(lst);
            RaisePropertyChanged("AllContrats");
        }

       public void getAllAlertedContrat()
        {
            AllAlertedContrats = new BindingList<Contrat>(contratService.getFullContratData().Where(x => x.DateRetour== null && x.DateFin<=DateTime.Now).ToList());
        }
        private void ClearData()
        {
            this.NumContrat = 0;
            this.IdClientContrat = 0;
            this.ImmatriculationVoitureContrat = "";
            this.DateDebutContrat = new DateTime();
            this.DateFinContrat = new DateTime();
            this.TarifContrat = 0f;
            this.DateRetourContrat = new DateTime();
            this.IsReturned = false;
            this.NomContrat = "";
            this.PrenomContrat = "";
            this.EmailContrat = "";
            this.NomSocieteContrat = "";
            this.CodeIbanContrat = "";
            this.ModeleVoitureContrat = "";
            this.MarqueVoitureContrat = "";
            this.CarburantVoitureContrat = "";
            this.CouleurVoitureContrat = "";
            this.KilometrageVoitureContrat = 0;
        
        }
    }
}
