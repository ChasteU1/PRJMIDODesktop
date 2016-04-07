using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using DataService.DataObjects;
using DataService.BSService.BSServiceInt;
using Microsoft.Practices.Unity;
using System.Drawing;

namespace DesktopIHM.GuiPresenters
{
    class VoiturePresenter : INotifyPropertyChanged
    {
        private IVoitureService voitureService = Program.myContainer.Resolve<IVoitureService>();
        readonly string PicReb = "Images\\";
        private string immatriculation;

        public string Immatriculation
        {
            get { return immatriculation; }
            set
            {
                immatriculation = value;
                RaisePropertyChanged("Immatriculation");
            }
        }
        private string marque;

        public string Marque
        {
            get { return marque; }
            set
            {
                marque = value;
                RaisePropertyChanged("Marque");
            }
        }
        private string modele;

        public string Modele
        {
            get { return modele; }
            set
            {
                modele = value;
                RaisePropertyChanged("Modele");
            }
        }
        private int kilometrage;

        public int Kilometrage
        {
            get { return kilometrage; }
            set
            {
                kilometrage = value;
                RaisePropertyChanged("Kilometrage");
            }
        }
        private string couleur;

        public string Couleur
        {
            get { return couleur; }
            set
            {
                couleur = value;
                RaisePropertyChanged("Couleur");
            }
        }
        private string carburant;

        public string Carburant
        {
            get { return carburant; }
            set
            {
                carburant = value;
                RaisePropertyChanged("Carburant");
            }
        }
        private string photo;

        public string Photo
        {
            get { return photo; }
            set
            {
                photo = value;
                RaisePropertyChanged("Photo");
            }
        }
        private DateTime dateFutureCT;

        public DateTime DateFutureCT 
        {
            get { return dateFutureCT; }
            set
            {
                dateFutureCT = value;
                RaisePropertyChanged("DateFutureCT");
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

        private Image img;

        public Image Img
        {
            get { return img; }
            set
            {
                img = value;
                RaisePropertyChanged("Img");
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
        private BindingList<Voiture> _allAlertedVoitures;
        public BindingList<Voiture> AllAlertedVoitures
        {
            get
            {
                return _allAlertedVoitures;
            }
            set
            {
                _allAlertedVoitures = value;
                RaisePropertyChanged("AllAlertedVoitures");
            }
        }

        public void AddNewVoiture()
        {
            if (_allVoitures == null)
            {
                _allVoitures = new BindingList<Voiture>();
            }

            Voiture voiture = new Voiture()
            {
                Immatriculation = Immatriculation,
                Carburant = Carburant,
                Couleur = Couleur,
                DateFutureCT = DateFutureCT,
                Kilometrage = Kilometrage,
                Marque = Marque,
                Modele = Modele
            };
            voiture.Photo = this.Photo.Split('.')[0] + "_" + this.Immatriculation + "." + this.Photo.Split('.')[1];
            Img.Save(this.PicReb + voiture.Photo);
            _allVoitures.Add(voiture);
            voitureService.Insert(voiture);
            RaisePropertyChanged("AllVoitures");
            ClearData();
        }


        public void RemoveVoiture()
        {
            if (_allVoitures == null || string.IsNullOrEmpty(Immatriculation))
            {
                return;
            }
            _allVoitures = new BindingList<Voiture>(_allVoitures.Where(x => x.Immatriculation != Immatriculation).ToList());
            ClearData();
            RaisePropertyChanged("AllVoitures");
        }
        public void UpdateVoiture()
        {
            this.getAllVoiture();
            if (_allVoitures == null || string.IsNullOrEmpty(Immatriculation))
            {
                return;
            }
            Voiture v = _allVoitures.Where(x => x.Immatriculation == immatriculation).FirstOrDefault();
            v.Carburant = this.Carburant;
            v.Couleur = this.Couleur;
            v.DateFutureCT = this.DateFutureCT;
            v.Immatriculation = this.Immatriculation;
            v.Kilometrage = this.Kilometrage;
            v.Marque = this.Marque;
            v.Modele = this.Modele;
            v.Photo = this.Photo = this.Photo.Split('.')[0] + "_" + this.Immatriculation + "." + this.Photo.Split('.')[1];
            Img.Save(this.PicReb + v.Photo);
            _allVoitures = new BindingList<Voiture>(_allVoitures);
            voitureService.Update(v, "Immatriculation");
            RaisePropertyChanged("AllVoitures");
            ClearData();
        }
        public void getVoiture()
        {
            if (_allVoitures == null || string.IsNullOrEmpty(Immatriculation))
            {
                return;
            }
            Voiture v = _allVoitures.Where(x => x.Immatriculation == Immatriculation).FirstOrDefault();
            this.Carburant = v.Carburant;
            this.Couleur = v.Couleur;
            this.DateFutureCT = v.DateFutureCT;
            this.Immatriculation = v.Immatriculation;
            this.Kilometrage = v.Kilometrage;
            this.Marque = v.Marque;
            this.Modele = v.Modele;
            this.Photo = v.Photo;
            this.Img = Image.FromFile(this.PicReb + this.Photo);
        }

        public void getAllVoiture()
        {
            AllVoitures = new BindingList<Voiture>(voitureService.SelectAll());
        }
        public void Search()
        {
            var lst = voitureService.SelectAll();
            if (!string.IsNullOrEmpty(RechercheString))
            {
                foreach (var item in RechercheSelectedItems)
                {
                    switch (item)
                    {
                        case "Immatriculation":
                            {
                                lst = lst.Where(x => x.Immatriculation.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Marque":
                            {
                                lst = lst.Where(x => x.Marque.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Modèle":
                            {
                                lst = lst.Where(x => x.Modele.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        case "Carburant":
                            {
                                lst = lst.Where(x => x.Carburant.ToLower() == RechercheString.ToLower()).ToList();
                                break;
                            }
                        default:
                            break;
                    }
                }
                if (RechercheSelectedItems.Count == 0)
                {
                    lst = lst.Where(x => x.Immatriculation.ToLower() == RechercheString.ToLower() || x.Marque.ToLower() == RechercheString.ToLower() || x.Modele.ToLower() == RechercheString.ToLower() || x.Carburant.ToLower() == RechercheString.ToLower()).ToList();
                }
            }
            AllVoitures = new BindingList<Voiture>(lst);
            RaisePropertyChanged("AllVoitures");
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void getAllAlertedVoiture()
        {
            AllAlertedVoitures = new BindingList<Voiture>(voitureService.SelectAll().Where(x => x.DateFutureCT <= DateTime.Now.AddDays(60)).ToList());
        }
        public void Save()
        {

        }
        private void ClearData()
        {
            this.Immatriculation = "";
            this.Kilometrage = 0;
            this.Marque = "";
            this.Modele = "";
            this.Photo = "";
            this.Couleur = "";
            this.Carburant = "";
            this.DateFutureCT = new DateTime();
            this.Img = null;
        }
    }
}
