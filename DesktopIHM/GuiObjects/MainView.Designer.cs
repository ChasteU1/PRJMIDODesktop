using Microsoft.Practices.Unity;
using DataService.DAOService.DaoServiceInt;
using DataService.DAOService.DaoServiceImp;
using DataService.BSService.BSServiceImp;
using DataService.BSService.BSServiceInt;
using DataService.DataObjects;
namespace GuiObjects.DesktopIHM
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.clientListGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RechercherClient = new System.Windows.Forms.Button();
            this.rechercheClientText = new System.Windows.Forms.TextBox();
            this.clientRechercheCritere = new System.Windows.Forms.CheckedListBox();
            this.clientIdText = new System.Windows.Forms.TextBox();
            this.SupprimerClientButton = new System.Windows.Forms.Button();
            this.ModifierClientButton = new System.Windows.Forms.Button();
            this.AjouterClientButton = new System.Windows.Forms.Button();
            this.DetailClient = new System.Windows.Forms.TabControl();
            this.ClientContratTab = new System.Windows.Forms.TabPage();
            this.clientContratListGrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClientNom = new System.Windows.Forms.Label();
            this.PrenomClient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomClientText = new System.Windows.Forms.TextBox();
            this.prenomClientText = new System.Windows.Forms.TextBox();
            this.emailClientText = new System.Windows.Forms.TextBox();
            this.societeClientText = new System.Windows.Forms.TextBox();
            this.codeIbanclientText = new System.Windows.Forms.TextBox();
            this.tabContrats = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label23 = new System.Windows.Forms.Label();
            this.contratListGrid = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.recherhceContratButton = new System.Windows.Forms.Button();
            this.rechercheContratText = new System.Windows.Forms.TextBox();
            this.contratRechercheCritere = new System.Windows.Forms.CheckedListBox();
            this.supprimerContratButton = new System.Windows.Forms.Button();
            this.modifierContratButton = new System.Windows.Forms.Button();
            this.ajouterContratButton = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.contratClientNomText = new System.Windows.Forms.TextBox();
            this.contratClientPrenomText = new System.Windows.Forms.TextBox();
            this.contratClientEmailText = new System.Windows.Forms.TextBox();
            this.contratClientSocieteText = new System.Windows.Forms.TextBox();
            this.contratClientIbanText = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.contratVoitureImmatriculationText = new System.Windows.Forms.TextBox();
            this.contratVoitureMarqueText = new System.Windows.Forms.TextBox();
            this.contratVoitureModeleText = new System.Windows.Forms.TextBox();
            this.contratVoitureKilometrageText = new System.Windows.Forms.TextBox();
            this.contratVoitureCouleurText = new System.Windows.Forms.TextBox();
            this.contratVoitureCarburantText = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.contratVoitureDateFutureCtDateTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.isReturnedChechBox = new System.Windows.Forms.CheckBox();
            this.contratDateRetourDateTime = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.contratTarifText = new System.Windows.Forms.TextBox();
            this.contratDatefinDateTime = new System.Windows.Forms.DateTimePicker();
            this.contratDateDebutDateTime = new System.Windows.Forms.DateTimePicker();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.contratVoitureComboBox = new System.Windows.Forms.ComboBox();
            this.contratClientComboBox = new System.Windows.Forms.ComboBox();
            this.tabVoitures = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.voitureListGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rechercherVoitureButton = new System.Windows.Forms.Button();
            this.rechercherVoitureText = new System.Windows.Forms.TextBox();
            this.voitureRechercheCritere = new System.Windows.Forms.CheckedListBox();
            this.supprimerVoitureButton = new System.Windows.Forms.Button();
            this.modifierVoitureButton = new System.Windows.Forms.Button();
            this.ajouterVoitureButton = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.photoVoiture = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changerPhotoVoitureButton = new System.Windows.Forms.Button();
            this.photoVoitureText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.immatriculationText = new System.Windows.Forms.TextBox();
            this.marqueVoitureText = new System.Windows.Forms.TextBox();
            this.modeleVoitureText = new System.Windows.Forms.TextBox();
            this.kilometrageVoitureText = new System.Windows.Forms.TextBox();
            this.couleurText = new System.Windows.Forms.TextBox();
            this.carburantVoitureText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.voitureDateFutureCT = new System.Windows.Forms.DateTimePicker();
            this.tabSalaries = new System.Windows.Forms.TabPage();
            this.supprimerSalarieButton = new System.Windows.Forms.Button();
            this.modifierSalarieButton = new System.Windows.Forms.Button();
            this.ajouterSalarieButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.salariesGridList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.nomSalarieText = new System.Windows.Forms.TextBox();
            this.prenomSalarieText = new System.Windows.Forms.TextBox();
            this.emailSalarieText = new System.Windows.Forms.TextBox();
            this.motDePasseSalarieText = new System.Windows.Forms.TextBox();
            this.dateEmbaucheSalarieDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rechercheSalarieButton = new System.Windows.Forms.Button();
            this.rechercheSalarieText = new System.Windows.Forms.TextBox();
            this.salarieRechercheCritere = new System.Windows.Forms.CheckedListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.contratAlertListGrid = new System.Windows.Forms.DataGridView();
            this.label25 = new System.Windows.Forms.Label();
            this.voitureAlertListGrid = new System.Windows.Forms.DataGridView();
            this.label44 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientListGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.DetailClient.SuspendLayout();
            this.ClientContratTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientContratListGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabContrats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratListGrid)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabVoitures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voitureListGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoVoiture)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSalaries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salariesGridList)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contratAlertListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureAlertListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClients);
            this.tabControl1.Controls.Add(this.tabContrats);
            this.tabControl1.Controls.Add(this.tabVoitures);
            this.tabControl1.Controls.Add(this.tabSalaries);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1285, 627);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.splitContainer1);
            this.tabClients.Location = new System.Drawing.Point(4, 25);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(1277, 598);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Gestions Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.clientListGrid);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clientIdText);
            this.splitContainer1.Panel2.Controls.Add(this.SupprimerClientButton);
            this.splitContainer1.Panel2.Controls.Add(this.ModifierClientButton);
            this.splitContainer1.Panel2.Controls.Add(this.AjouterClientButton);
            this.splitContainer1.Panel2.Controls.Add(this.DetailClient);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1271, 592);
            this.splitContainer1.SplitterDistance = 547;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liste des Clients";
            // 
            // clientListGrid
            // 
            this.clientListGrid.AllowUserToAddRows = false;
            this.clientListGrid.AllowUserToDeleteRows = false;
            this.clientListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientListGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.clientListGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clientListGrid.Location = new System.Drawing.Point(5, 173);
            this.clientListGrid.MultiSelect = false;
            this.clientListGrid.Name = "clientListGrid";
            this.clientListGrid.ReadOnly = true;
            this.clientListGrid.RowTemplate.Height = 24;
            this.clientListGrid.Size = new System.Drawing.Size(533, 415);
            this.clientListGrid.TabIndex = 1;
            this.clientListGrid.SelectionChanged += new System.EventHandler(this.clientListGrid_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RechercherClient);
            this.groupBox1.Controls.Add(this.rechercheClientText);
            this.groupBox1.Controls.Add(this.clientRechercheCritere);
            this.groupBox1.Location = new System.Drawing.Point(5, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche clients";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rechercher par: ";
            // 
            // RechercherClient
            // 
            this.RechercherClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RechercherClient.Location = new System.Drawing.Point(417, 21);
            this.RechercherClient.Name = "RechercherClient";
            this.RechercherClient.Size = new System.Drawing.Size(110, 23);
            this.RechercherClient.TabIndex = 2;
            this.RechercherClient.Text = "Rechercher";
            this.RechercherClient.UseVisualStyleBackColor = true;
            this.RechercherClient.Click += new System.EventHandler(this.RechercherClient_Click);
            // 
            // rechercheClientText
            // 
            this.rechercheClientText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rechercheClientText.Location = new System.Drawing.Point(20, 22);
            this.rechercheClientText.Name = "rechercheClientText";
            this.rechercheClientText.Size = new System.Drawing.Size(393, 22);
            this.rechercheClientText.TabIndex = 1;
            // 
            // clientRechercheCritere
            // 
            this.clientRechercheCritere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientRechercheCritere.FormattingEnabled = true;
            this.clientRechercheCritere.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Email",
            "Société"});
            this.clientRechercheCritere.Location = new System.Drawing.Point(20, 76);
            this.clientRechercheCritere.MultiColumn = true;
            this.clientRechercheCritere.Name = "clientRechercheCritere";
            this.clientRechercheCritere.Size = new System.Drawing.Size(507, 38);
            this.clientRechercheCritere.TabIndex = 0;
            // 
            // clientIdText
            // 
            this.clientIdText.Location = new System.Drawing.Point(14, 184);
            this.clientIdText.Name = "clientIdText";
            this.clientIdText.Size = new System.Drawing.Size(43, 22);
            this.clientIdText.TabIndex = 6;
            this.clientIdText.Visible = false;
            // 
            // SupprimerClientButton
            // 
            this.SupprimerClientButton.Enabled = false;
            this.SupprimerClientButton.Location = new System.Drawing.Point(431, 198);
            this.SupprimerClientButton.Name = "SupprimerClientButton";
            this.SupprimerClientButton.Size = new System.Drawing.Size(124, 23);
            this.SupprimerClientButton.TabIndex = 4;
            this.SupprimerClientButton.Text = "Supprmier Client";
            this.SupprimerClientButton.UseVisualStyleBackColor = true;
            this.SupprimerClientButton.Click += new System.EventHandler(this.SupprimerClientButton_Click);
            // 
            // ModifierClientButton
            // 
            this.ModifierClientButton.Enabled = false;
            this.ModifierClientButton.Location = new System.Drawing.Point(301, 198);
            this.ModifierClientButton.Name = "ModifierClientButton";
            this.ModifierClientButton.Size = new System.Drawing.Size(124, 23);
            this.ModifierClientButton.TabIndex = 3;
            this.ModifierClientButton.Text = "Modifier Client";
            this.ModifierClientButton.UseVisualStyleBackColor = true;
            this.ModifierClientButton.Click += new System.EventHandler(this.ModifierClientButton_Click);
            // 
            // AjouterClientButton
            // 
            this.AjouterClientButton.Location = new System.Drawing.Point(171, 198);
            this.AjouterClientButton.Name = "AjouterClientButton";
            this.AjouterClientButton.Size = new System.Drawing.Size(124, 23);
            this.AjouterClientButton.TabIndex = 2;
            this.AjouterClientButton.Text = "Ajouter Client";
            this.AjouterClientButton.UseVisualStyleBackColor = true;
            this.AjouterClientButton.Click += new System.EventHandler(this.AjouterClientButton_Click);
            // 
            // DetailClient
            // 
            this.DetailClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailClient.Controls.Add(this.ClientContratTab);
            this.DetailClient.Controls.Add(this.tabPage2);
            this.DetailClient.Location = new System.Drawing.Point(14, 247);
            this.DetailClient.Name = "DetailClient";
            this.DetailClient.SelectedIndex = 0;
            this.DetailClient.Size = new System.Drawing.Size(689, 340);
            this.DetailClient.TabIndex = 1;
            // 
            // ClientContratTab
            // 
            this.ClientContratTab.Controls.Add(this.clientContratListGrid);
            this.ClientContratTab.Location = new System.Drawing.Point(4, 25);
            this.ClientContratTab.Name = "ClientContratTab";
            this.ClientContratTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClientContratTab.Size = new System.Drawing.Size(681, 311);
            this.ClientContratTab.TabIndex = 0;
            this.ClientContratTab.Text = "List des Contrats du Client";
            this.ClientContratTab.UseVisualStyleBackColor = true;
            // 
            // clientContratListGrid
            // 
            this.clientContratListGrid.AllowUserToAddRows = false;
            this.clientContratListGrid.AllowUserToDeleteRows = false;
            this.clientContratListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientContratListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientContratListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientContratListGrid.Location = new System.Drawing.Point(6, 6);
            this.clientContratListGrid.Name = "clientContratListGrid";
            this.clientContratListGrid.RowTemplate.Height = 24;
            this.clientContratListGrid.Size = new System.Drawing.Size(672, 299);
            this.clientContratListGrid.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autre";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.9403F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.0597F));
            this.tableLayoutPanel1.Controls.Add(this.ClientNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PrenomClient, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nomClientText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.prenomClientText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailClientText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.societeClientText, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.codeIbanclientText, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 165);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ClientNom
            // 
            this.ClientNom.AutoSize = true;
            this.ClientNom.Location = new System.Drawing.Point(3, 0);
            this.ClientNom.Name = "ClientNom";
            this.ClientNom.Size = new System.Drawing.Size(104, 17);
            this.ClientNom.TabIndex = 0;
            this.ClientNom.Text = "Nom du Client: ";
            // 
            // PrenomClient
            // 
            this.PrenomClient.AutoSize = true;
            this.PrenomClient.Location = new System.Drawing.Point(3, 33);
            this.PrenomClient.Name = "PrenomClient";
            this.PrenomClient.Size = new System.Drawing.Size(124, 17);
            this.PrenomClient.TabIndex = 1;
            this.PrenomClient.Text = "Prénom du Client: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Société: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Code IBAN: ";
            // 
            // nomClientText
            // 
            this.nomClientText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomClientText.Location = new System.Drawing.Point(154, 3);
            this.nomClientText.Name = "nomClientText";
            this.nomClientText.Size = new System.Drawing.Size(532, 22);
            this.nomClientText.TabIndex = 5;
            // 
            // prenomClientText
            // 
            this.prenomClientText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prenomClientText.Location = new System.Drawing.Point(154, 36);
            this.prenomClientText.Name = "prenomClientText";
            this.prenomClientText.Size = new System.Drawing.Size(532, 22);
            this.prenomClientText.TabIndex = 6;
            // 
            // emailClientText
            // 
            this.emailClientText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailClientText.Location = new System.Drawing.Point(154, 69);
            this.emailClientText.Name = "emailClientText";
            this.emailClientText.Size = new System.Drawing.Size(532, 22);
            this.emailClientText.TabIndex = 7;
            // 
            // societeClientText
            // 
            this.societeClientText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.societeClientText.Location = new System.Drawing.Point(154, 102);
            this.societeClientText.Name = "societeClientText";
            this.societeClientText.Size = new System.Drawing.Size(532, 22);
            this.societeClientText.TabIndex = 8;
            // 
            // codeIbanclientText
            // 
            this.codeIbanclientText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeIbanclientText.Location = new System.Drawing.Point(154, 135);
            this.codeIbanclientText.Name = "codeIbanclientText";
            this.codeIbanclientText.Size = new System.Drawing.Size(532, 22);
            this.codeIbanclientText.TabIndex = 9;
            // 
            // tabContrats
            // 
            this.tabContrats.Controls.Add(this.splitContainer3);
            this.tabContrats.Location = new System.Drawing.Point(4, 25);
            this.tabContrats.Name = "tabContrats";
            this.tabContrats.Padding = new System.Windows.Forms.Padding(3);
            this.tabContrats.Size = new System.Drawing.Size(1277, 598);
            this.tabContrats.TabIndex = 1;
            this.tabContrats.Text = "Gestion Contrats";
            this.tabContrats.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label23);
            this.splitContainer3.Panel1.Controls.Add(this.contratListGrid);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.supprimerContratButton);
            this.splitContainer3.Panel2.Controls.Add(this.modifierContratButton);
            this.splitContainer3.Panel2.Controls.Add(this.ajouterContratButton);
            this.splitContainer3.Panel2.Controls.Add(this.tabControl3);
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer3.Size = new System.Drawing.Size(1271, 592);
            this.splitContainer3.SplitterDistance = 547;
            this.splitContainer3.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 152);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 17);
            this.label23.TabIndex = 2;
            this.label23.Text = "Liste des Contrats";
            // 
            // contratListGrid
            // 
            this.contratListGrid.AllowUserToAddRows = false;
            this.contratListGrid.AllowUserToDeleteRows = false;
            this.contratListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contratListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contratListGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.contratListGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contratListGrid.Location = new System.Drawing.Point(5, 172);
            this.contratListGrid.MultiSelect = false;
            this.contratListGrid.Name = "contratListGrid";
            this.contratListGrid.ReadOnly = true;
            this.contratListGrid.RowTemplate.Height = 24;
            this.contratListGrid.Size = new System.Drawing.Size(533, 415);
            this.contratListGrid.TabIndex = 1;
            this.contratListGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.contratListGrid_DataBindingComplete);
            this.contratListGrid.SelectionChanged += new System.EventHandler(this.contratListGrid_SelectionChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.recherhceContratButton);
            this.groupBox4.Controls.Add(this.rechercheContratText);
            this.groupBox4.Controls.Add(this.contratRechercheCritere);
            this.groupBox4.Location = new System.Drawing.Point(5, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(533, 119);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recherche contrat";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 53);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(115, 17);
            this.label24.TabIndex = 3;
            this.label24.Text = "Rechercher par: ";
            // 
            // recherhceContratButton
            // 
            this.recherhceContratButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.recherhceContratButton.Location = new System.Drawing.Point(417, 21);
            this.recherhceContratButton.Name = "recherhceContratButton";
            this.recherhceContratButton.Size = new System.Drawing.Size(110, 23);
            this.recherhceContratButton.TabIndex = 2;
            this.recherhceContratButton.Text = "Rechercher";
            this.recherhceContratButton.UseVisualStyleBackColor = true;
            this.recherhceContratButton.Click += new System.EventHandler(this.recherhceContratButton_Click);
            // 
            // rechercheContratText
            // 
            this.rechercheContratText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rechercheContratText.Location = new System.Drawing.Point(20, 22);
            this.rechercheContratText.Name = "rechercheContratText";
            this.rechercheContratText.Size = new System.Drawing.Size(393, 22);
            this.rechercheContratText.TabIndex = 1;
            // 
            // contratRechercheCritere
            // 
            this.contratRechercheCritere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratRechercheCritere.FormattingEnabled = true;
            this.contratRechercheCritere.Items.AddRange(new object[] {
            "Nom client",
            "Prenom client",
            "Immatriculation voiture",
            "Marque voiture"});
            this.contratRechercheCritere.Location = new System.Drawing.Point(20, 76);
            this.contratRechercheCritere.MultiColumn = true;
            this.contratRechercheCritere.Name = "contratRechercheCritere";
            this.contratRechercheCritere.Size = new System.Drawing.Size(507, 38);
            this.contratRechercheCritere.TabIndex = 0;
            // 
            // supprimerContratButton
            // 
            this.supprimerContratButton.Enabled = false;
            this.supprimerContratButton.Location = new System.Drawing.Point(431, 249);
            this.supprimerContratButton.Name = "supprimerContratButton";
            this.supprimerContratButton.Size = new System.Drawing.Size(124, 23);
            this.supprimerContratButton.TabIndex = 4;
            this.supprimerContratButton.Text = "Supprmier Contrat";
            this.supprimerContratButton.UseVisualStyleBackColor = true;
            this.supprimerContratButton.Click += new System.EventHandler(this.supprimerContratButton_Click);
            // 
            // modifierContratButton
            // 
            this.modifierContratButton.Enabled = false;
            this.modifierContratButton.Location = new System.Drawing.Point(301, 249);
            this.modifierContratButton.Name = "modifierContratButton";
            this.modifierContratButton.Size = new System.Drawing.Size(124, 23);
            this.modifierContratButton.TabIndex = 3;
            this.modifierContratButton.Text = "Modifier Contrat";
            this.modifierContratButton.UseVisualStyleBackColor = true;
            this.modifierContratButton.Click += new System.EventHandler(this.modifierContratButton_Click);
            // 
            // ajouterContratButton
            // 
            this.ajouterContratButton.Location = new System.Drawing.Point(171, 249);
            this.ajouterContratButton.Name = "ajouterContratButton";
            this.ajouterContratButton.Size = new System.Drawing.Size(124, 23);
            this.ajouterContratButton.TabIndex = 2;
            this.ajouterContratButton.Text = "Ajouter Contrat";
            this.ajouterContratButton.UseVisualStyleBackColor = true;
            this.ajouterContratButton.Click += new System.EventHandler(this.ajouterContratButton_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Location = new System.Drawing.Point(14, 296);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(689, 291);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(681, 262);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Le Client";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.9403F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.0597F));
            this.tableLayoutPanel5.Controls.Add(this.label30, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label31, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label32, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label33, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label34, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.contratClientNomText, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.contratClientPrenomText, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.contratClientEmailText, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.contratClientSocieteText, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.contratClientIbanText, 1, 4);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(-4, 26);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(689, 173);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 17);
            this.label30.TabIndex = 0;
            this.label30.Text = "Nom du Client: ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 34);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(124, 17);
            this.label31.TabIndex = 1;
            this.label31.Text = "Prénom du Client: ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 68);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(50, 17);
            this.label32.TabIndex = 2;
            this.label32.Text = "Email: ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 102);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(63, 17);
            this.label33.TabIndex = 3;
            this.label33.Text = "Société: ";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 136);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(84, 17);
            this.label34.TabIndex = 4;
            this.label34.Text = "Code IBAN: ";
            // 
            // contratClientNomText
            // 
            this.contratClientNomText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratClientNomText.Location = new System.Drawing.Point(154, 3);
            this.contratClientNomText.Name = "contratClientNomText";
            this.contratClientNomText.ReadOnly = true;
            this.contratClientNomText.Size = new System.Drawing.Size(532, 22);
            this.contratClientNomText.TabIndex = 5;
            // 
            // contratClientPrenomText
            // 
            this.contratClientPrenomText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratClientPrenomText.Location = new System.Drawing.Point(154, 37);
            this.contratClientPrenomText.Name = "contratClientPrenomText";
            this.contratClientPrenomText.ReadOnly = true;
            this.contratClientPrenomText.Size = new System.Drawing.Size(532, 22);
            this.contratClientPrenomText.TabIndex = 6;
            // 
            // contratClientEmailText
            // 
            this.contratClientEmailText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratClientEmailText.Location = new System.Drawing.Point(154, 71);
            this.contratClientEmailText.Name = "contratClientEmailText";
            this.contratClientEmailText.ReadOnly = true;
            this.contratClientEmailText.Size = new System.Drawing.Size(532, 22);
            this.contratClientEmailText.TabIndex = 7;
            // 
            // contratClientSocieteText
            // 
            this.contratClientSocieteText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratClientSocieteText.Location = new System.Drawing.Point(154, 105);
            this.contratClientSocieteText.Name = "contratClientSocieteText";
            this.contratClientSocieteText.ReadOnly = true;
            this.contratClientSocieteText.Size = new System.Drawing.Size(532, 22);
            this.contratClientSocieteText.TabIndex = 8;
            // 
            // contratClientIbanText
            // 
            this.contratClientIbanText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratClientIbanText.Location = new System.Drawing.Point(154, 139);
            this.contratClientIbanText.Name = "contratClientIbanText";
            this.contratClientIbanText.ReadOnly = true;
            this.contratClientIbanText.Size = new System.Drawing.Size(532, 22);
            this.contratClientIbanText.TabIndex = 9;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(681, 262);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "La Voiture";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.9403F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.0597F));
            this.tableLayoutPanel6.Controls.Add(this.label35, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label36, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label37, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label38, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label39, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.contratVoitureImmatriculationText, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.contratVoitureMarqueText, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.contratVoitureModeleText, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.contratVoitureKilometrageText, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.contratVoitureCouleurText, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.contratVoitureCarburantText, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.label40, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label41, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.contratVoitureDateFutureCtDateTime, 1, 6);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(-6, 27);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 7;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(693, 236);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(110, 17);
            this.label35.TabIndex = 0;
            this.label35.Text = "Immatriculation: ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 33);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(113, 17);
            this.label36.TabIndex = 1;
            this.label36.Text = "Marque Voiture: ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 66);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(103, 17);
            this.label37.TabIndex = 2;
            this.label37.Text = "Modèle Voiture";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 99);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(87, 17);
            this.label38.TabIndex = 3;
            this.label38.Text = "Kilometrage:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 132);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(65, 17);
            this.label39.TabIndex = 4;
            this.label39.Text = "Couleur: ";
            // 
            // contratVoitureImmatriculationText
            // 
            this.contratVoitureImmatriculationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratVoitureImmatriculationText.Location = new System.Drawing.Point(155, 3);
            this.contratVoitureImmatriculationText.Name = "contratVoitureImmatriculationText";
            this.contratVoitureImmatriculationText.ReadOnly = true;
            this.contratVoitureImmatriculationText.Size = new System.Drawing.Size(535, 22);
            this.contratVoitureImmatriculationText.TabIndex = 5;
            // 
            // contratVoitureMarqueText
            // 
            this.contratVoitureMarqueText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratVoitureMarqueText.Location = new System.Drawing.Point(155, 36);
            this.contratVoitureMarqueText.Name = "contratVoitureMarqueText";
            this.contratVoitureMarqueText.ReadOnly = true;
            this.contratVoitureMarqueText.Size = new System.Drawing.Size(535, 22);
            this.contratVoitureMarqueText.TabIndex = 6;
            // 
            // contratVoitureModeleText
            // 
            this.contratVoitureModeleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratVoitureModeleText.Location = new System.Drawing.Point(155, 69);
            this.contratVoitureModeleText.Name = "contratVoitureModeleText";
            this.contratVoitureModeleText.ReadOnly = true;
            this.contratVoitureModeleText.Size = new System.Drawing.Size(535, 22);
            this.contratVoitureModeleText.TabIndex = 7;
            // 
            // contratVoitureKilometrageText
            // 
            this.contratVoitureKilometrageText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratVoitureKilometrageText.Location = new System.Drawing.Point(155, 102);
            this.contratVoitureKilometrageText.Name = "contratVoitureKilometrageText";
            this.contratVoitureKilometrageText.ReadOnly = true;
            this.contratVoitureKilometrageText.Size = new System.Drawing.Size(535, 22);
            this.contratVoitureKilometrageText.TabIndex = 8;
            // 
            // contratVoitureCouleurText
            // 
            this.contratVoitureCouleurText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratVoitureCouleurText.Location = new System.Drawing.Point(155, 135);
            this.contratVoitureCouleurText.Name = "contratVoitureCouleurText";
            this.contratVoitureCouleurText.ReadOnly = true;
            this.contratVoitureCouleurText.Size = new System.Drawing.Size(535, 22);
            this.contratVoitureCouleurText.TabIndex = 9;
            // 
            // contratVoitureCarburantText
            // 
            this.contratVoitureCarburantText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratVoitureCarburantText.Location = new System.Drawing.Point(155, 168);
            this.contratVoitureCarburantText.Name = "contratVoitureCarburantText";
            this.contratVoitureCarburantText.ReadOnly = true;
            this.contratVoitureCarburantText.Size = new System.Drawing.Size(535, 22);
            this.contratVoitureCarburantText.TabIndex = 10;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 165);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(71, 17);
            this.label40.TabIndex = 12;
            this.label40.Text = "Carburant";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(3, 198);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(97, 17);
            this.label41.TabIndex = 13;
            this.label41.Text = "DateFutureCT";
            // 
            // contratVoitureDateFutureCtDateTime
            // 
            this.contratVoitureDateFutureCtDateTime.Enabled = false;
            this.contratVoitureDateFutureCtDateTime.Location = new System.Drawing.Point(155, 201);
            this.contratVoitureDateFutureCtDateTime.Name = "contratVoitureDateFutureCtDateTime";
            this.contratVoitureDateFutureCtDateTime.RightToLeftLayout = true;
            this.contratVoitureDateFutureCtDateTime.Size = new System.Drawing.Size(535, 22);
            this.contratVoitureDateFutureCtDateTime.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.9403F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.0597F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label29, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label28, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label27, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label26, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.contratTarifText, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.contratDatefinDateTime, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.contratDateDebutDateTime, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label42, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label43, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.contratVoitureComboBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.contratClientComboBox, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(689, 230);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.isReturnedChechBox);
            this.panel2.Controls.Add(this.contratDateRetourDateTime);
            this.panel2.Location = new System.Drawing.Point(154, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 30);
            this.panel2.TabIndex = 7;
            // 
            // isReturnedChechBox
            // 
            this.isReturnedChechBox.AutoSize = true;
            this.isReturnedChechBox.Location = new System.Drawing.Point(3, 3);
            this.isReturnedChechBox.Name = "isReturnedChechBox";
            this.isReturnedChechBox.Size = new System.Drawing.Size(18, 17);
            this.isReturnedChechBox.TabIndex = 0;
            this.isReturnedChechBox.UseVisualStyleBackColor = true;
            // 
            // contratDateRetourDateTime
            // 
            this.contratDateRetourDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratDateRetourDateTime.Location = new System.Drawing.Point(25, 1);
            this.contratDateRetourDateTime.Name = "contratDateRetourDateTime";
            this.contratDateRetourDateTime.Size = new System.Drawing.Size(503, 22);
            this.contratDateRetourDateTime.TabIndex = 12;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 190);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(88, 17);
            this.label29.TabIndex = 16;
            this.label29.Text = "Date retour: ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 152);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(45, 17);
            this.label28.TabIndex = 15;
            this.label28.Text = "Tarif: ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 114);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 17);
            this.label27.TabIndex = 14;
            this.label27.Text = "Date fin: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 76);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(86, 17);
            this.label26.TabIndex = 13;
            this.label26.Text = "Date début: ";
            // 
            // contratTarifText
            // 
            this.contratTarifText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratTarifText.Location = new System.Drawing.Point(154, 155);
            this.contratTarifText.Name = "contratTarifText";
            this.contratTarifText.Size = new System.Drawing.Size(532, 22);
            this.contratTarifText.TabIndex = 8;
            // 
            // contratDatefinDateTime
            // 
            this.contratDatefinDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratDatefinDateTime.Location = new System.Drawing.Point(154, 117);
            this.contratDatefinDateTime.Name = "contratDatefinDateTime";
            this.contratDatefinDateTime.Size = new System.Drawing.Size(532, 22);
            this.contratDatefinDateTime.TabIndex = 11;
            // 
            // contratDateDebutDateTime
            // 
            this.contratDateDebutDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratDateDebutDateTime.Location = new System.Drawing.Point(154, 79);
            this.contratDateDebutDateTime.Name = "contratDateDebutDateTime";
            this.contratDateDebutDateTime.Size = new System.Drawing.Size(532, 22);
            this.contratDateDebutDateTime.TabIndex = 10;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(3, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(43, 17);
            this.label42.TabIndex = 17;
            this.label42.Text = "Client";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(3, 38);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(53, 17);
            this.label43.TabIndex = 18;
            this.label43.Text = "Voiture";
            // 
            // contratVoitureComboBox
            // 
            this.contratVoitureComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratVoitureComboBox.DisplayMember = "LibelleVoiture";
            this.contratVoitureComboBox.FormattingEnabled = true;
            this.contratVoitureComboBox.Location = new System.Drawing.Point(154, 41);
            this.contratVoitureComboBox.Name = "contratVoitureComboBox";
            this.contratVoitureComboBox.Size = new System.Drawing.Size(532, 24);
            this.contratVoitureComboBox.TabIndex = 20;
            this.contratVoitureComboBox.ValueMember = "Immatriculation";
            // 
            // contratClientComboBox
            // 
            this.contratClientComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratClientComboBox.DisplayMember = "NomComplet";
            this.contratClientComboBox.FormattingEnabled = true;
            this.contratClientComboBox.Location = new System.Drawing.Point(154, 3);
            this.contratClientComboBox.Name = "contratClientComboBox";
            this.contratClientComboBox.Size = new System.Drawing.Size(532, 24);
            this.contratClientComboBox.TabIndex = 19;
            this.contratClientComboBox.ValueMember = "IdClient";
            // 
            // tabVoitures
            // 
            this.tabVoitures.Controls.Add(this.splitContainer2);
            this.tabVoitures.Location = new System.Drawing.Point(4, 25);
            this.tabVoitures.Name = "tabVoitures";
            this.tabVoitures.Size = new System.Drawing.Size(1277, 598);
            this.tabVoitures.TabIndex = 2;
            this.tabVoitures.Text = "Gestion Voitures";
            this.tabVoitures.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.voitureListGrid);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.supprimerVoitureButton);
            this.splitContainer2.Panel2.Controls.Add(this.modifierVoitureButton);
            this.splitContainer2.Panel2.Controls.Add(this.ajouterVoitureButton);
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1277, 598);
            this.splitContainer2.SplitterDistance = 549;
            this.splitContainer2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liste des Voitures";
            // 
            // voitureListGrid
            // 
            this.voitureListGrid.AllowUserToAddRows = false;
            this.voitureListGrid.AllowUserToDeleteRows = false;
            this.voitureListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voitureListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voitureListGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.voitureListGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.voitureListGrid.Location = new System.Drawing.Point(5, 172);
            this.voitureListGrid.MultiSelect = false;
            this.voitureListGrid.Name = "voitureListGrid";
            this.voitureListGrid.ReadOnly = true;
            this.voitureListGrid.RowTemplate.Height = 24;
            this.voitureListGrid.Size = new System.Drawing.Size(535, 421);
            this.voitureListGrid.TabIndex = 1;
            this.voitureListGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.voitureListGrid_DataBindingComplete);
            this.voitureListGrid.SelectionChanged += new System.EventHandler(this.voitureListGrid_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rechercherVoitureButton);
            this.groupBox2.Controls.Add(this.rechercherVoitureText);
            this.groupBox2.Controls.Add(this.voitureRechercheCritere);
            this.groupBox2.Location = new System.Drawing.Point(5, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 119);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche Voitures";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Rechercher par: ";
            // 
            // rechercherVoitureButton
            // 
            this.rechercherVoitureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rechercherVoitureButton.Location = new System.Drawing.Point(419, 21);
            this.rechercherVoitureButton.Name = "rechercherVoitureButton";
            this.rechercherVoitureButton.Size = new System.Drawing.Size(110, 23);
            this.rechercherVoitureButton.TabIndex = 2;
            this.rechercherVoitureButton.Text = "Rechercher";
            this.rechercherVoitureButton.UseVisualStyleBackColor = true;
            this.rechercherVoitureButton.Click += new System.EventHandler(this.rechercherVoitureButton_Click);
            // 
            // rechercherVoitureText
            // 
            this.rechercherVoitureText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rechercherVoitureText.Location = new System.Drawing.Point(20, 22);
            this.rechercherVoitureText.Name = "rechercherVoitureText";
            this.rechercherVoitureText.Size = new System.Drawing.Size(395, 22);
            this.rechercherVoitureText.TabIndex = 1;
            // 
            // voitureRechercheCritere
            // 
            this.voitureRechercheCritere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voitureRechercheCritere.FormattingEnabled = true;
            this.voitureRechercheCritere.Items.AddRange(new object[] {
            "Immatriculation",
            "Modèle",
            "Marque",
            "Carburant"});
            this.voitureRechercheCritere.Location = new System.Drawing.Point(20, 76);
            this.voitureRechercheCritere.MultiColumn = true;
            this.voitureRechercheCritere.Name = "voitureRechercheCritere";
            this.voitureRechercheCritere.Size = new System.Drawing.Size(509, 38);
            this.voitureRechercheCritere.TabIndex = 0;
            // 
            // supprimerVoitureButton
            // 
            this.supprimerVoitureButton.Enabled = false;
            this.supprimerVoitureButton.Location = new System.Drawing.Point(462, 238);
            this.supprimerVoitureButton.Name = "supprimerVoitureButton";
            this.supprimerVoitureButton.Size = new System.Drawing.Size(143, 23);
            this.supprimerVoitureButton.TabIndex = 4;
            this.supprimerVoitureButton.Text = "Supprmier Voiture";
            this.supprimerVoitureButton.UseVisualStyleBackColor = true;
            this.supprimerVoitureButton.Click += new System.EventHandler(this.supprimerVoitureButton_Click);
            // 
            // modifierVoitureButton
            // 
            this.modifierVoitureButton.Enabled = false;
            this.modifierVoitureButton.Location = new System.Drawing.Point(316, 238);
            this.modifierVoitureButton.Name = "modifierVoitureButton";
            this.modifierVoitureButton.Size = new System.Drawing.Size(143, 23);
            this.modifierVoitureButton.TabIndex = 3;
            this.modifierVoitureButton.Text = "Modifier Voiture";
            this.modifierVoitureButton.UseVisualStyleBackColor = true;
            this.modifierVoitureButton.Click += new System.EventHandler(this.modifierVoitureButton_Click);
            // 
            // ajouterVoitureButton
            // 
            this.ajouterVoitureButton.Location = new System.Drawing.Point(172, 238);
            this.ajouterVoitureButton.Name = "ajouterVoitureButton";
            this.ajouterVoitureButton.Size = new System.Drawing.Size(143, 23);
            this.ajouterVoitureButton.TabIndex = 2;
            this.ajouterVoitureButton.Text = "Ajouter Voiture";
            this.ajouterVoitureButton.UseVisualStyleBackColor = true;
            this.ajouterVoitureButton.Click += new System.EventHandler(this.ajouterVoitureButton_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(14, 268);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(693, 325);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.photoVoiture);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image de la voiture";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // photoVoiture
            // 
            this.photoVoiture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoVoiture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoVoiture.Location = new System.Drawing.Point(2, 4);
            this.photoVoiture.Name = "photoVoiture";
            this.photoVoiture.Size = new System.Drawing.Size(677, 286);
            this.photoVoiture.TabIndex = 0;
            this.photoVoiture.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(685, 296);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Autre";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.9403F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.0597F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.immatriculationText, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.marqueVoitureText, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.modeleVoitureText, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.kilometrageVoitureText, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.couleurText, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.carburantVoitureText, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.voitureDateFutureCT, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(693, 221);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.changerPhotoVoitureButton);
            this.panel1.Controls.Add(this.photoVoitureText);
            this.panel1.Location = new System.Drawing.Point(155, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 26);
            this.panel1.TabIndex = 15;
            // 
            // changerPhotoVoitureButton
            // 
            this.changerPhotoVoitureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changerPhotoVoitureButton.Location = new System.Drawing.Point(450, 1);
            this.changerPhotoVoitureButton.Name = "changerPhotoVoitureButton";
            this.changerPhotoVoitureButton.Size = new System.Drawing.Size(82, 23);
            this.changerPhotoVoitureButton.TabIndex = 1;
            this.changerPhotoVoitureButton.Text = "Ouvrir";
            this.changerPhotoVoitureButton.UseVisualStyleBackColor = true;
            this.changerPhotoVoitureButton.Click += new System.EventHandler(this.changerPhotoVoitureButton_Click);
            // 
            // photoVoitureText
            // 
            this.photoVoitureText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoVoitureText.Location = new System.Drawing.Point(0, 1);
            this.photoVoitureText.Name = "photoVoitureText";
            this.photoVoitureText.ReadOnly = true;
            this.photoVoitureText.Size = new System.Drawing.Size(447, 22);
            this.photoVoitureText.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Immatriculation: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Marque Voiture: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Modèle Voiture";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Kilometrage:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Couleur: ";
            // 
            // immatriculationText
            // 
            this.immatriculationText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.immatriculationText.Location = new System.Drawing.Point(155, 3);
            this.immatriculationText.Name = "immatriculationText";
            this.immatriculationText.Size = new System.Drawing.Size(535, 22);
            this.immatriculationText.TabIndex = 5;
            // 
            // marqueVoitureText
            // 
            this.marqueVoitureText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marqueVoitureText.Location = new System.Drawing.Point(155, 30);
            this.marqueVoitureText.Name = "marqueVoitureText";
            this.marqueVoitureText.Size = new System.Drawing.Size(535, 22);
            this.marqueVoitureText.TabIndex = 6;
            // 
            // modeleVoitureText
            // 
            this.modeleVoitureText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modeleVoitureText.Location = new System.Drawing.Point(155, 57);
            this.modeleVoitureText.Name = "modeleVoitureText";
            this.modeleVoitureText.Size = new System.Drawing.Size(535, 22);
            this.modeleVoitureText.TabIndex = 7;
            // 
            // kilometrageVoitureText
            // 
            this.kilometrageVoitureText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kilometrageVoitureText.Location = new System.Drawing.Point(155, 84);
            this.kilometrageVoitureText.Name = "kilometrageVoitureText";
            this.kilometrageVoitureText.Size = new System.Drawing.Size(535, 22);
            this.kilometrageVoitureText.TabIndex = 8;
            // 
            // couleurText
            // 
            this.couleurText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.couleurText.Location = new System.Drawing.Point(155, 111);
            this.couleurText.Name = "couleurText";
            this.couleurText.Size = new System.Drawing.Size(535, 22);
            this.couleurText.TabIndex = 9;
            // 
            // carburantVoitureText
            // 
            this.carburantVoitureText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carburantVoitureText.Location = new System.Drawing.Point(155, 138);
            this.carburantVoitureText.Name = "carburantVoitureText";
            this.carburantVoitureText.Size = new System.Drawing.Size(535, 22);
            this.carburantVoitureText.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Carburant";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "DateFutureCT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Photo :";
            // 
            // voitureDateFutureCT
            // 
            this.voitureDateFutureCT.Location = new System.Drawing.Point(155, 165);
            this.voitureDateFutureCT.Name = "voitureDateFutureCT";
            this.voitureDateFutureCT.Size = new System.Drawing.Size(535, 22);
            this.voitureDateFutureCT.TabIndex = 16;
            // 
            // tabSalaries
            // 
            this.tabSalaries.Controls.Add(this.supprimerSalarieButton);
            this.tabSalaries.Controls.Add(this.modifierSalarieButton);
            this.tabSalaries.Controls.Add(this.ajouterSalarieButton);
            this.tabSalaries.Controls.Add(this.label17);
            this.tabSalaries.Controls.Add(this.salariesGridList);
            this.tabSalaries.Controls.Add(this.tableLayoutPanel4);
            this.tabSalaries.Controls.Add(this.groupBox3);
            this.tabSalaries.Location = new System.Drawing.Point(4, 25);
            this.tabSalaries.Name = "tabSalaries";
            this.tabSalaries.Size = new System.Drawing.Size(1277, 598);
            this.tabSalaries.TabIndex = 3;
            this.tabSalaries.Text = "Gestion Salariés";
            this.tabSalaries.UseVisualStyleBackColor = true;
            // 
            // supprimerSalarieButton
            // 
            this.supprimerSalarieButton.Enabled = false;
            this.supprimerSalarieButton.Location = new System.Drawing.Point(577, 313);
            this.supprimerSalarieButton.Name = "supprimerSalarieButton";
            this.supprimerSalarieButton.Size = new System.Drawing.Size(143, 23);
            this.supprimerSalarieButton.TabIndex = 9;
            this.supprimerSalarieButton.Text = "Supprimer Salarie";
            this.supprimerSalarieButton.UseVisualStyleBackColor = true;
            this.supprimerSalarieButton.Click += new System.EventHandler(this.supprimerSalarieButton_Click);
            // 
            // modifierSalarieButton
            // 
            this.modifierSalarieButton.Enabled = false;
            this.modifierSalarieButton.Location = new System.Drawing.Point(431, 313);
            this.modifierSalarieButton.Name = "modifierSalarieButton";
            this.modifierSalarieButton.Size = new System.Drawing.Size(143, 23);
            this.modifierSalarieButton.TabIndex = 8;
            this.modifierSalarieButton.Text = "Modifier Salarie";
            this.modifierSalarieButton.UseVisualStyleBackColor = true;
            this.modifierSalarieButton.Click += new System.EventHandler(this.modifierSalarieButton_Click);
            // 
            // ajouterSalarieButton
            // 
            this.ajouterSalarieButton.Location = new System.Drawing.Point(287, 313);
            this.ajouterSalarieButton.Name = "ajouterSalarieButton";
            this.ajouterSalarieButton.Size = new System.Drawing.Size(143, 23);
            this.ajouterSalarieButton.TabIndex = 7;
            this.ajouterSalarieButton.Text = "Ajouter Salarie";
            this.ajouterSalarieButton.UseVisualStyleBackColor = true;
            this.ajouterSalarieButton.Click += new System.EventHandler(this.ajouterSalarieButton_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 346);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 17);
            this.label17.TabIndex = 6;
            this.label17.Text = "Liste des Salaries";
            // 
            // salariesGridList
            // 
            this.salariesGridList.AllowUserToAddRows = false;
            this.salariesGridList.AllowUserToDeleteRows = false;
            this.salariesGridList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salariesGridList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salariesGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salariesGridList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.salariesGridList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salariesGridList.Location = new System.Drawing.Point(6, 366);
            this.salariesGridList.MultiSelect = false;
            this.salariesGridList.Name = "salariesGridList";
            this.salariesGridList.ReadOnly = true;
            this.salariesGridList.RowTemplate.Height = 24;
            this.salariesGridList.Size = new System.Drawing.Size(1266, 232);
            this.salariesGridList.TabIndex = 5;
            this.salariesGridList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.salariesGridList_DataBindingComplete);
            this.salariesGridList.SelectionChanged += new System.EventHandler(this.salariesGridList_SelectionChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.9403F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.0597F));
            this.tableLayoutPanel4.Controls.Add(this.label18, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label21, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label22, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.nomSalarieText, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.prenomSalarieText, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.emailSalarieText, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.motDePasseSalarieText, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.dateEmbaucheSalarieDatePicker, 1, 4);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 140);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1271, 157);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "Nom: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Prenom: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 62);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 17);
            this.label20.TabIndex = 2;
            this.label20.Text = "Email: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 17);
            this.label21.TabIndex = 3;
            this.label21.Text = "Mot de passe:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 17);
            this.label22.TabIndex = 4;
            this.label22.Text = "Date Embauche: ";
            // 
            // nomSalarieText
            // 
            this.nomSalarieText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nomSalarieText.Location = new System.Drawing.Point(281, 3);
            this.nomSalarieText.Name = "nomSalarieText";
            this.nomSalarieText.Size = new System.Drawing.Size(987, 22);
            this.nomSalarieText.TabIndex = 5;
            // 
            // prenomSalarieText
            // 
            this.prenomSalarieText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prenomSalarieText.Location = new System.Drawing.Point(281, 34);
            this.prenomSalarieText.Name = "prenomSalarieText";
            this.prenomSalarieText.Size = new System.Drawing.Size(987, 22);
            this.prenomSalarieText.TabIndex = 6;
            // 
            // emailSalarieText
            // 
            this.emailSalarieText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailSalarieText.Location = new System.Drawing.Point(281, 65);
            this.emailSalarieText.Name = "emailSalarieText";
            this.emailSalarieText.Size = new System.Drawing.Size(987, 22);
            this.emailSalarieText.TabIndex = 7;
            // 
            // motDePasseSalarieText
            // 
            this.motDePasseSalarieText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.motDePasseSalarieText.Location = new System.Drawing.Point(281, 96);
            this.motDePasseSalarieText.Name = "motDePasseSalarieText";
            this.motDePasseSalarieText.PasswordChar = '*';
            this.motDePasseSalarieText.Size = new System.Drawing.Size(987, 22);
            this.motDePasseSalarieText.TabIndex = 8;
            // 
            // dateEmbaucheSalarieDatePicker
            // 
            this.dateEmbaucheSalarieDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEmbaucheSalarieDatePicker.Location = new System.Drawing.Point(281, 127);
            this.dateEmbaucheSalarieDatePicker.Name = "dateEmbaucheSalarieDatePicker";
            this.dateEmbaucheSalarieDatePicker.Size = new System.Drawing.Size(987, 22);
            this.dateEmbaucheSalarieDatePicker.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.rechercheSalarieButton);
            this.groupBox3.Controls.Add(this.rechercheSalarieText);
            this.groupBox3.Controls.Add(this.salarieRechercheCritere);
            this.groupBox3.Location = new System.Drawing.Point(4, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1271, 113);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recherche Salaries";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 17);
            this.label16.TabIndex = 3;
            this.label16.Text = "Rechercher par: ";
            // 
            // rechercheSalarieButton
            // 
            this.rechercheSalarieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rechercheSalarieButton.Location = new System.Drawing.Point(1155, 21);
            this.rechercheSalarieButton.Name = "rechercheSalarieButton";
            this.rechercheSalarieButton.Size = new System.Drawing.Size(110, 23);
            this.rechercheSalarieButton.TabIndex = 2;
            this.rechercheSalarieButton.Text = "Rechercher";
            this.rechercheSalarieButton.UseVisualStyleBackColor = true;
            this.rechercheSalarieButton.Click += new System.EventHandler(this.rechercheSalarieButton_Click);
            // 
            // rechercheSalarieText
            // 
            this.rechercheSalarieText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rechercheSalarieText.Location = new System.Drawing.Point(20, 22);
            this.rechercheSalarieText.Name = "rechercheSalarieText";
            this.rechercheSalarieText.Size = new System.Drawing.Size(1131, 22);
            this.rechercheSalarieText.TabIndex = 1;
            // 
            // salarieRechercheCritere
            // 
            this.salarieRechercheCritere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salarieRechercheCritere.FormattingEnabled = true;
            this.salarieRechercheCritere.Items.AddRange(new object[] {
            "Nom",
            "Prenom",
            "Email",
            "Date Embauche"});
            this.salarieRechercheCritere.Location = new System.Drawing.Point(20, 76);
            this.salarieRechercheCritere.MultiColumn = true;
            this.salarieRechercheCritere.Name = "salarieRechercheCritere";
            this.salarieRechercheCritere.Size = new System.Drawing.Size(1245, 21);
            this.salarieRechercheCritere.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.splitContainer4);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1277, 598);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "Alerte";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.contratAlertListGrid);
            this.splitContainer4.Panel1.Controls.Add(this.label25);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.voitureAlertListGrid);
            this.splitContainer4.Panel2.Controls.Add(this.label44);
            this.splitContainer4.Size = new System.Drawing.Size(1271, 592);
            this.splitContainer4.SplitterDistance = 375;
            this.splitContainer4.TabIndex = 0;
            // 
            // contratAlertListGrid
            // 
            this.contratAlertListGrid.AllowUserToAddRows = false;
            this.contratAlertListGrid.AllowUserToDeleteRows = false;
            this.contratAlertListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contratAlertListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contratAlertListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contratAlertListGrid.Location = new System.Drawing.Point(5, 50);
            this.contratAlertListGrid.Name = "contratAlertListGrid";
            this.contratAlertListGrid.RowTemplate.Height = 24;
            this.contratAlertListGrid.Size = new System.Drawing.Size(1261, 322);
            this.contratAlertListGrid.TabIndex = 1;
            this.contratAlertListGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.contratAlertListGrid_DataBindingComplete);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(182, 17);
            this.label25.TabIndex = 0;
            this.label25.Text = "Liste des contrats en retard";
            // 
            // voitureAlertListGrid
            // 
            this.voitureAlertListGrid.AllowUserToAddRows = false;
            this.voitureAlertListGrid.AllowUserToDeleteRows = false;
            this.voitureAlertListGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voitureAlertListGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.voitureAlertListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voitureAlertListGrid.Location = new System.Drawing.Point(10, 51);
            this.voitureAlertListGrid.Name = "voitureAlertListGrid";
            this.voitureAlertListGrid.RowTemplate.Height = 24;
            this.voitureAlertListGrid.Size = new System.Drawing.Size(1261, 159);
            this.voitureAlertListGrid.TabIndex = 3;
            this.voitureAlertListGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.voitureAlertListGrid_DataBindingComplete);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(10, 17);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(257, 17);
            this.label44.TabIndex = 2;
            this.label44.Text = "Liste des Contrôles technniques à venir";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 627);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainView";
            this.Text = "AutoLocParis Manager";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientListGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DetailClient.ResumeLayout(false);
            this.ClientContratTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientContratListGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabContrats.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contratListGrid)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabVoitures.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voitureListGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoVoiture)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabSalaries.ResumeLayout(false);
            this.tabSalaries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salariesGridList)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contratAlertListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureAlertListGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabContrats;
        private System.Windows.Forms.TabPage tabVoitures;
        private System.Windows.Forms.TabPage tabSalaries;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RechercherClient;
        private System.Windows.Forms.TextBox rechercheClientText;
        private System.Windows.Forms.CheckedListBox clientRechercheCritere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ClientNom;
        private System.Windows.Forms.Label PrenomClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomClientText;
        private System.Windows.Forms.TextBox prenomClientText;
        private System.Windows.Forms.TextBox emailClientText;
        private System.Windows.Forms.TextBox societeClientText;
        private System.Windows.Forms.TextBox codeIbanclientText;
        private System.Windows.Forms.DataGridView clientListGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl DetailClient;
        private System.Windows.Forms.TabPage ClientContratTab;
        private System.Windows.Forms.DataGridView clientContratListGrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SupprimerClientButton;
        private System.Windows.Forms.Button ModifierClientButton;
        private System.Windows.Forms.Button AjouterClientButton;
        private System.Windows.Forms.TextBox clientIdText;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView voitureListGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button rechercherVoitureButton;
        private System.Windows.Forms.TextBox rechercherVoitureText;
        private System.Windows.Forms.CheckedListBox voitureRechercheCritere;
        private System.Windows.Forms.Button supprimerVoitureButton;
        private System.Windows.Forms.Button modifierVoitureButton;
        private System.Windows.Forms.Button ajouterVoitureButton;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox immatriculationText;
        private System.Windows.Forms.TextBox marqueVoitureText;
        private System.Windows.Forms.TextBox modeleVoitureText;
        private System.Windows.Forms.TextBox kilometrageVoitureText;
        private System.Windows.Forms.TextBox couleurText;
        private System.Windows.Forms.PictureBox photoVoiture;
        private System.Windows.Forms.TextBox carburantVoitureText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changerPhotoVoitureButton;
        private System.Windows.Forms.TextBox photoVoitureText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker voitureDateFutureCT;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView salariesGridList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox nomSalarieText;
        private System.Windows.Forms.TextBox prenomSalarieText;
        private System.Windows.Forms.TextBox emailSalarieText;
        private System.Windows.Forms.TextBox motDePasseSalarieText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button rechercheSalarieButton;
        private System.Windows.Forms.TextBox rechercheSalarieText;
        private System.Windows.Forms.CheckedListBox salarieRechercheCritere;
        private System.Windows.Forms.DateTimePicker dateEmbaucheSalarieDatePicker;
        private System.Windows.Forms.Button supprimerSalarieButton;
        private System.Windows.Forms.Button modifierSalarieButton;
        private System.Windows.Forms.Button ajouterSalarieButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView contratListGrid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button recherhceContratButton;
        private System.Windows.Forms.TextBox rechercheContratText;
        private System.Windows.Forms.CheckedListBox contratRechercheCritere;
        private System.Windows.Forms.Button supprimerContratButton;
        private System.Windows.Forms.Button modifierContratButton;
        private System.Windows.Forms.Button ajouterContratButton;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox contratClientNomText;
        private System.Windows.Forms.TextBox contratClientPrenomText;
        private System.Windows.Forms.TextBox contratClientEmailText;
        private System.Windows.Forms.TextBox contratClientSocieteText;
        private System.Windows.Forms.TextBox contratClientIbanText;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox contratVoitureImmatriculationText;
        private System.Windows.Forms.TextBox contratVoitureMarqueText;
        private System.Windows.Forms.TextBox contratVoitureModeleText;
        private System.Windows.Forms.TextBox contratVoitureKilometrageText;
        private System.Windows.Forms.TextBox contratVoitureCouleurText;
        private System.Windows.Forms.TextBox contratVoitureCarburantText;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DateTimePicker contratVoitureDateFutureCtDateTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox contratTarifText;
        private System.Windows.Forms.DateTimePicker contratDateDebutDateTime;
        private System.Windows.Forms.DateTimePicker contratDatefinDateTime;
        private System.Windows.Forms.DateTimePicker contratDateRetourDateTime;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox contratClientComboBox;
        private System.Windows.Forms.ComboBox contratVoitureComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox isReturnedChechBox;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView contratAlertListGrid;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView voitureAlertListGrid;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Timer timer1;
    }
}

