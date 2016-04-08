using DataService.BSService.BSServiceInt;
using DataService.DAOService;
using DataService.DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using DesktopIHM.GuiPresenters;
using System.Threading;

namespace GuiObjects.DesktopIHM
{
    public partial class MainView : Form
    {
        public MainView()
        {

            InitializeComponent();
            _clientPresenter = new ClientPresenter();
            _contratPresenter = new ContratPresenter();
            _voiturePresenter = new VoiturePresenter();
            _salariePresenter = new SalariePresenter();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            //base.OnLoad(e);
            /// Data binding pour la vue "Clients"
            rechercheClientText.DataBindings.Add("Text", _clientPresenter, "RechercheString");
            nomClientText.DataBindings.Add("Text", _clientPresenter, "Nom");
            prenomClientText.DataBindings.Add("Text", _clientPresenter, "Prenom");
            emailClientText.DataBindings.Add("Text", _clientPresenter, "Email");
            societeClientText.DataBindings.Add("Text", _clientPresenter, "NomSociete");
            codeIbanclientText.DataBindings.Add("Text", _clientPresenter, "CodeIban");
            clientIdText.DataBindings.Add("Text", _clientPresenter, "IdClient");
            clientListGrid.DataBindings.Add("DataSource", _clientPresenter, "AllClients", false, DataSourceUpdateMode.OnPropertyChanged);
            clientContratListGrid.DataBindings.Add("DataSource", _contratPresenter, "ContractByClient", false, DataSourceUpdateMode.OnPropertyChanged);


            // Data binding pour la vue "Voiture"
            rechercherVoitureText.DataBindings.Add("Text", _voiturePresenter, "RechercheString");
            immatriculationText.DataBindings.Add("Text", _voiturePresenter, "Immatriculation");
            marqueVoitureText.DataBindings.Add("Text", _voiturePresenter, "Marque");
            modeleVoitureText.DataBindings.Add("Text", _voiturePresenter, "Modele");
            kilometrageVoitureText.DataBindings.Add("Text", _voiturePresenter, "Kilometrage");
            couleurText.DataBindings.Add("Text", _voiturePresenter, "Couleur");
            carburantVoitureText.DataBindings.Add("Text", _voiturePresenter, "Carburant");
            voitureDateFutureCT.DataBindings.Add("Text", _voiturePresenter, "DateFutureCT", true);
            photoVoitureText.DataBindings.Add("Text", _voiturePresenter, "Photo");
            photoVoiture.DataBindings.Add("Image", _voiturePresenter, "Img",true);
            voitureListGrid.DataBindings.Add("DataSource", _voiturePresenter, "AllVoitures", false, DataSourceUpdateMode.OnPropertyChanged);


            // Data binding pour la vue "Salaries"
            rechercheSalarieText.DataBindings.Add("Text", _salariePresenter, "RechercheString");
            nomSalarieText.DataBindings.Add("Text", _salariePresenter, "Nom");
            prenomSalarieText.DataBindings.Add("Text", _salariePresenter, "Prenom");
            emailSalarieText.DataBindings.Add("Text", _salariePresenter, "Email");
            motDePasseSalarieText.DataBindings.Add("Text", _salariePresenter, "MotDePasse");
            dateEmbaucheSalarieDatePicker.DataBindings.Add("Value", _salariePresenter, "DateEmbauche", true);
            salariesGridList.DataBindings.Add("DataSource", _salariePresenter, "AllSalaries", false, DataSourceUpdateMode.OnPropertyChanged);

            // Data binding pour la vue "Contrat"
            rechercheContratText.DataBindings.Add("Text", _contratPresenter, "RechercheString");
            contratDateDebutDateTime.DataBindings.Add("Text", _contratPresenter, "DateDebutContrat", true);
            contratDatefinDateTime.DataBindings.Add("Text", _contratPresenter, "DateFinContrat", true);
            contratTarifText.DataBindings.Add("Text", _contratPresenter, "TarifContrat");
            contratDateRetourDateTime.DataBindings.Add("Visible", isReturnedChechBox, "Checked");
            isReturnedChechBox.DataBindings.Add("Checked", _contratPresenter, "IsReturned");
            contratDateRetourDateTime.DataBindings.Add("Text", _contratPresenter, "DateRetourContrat", true);
            contratClientComboBox.DataBindings.Add("DataSource", _contratPresenter, "AllClients", false, DataSourceUpdateMode.OnPropertyChanged);
            contratVoitureComboBox.DataBindings.Add("DataSource", _contratPresenter, "AllVoitures", false, DataSourceUpdateMode.OnPropertyChanged);
            contratListGrid.DataBindings.Add("DataSource", _contratPresenter, "AllContrats", false, DataSourceUpdateMode.OnPropertyChanged);
            contratClientComboBox.DataBindings.Add("SelectedValue", _contratPresenter, "IdClientContrat");
            contratVoitureComboBox.DataBindings.Add("SelectedValue", _contratPresenter, "ImmatriculationVoitureContrat");
            contratClientNomText.DataBindings.Add("Text", _contratPresenter, "NomContrat");
            contratClientPrenomText.DataBindings.Add("Text", _contratPresenter, "PrenomContrat");
            contratClientEmailText.DataBindings.Add("Text", _contratPresenter, "EmailContrat");
            contratClientIbanText.DataBindings.Add("Text", _contratPresenter, "NomSocieteContrat");
            contratClientSocieteText.DataBindings.Add("Text", _contratPresenter, "CodeIbanContrat");
            contratVoitureCarburantText.DataBindings.Add("Text", _contratPresenter, "CarburantVoitureContrat");
            contratVoitureCouleurText.DataBindings.Add("Text", _contratPresenter, "CouleurVoitureContrat");
            contratVoitureDateFutureCtDateTime.DataBindings.Add("Value", _contratPresenter, "DateFuturCtContratVoitre", true);
            contratVoitureKilometrageText.DataBindings.Add("Text", _contratPresenter, "KilometrageVoitureContrat");
            contratVoitureMarqueText.DataBindings.Add("Text", _contratPresenter, "CodeIbanContrat");
            contratVoitureModeleText.DataBindings.Add("Text", _contratPresenter, "ModeleVoitureContrat");
            contratVoitureImmatriculationText.DataBindings.Add("Text", _contratPresenter, "ImmatriculationVoitureContrat");

            contratAlertListGrid.DataBindings.Add("DataSource", _contratPresenter, "AllAlertedContrats", false, DataSourceUpdateMode.OnPropertyChanged);
            voitureAlertListGrid.DataBindings.Add("DataSource", _voiturePresenter, "AllAlertedVoitures", false, DataSourceUpdateMode.OnPropertyChanged);

            _clientPresenter.getAllClient();

            // Thread de chargement des données secondaires et de gestion des alertes         
            var SecondaryTask = Task.Factory.StartNew(() => initSecondaryData());
            
            //Cacher les colonnes non necessaires pour la vue
            clientListGrid.Columns["IdClient"].Visible = false;
            clientListGrid.Columns["NomComplet"].Visible = false;


        }
        // un presenter par vue (on considére ) que chaque tab est une vue apart
        private ClientPresenter _clientPresenter;
        private ContratPresenter _contratPresenter;
        private VoiturePresenter _voiturePresenter;
        private SalariePresenter _salariePresenter;
      

        private void AjouterClientButton_Click(object sender, EventArgs e)
        {
            if (!validateFormClient())
            {
                return;
            }
            _clientPresenter.AddNewClient();
        }


        private void clientListGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (clientListGrid.SelectedRows.Count > 0)
            {
                clientListGrid.SelectedRows[0].Cells["IdClient"].ValueType =typeof(int) ;
                _clientPresenter.IdClient = (int)clientListGrid.SelectedRows[0].Cells["IdClient"].Value;
                _contratPresenter.IdClientContrat = (int)clientListGrid.SelectedRows[0].Cells["IdClient"].Value;
                _clientPresenter.getClient();
                _contratPresenter.getContractByClient();
                clientContratListGrid.Columns["IdClient"].Visible = false;
                clientContratListGrid.Columns["Voiture"].Visible = false;
                clientContratListGrid.Columns["Client"].Visible = false;
                ModifierClientButton.Enabled = true;
                SupprimerClientButton.Enabled = true;
                AjouterClientButton.Enabled = false;
            }
        }

        private void ModifierClientButton_Click(object sender, EventArgs e)
        {
            if (!validateFormClient())
            {
                return;
            }
            _clientPresenter.UpdateClient();
            ModifierClientButton.Enabled = false;
            SupprimerClientButton.Enabled = false;
            AjouterClientButton.Enabled = true;
        }

        private void SupprimerClientButton_Click(object sender, EventArgs e)
        {
            _clientPresenter.RemoveClient();
            ModifierClientButton.Enabled = false;
            SupprimerClientButton.Enabled = false;
            AjouterClientButton.Enabled = true;

        }

       

        private void RechercherClient_Click(object sender, EventArgs e)
        {
            _clientPresenter.RechercheSelectedItems = new List<string>();
            foreach (var item in clientRechercheCritere.CheckedItems)
            {
                _clientPresenter.RechercheSelectedItems.Add(item.ToString());  
            }
            _clientPresenter.Search();
        }

        private void voitureListGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (voitureListGrid.SelectedRows.Count > 0)
            {
                _voiturePresenter.Immatriculation = voitureListGrid.SelectedRows[0].Cells["Immatriculation"].Value.ToString();
                _voiturePresenter.getVoiture();
                modifierVoitureButton.Enabled = true;
                supprimerVoitureButton.Enabled = true;
                ajouterVoitureButton.Enabled = false;
                changerPhotoVoitureButton.Text = "Changer";
            }

        }

        private void changerPhotoVoitureButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Ouvrir Image";
            openFileDialog.Filter = "(*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png" ;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //photoVoiture.Image = Image.FromFile( openFileDialog.FileName);
                photoVoitureText.Text = openFileDialog.SafeFileName;
                _voiturePresenter.Photo = openFileDialog.SafeFileName;
                _voiturePresenter.Img = Image.FromFile(openFileDialog.FileName);
            }

            openFileDialog.Dispose();
        }

        private void modifierVoitureButton_Click(object sender, EventArgs e)
        {
            if (!validateFormVoiture())
            {
                return;
            }
            _voiturePresenter.UpdateVoiture();
            modifierVoitureButton.Enabled = false;
            supprimerVoitureButton.Enabled = false;
            ajouterVoitureButton.Enabled = true;
            changerPhotoVoitureButton.Text = "Choisir";
        }

        private void ajouterVoitureButton_Click(object sender, EventArgs e)
        {
            if (!validateFormVoiture())
            {
                return;
            }
            _voiturePresenter.AddNewVoiture();
        }

        private void supprimerVoitureButton_Click(object sender, EventArgs e)
        {
            _voiturePresenter.RemoveVoiture();
            modifierVoitureButton.Enabled = false;
            supprimerVoitureButton.Enabled = false;
            ajouterVoitureButton.Enabled = true;
        }

        private void rechercherVoitureButton_Click(object sender, EventArgs e)
        {
            _voiturePresenter.RechercheSelectedItems = new List<string>();
            foreach (var item in voitureRechercheCritere.CheckedItems)
            {
                _voiturePresenter.RechercheSelectedItems.Add(item.ToString());
            }
            _voiturePresenter.Search();
        }

        private void ajouterSalarieButton_Click(object sender, EventArgs e)
        {
            if (!validateformSalarie())
            {
                return;
            }
            _salariePresenter.AddNewSalarie();
        }

        private void modifierSalarieButton_Click(object sender, EventArgs e)
        {
            if (!validateformSalarie())
            {
                return;
            }
            _salariePresenter.UpdateSalarie();
            modifierSalarieButton.Enabled = false;
            supprimerSalarieButton.Enabled = false;
            ajouterSalarieButton.Enabled = true;
        }

        private void supprimerSalarieButton_Click(object sender, EventArgs e)
        {
            _salariePresenter.RemoveSalarie();
            modifierSalarieButton.Enabled = false;
            supprimerSalarieButton.Enabled = false;
            ajouterSalarieButton.Enabled = true;
        }

        private void salariesGridList_SelectionChanged(object sender, EventArgs e)
        {

            if (salariesGridList.SelectedRows.Count > 0)
            {
                _salariePresenter.IdSalarie = (int) salariesGridList.SelectedRows[0].Cells["IdSalarie"].Value;
                _salariePresenter.getSalarie();
                modifierSalarieButton.Enabled = true;
                supprimerSalarieButton.Enabled = true;
                ajouterSalarieButton.Enabled = false;
            }
        }

        private void rechercheSalarieButton_Click(object sender, EventArgs e)
        {
            _salariePresenter.RechercheSelectedItems = new List<string>();
            foreach (var item in salarieRechercheCritere.CheckedItems)
            {
                _salariePresenter.RechercheSelectedItems.Add(item.ToString());
            }
            _salariePresenter.Search();
        }

        private void recherhceContratButton_Click(object sender, EventArgs e)
        {
            _contratPresenter.RechercheSelectedItems = new List<string>();
            foreach (var item in contratRechercheCritere.CheckedItems)
            {
                _contratPresenter.RechercheSelectedItems.Add(item.ToString());
            }
            _contratPresenter.Search();
        }

        private void contratListGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (contratListGrid.SelectedRows.Count > 0)
            {
                _contratPresenter.NumContrat = Int32.Parse(contratListGrid.SelectedRows[0].Cells["NumContrat"].Value.ToString());
                _contratPresenter.getContrat();
                modifierContratButton.Enabled = true;
                supprimerContratButton.Enabled = true;
                ajouterContratButton.Enabled = false;
            }
        }

        private void supprimerContratButton_Click(object sender, EventArgs e)
        {
            _contratPresenter.RemoveContrat();
            modifierContratButton.Enabled = false;
            supprimerContratButton.Enabled = false;
            ajouterContratButton.Enabled = true;
        }

        private void modifierContratButton_Click(object sender, EventArgs e)
        {
            if (!validateFormContrat())
            {
                return;
            }
            _contratPresenter.UpdateContrat();
            modifierContratButton.Enabled = false;
            supprimerContratButton.Enabled = false;
            ajouterContratButton.Enabled = true;
        }

        private void ajouterContratButton_Click(object sender, EventArgs e)
        {
            if (!validateFormContrat())
            {
                return;
            }
            _contratPresenter.AddNewContract();
        }

        private void contratListGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            contratListGrid.Columns["IdClient"].Visible = false;
            contratListGrid.Columns["Client"].Visible = false;
            contratListGrid.Columns["Voiture"].Visible = false;
            contratListGrid.Columns["NomCompletClient"].Visible = false;
        }

        private void voitureListGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            voitureListGrid.Columns["LibelleVoiture"].Visible = false;
        }

        private void salariesGridList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            salariesGridList.Columns["IdSalarie"].Visible = false;
            salariesGridList.Columns["MotDePasse"].Visible = false;
        }

       

        private void contratAlertListGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            contratAlertListGrid.Columns["Client"].Visible = false;
            contratAlertListGrid.Columns["Voiture"].Visible = false;
            contratAlertListGrid.Columns["IdClient"].Visible = false;
        }

        private void voitureAlertListGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            voitureAlertListGrid.Columns["Photo"].Visible = false;
        }

        private bool validateformSalarie()
        {
            if (string.IsNullOrEmpty(nomSalarieText.Text))
            {
                MessageBox.Show("Le champ Nom ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(prenomSalarieText.Text))
            {
                MessageBox.Show("Le champ Prenom ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(emailSalarieText.Text))
            {
                MessageBox.Show("Le champ Email ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(motDePasseSalarieText.Text))
            {
                MessageBox.Show("Le champ Mot de passe ne peut pas être vide!");
                return false;
            }
            return true;
        }


        #region Validation des vues
        
        
        private bool validateFormClient()
        {

            if (string.IsNullOrEmpty(nomClientText.Text))
            {
                MessageBox.Show("Le champ Nom ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(prenomClientText.Text))
            {
                MessageBox.Show("Le champ Prenom ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(emailClientText.Text))
            {
                MessageBox.Show("Le champ Email ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(societeClientText.Text))
            {
                MessageBox.Show("Le champ Société du client ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(codeIbanclientText.Text))
            {
                MessageBox.Show("Le champ Code Iban du client ne peut pas être vide!");
                return false;
            }

            return true;
        }

        bool validateFormVoiture()
        {

            if (string.IsNullOrEmpty(marqueVoitureText.Text))
            {
                MessageBox.Show("Le champ Marque ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(modeleVoitureText.Text))
            {
                MessageBox.Show("Le champ Modele ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(kilometrageVoitureText.Text) || kilometrageVoitureText.Text=="0")
            {
                MessageBox.Show("Le champ Kilométrage ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(carburantVoitureText.Text))
            {
                MessageBox.Show("Le champ Carburant  ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(immatriculationText.Text))
            {
                MessageBox.Show("Le champ Immatriculation ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(couleurText.Text))
            {
                MessageBox.Show("Le Champ Couleur ne peut pas être vide!");
                return false;
            }
            if (string.IsNullOrEmpty(photoVoitureText.Text))
            {
                MessageBox.Show("Le champ Photo ne peut pas être vide!");
                return false;
            }
            return true;
        }
        bool validateFormContrat()
        {

            if (string.IsNullOrEmpty(contratTarifText.Text) || contratTarifText.Text=="0")
            {
                MessageBox.Show("Le champ Tarif ne peut pas être vide!");
                return false;
            }
            if (contratClientComboBox.SelectedValue ==null || string.IsNullOrEmpty(contratClientComboBox.SelectedValue.ToString()) || contratClientComboBox.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Le champ Client ne peut pas être vide!");
                return false;
            }
            if (contratVoitureComboBox.SelectedValue ==null || string.IsNullOrEmpty(contratVoitureComboBox.SelectedValue.ToString()) || contratVoitureComboBox.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Le champ Voiture ne peut pas être vide!");
                return false;
            }
            
            return true;
        }

        #endregion

        // Chargement des données non initiales
        private void initSecondaryData()
        {
            _voiturePresenter.getAllVoiture();
            _salariePresenter.getAllSalaries();
            _contratPresenter.getAllContrat();
            _contratPresenter.getAllAlertedContrat();
            _voiturePresenter.getAllAlertedVoiture();
            // aprés le chargement des données, vérifier les alertes
           
           
        }

        // Gestion des alertes
        private void getAlerts()
        {
            // initialiser les alertes
            int nbrAllert = _contratPresenter.AllAlertedContrats.Count() + _voiturePresenter.AllAlertedVoitures.Count();
            if (nbrAllert > 0)
            {
                tabPage6.Text = "Alertes (" + nbrAllert + ")";
                DialogResult res = MessageBox.Show("Vous Avez " + nbrAllert + " alerte(s), voulez vous les consulter ? ", "Alerte", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    tabControl1.SelectTab(4);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 300000; // le 1er appel apres 5 second du chargement puis on fixe l'intervale a 5min
            getAlerts();
        }
    }
}
