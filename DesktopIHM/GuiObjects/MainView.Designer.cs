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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.clientRibText = new System.Windows.Forms.TextBox();
            this.clientRibLabel = new System.Windows.Forms.Label();
            this.clientSocieteText = new System.Windows.Forms.TextBox();
            this.clientSocieteLabel = new System.Windows.Forms.Label();
            this.ModifierClient = new System.Windows.Forms.Button();
            this.RechercherClient = new System.Windows.Forms.Button();
            this.AjouterClient = new System.Windows.Forms.Button();
            this.clientEmailText = new System.Windows.Forms.TextBox();
            this.clientEmailLabel = new System.Windows.Forms.Label();
            this.clientPrenomText = new System.Windows.Forms.TextBox();
            this.clientPrenomLabel = new System.Windows.Forms.Label();
            this.clientNomText = new System.Windows.Forms.TextBox();
            this.clientNomLabel = new System.Windows.Forms.Label();
            this.tabContrats = new System.Windows.Forms.TabPage();
            this.rechercheContratGroup = new System.Windows.Forms.GroupBox();
            this.RechercherContrat = new System.Windows.Forms.Button();
            this.prenomRechercheContratLabel = new System.Windows.Forms.Label();
            this.nomRechercheContratLabel = new System.Windows.Forms.Label();
            this.prenomRechercheContratText = new System.Windows.Forms.TextBox();
            this.nomRechercheContratText = new System.Windows.Forms.TextBox();
            this.AjouterContrat = new System.Windows.Forms.Button();
            this.tabVoitures = new System.Windows.Forms.TabPage();
            this.tabSalaries = new System.Windows.Forms.TabPage();
            this.AjouterVoiture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RechercherVoiture = new System.Windows.Forms.Button();
            this.immatriculationRechercheLabel = new System.Windows.Forms.Label();
            this.immatriculationRechercheText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AjouterSalarie = new System.Windows.Forms.Button();
            this.salarieEmailText = new System.Windows.Forms.TextBox();
            this.salarieEmailLabel = new System.Windows.Forms.Label();
            this.salariePrenomText = new System.Windows.Forms.TextBox();
            this.slariePrenomLabel = new System.Windows.Forms.Label();
            this.salarieNomText = new System.Windows.Forms.TextBox();
            this.salarieNomLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.tabContrats.SuspendLayout();
            this.rechercheContratGroup.SuspendLayout();
            this.tabVoitures.SuspendLayout();
            this.tabSalaries.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabClients);
            this.tabControl1.Controls.Add(this.tabContrats);
            this.tabControl1.Controls.Add(this.tabVoitures);
            this.tabControl1.Controls.Add(this.tabSalaries);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2746, 1265);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.clientRibText);
            this.tabClients.Controls.Add(this.clientRibLabel);
            this.tabClients.Controls.Add(this.clientSocieteText);
            this.tabClients.Controls.Add(this.clientSocieteLabel);
            this.tabClients.Controls.Add(this.ModifierClient);
            this.tabClients.Controls.Add(this.RechercherClient);
            this.tabClients.Controls.Add(this.AjouterClient);
            this.tabClients.Controls.Add(this.clientEmailText);
            this.tabClients.Controls.Add(this.clientEmailLabel);
            this.tabClients.Controls.Add(this.clientPrenomText);
            this.tabClients.Controls.Add(this.clientPrenomLabel);
            this.tabClients.Controls.Add(this.clientNomText);
            this.tabClients.Controls.Add(this.clientNomLabel);
            this.tabClients.Location = new System.Drawing.Point(12, 58);
            this.tabClients.Margin = new System.Windows.Forms.Padding(7);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(7);
            this.tabClients.Size = new System.Drawing.Size(2722, 1195);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Gestions Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // clientRibText
            // 
            this.clientRibText.Location = new System.Drawing.Point(1676, 285);
            this.clientRibText.Name = "clientRibText";
            this.clientRibText.Size = new System.Drawing.Size(280, 44);
            this.clientRibText.TabIndex = 12;
            // 
            // clientRibLabel
            // 
            this.clientRibLabel.AutoSize = true;
            this.clientRibLabel.Location = new System.Drawing.Point(1669, 183);
            this.clientRibLabel.Name = "clientRibLabel";
            this.clientRibLabel.Size = new System.Drawing.Size(68, 37);
            this.clientRibLabel.TabIndex = 11;
            this.clientRibLabel.Text = "RIB";
            // 
            // clientSocieteText
            // 
            this.clientSocieteText.Location = new System.Drawing.Point(1303, 285);
            this.clientSocieteText.Name = "clientSocieteText";
            this.clientSocieteText.Size = new System.Drawing.Size(361, 44);
            this.clientSocieteText.TabIndex = 10;
            // 
            // clientSocieteLabel
            // 
            this.clientSocieteLabel.AutoSize = true;
            this.clientSocieteLabel.Location = new System.Drawing.Point(1296, 183);
            this.clientSocieteLabel.Name = "clientSocieteLabel";
            this.clientSocieteLabel.Size = new System.Drawing.Size(122, 37);
            this.clientSocieteLabel.TabIndex = 9;
            this.clientSocieteLabel.Text = "Societe";
            // 
            // ModifierClient
            // 
            this.ModifierClient.Location = new System.Drawing.Point(1485, 40);
            this.ModifierClient.Name = "ModifierClient";
            this.ModifierClient.Size = new System.Drawing.Size(319, 75);
            this.ModifierClient.TabIndex = 8;
            this.ModifierClient.Text = "Modifier Client";
            this.ModifierClient.UseVisualStyleBackColor = true;
            // 
            // RechercherClient
            // 
            this.RechercherClient.Location = new System.Drawing.Point(744, 40);
            this.RechercherClient.Name = "RechercherClient";
            this.RechercherClient.Size = new System.Drawing.Size(304, 75);
            this.RechercherClient.TabIndex = 7;
            this.RechercherClient.Text = "Rechercher Client";
            this.RechercherClient.UseVisualStyleBackColor = true;
            // 
            // AjouterClient
            // 
            this.AjouterClient.Location = new System.Drawing.Point(41, 40);
            this.AjouterClient.Name = "AjouterClient";
            this.AjouterClient.Size = new System.Drawing.Size(377, 75);
            this.AjouterClient.TabIndex = 6;
            this.AjouterClient.Text = "Ajouter Client";
            this.AjouterClient.UseVisualStyleBackColor = true;
            // 
            // clientEmailText
            // 
            this.clientEmailText.Location = new System.Drawing.Point(828, 285);
            this.clientEmailText.Name = "clientEmailText";
            this.clientEmailText.Size = new System.Drawing.Size(459, 44);
            this.clientEmailText.TabIndex = 5;
            // 
            // clientEmailLabel
            // 
            this.clientEmailLabel.AutoSize = true;
            this.clientEmailLabel.Location = new System.Drawing.Point(821, 183);
            this.clientEmailLabel.Name = "clientEmailLabel";
            this.clientEmailLabel.Size = new System.Drawing.Size(97, 37);
            this.clientEmailLabel.TabIndex = 4;
            this.clientEmailLabel.Text = "Email";
            // 
            // clientPrenomText
            // 
            this.clientPrenomText.Location = new System.Drawing.Point(423, 285);
            this.clientPrenomText.Name = "clientPrenomText";
            this.clientPrenomText.Size = new System.Drawing.Size(379, 44);
            this.clientPrenomText.TabIndex = 3;
            // 
            // clientPrenomLabel
            // 
            this.clientPrenomLabel.AutoSize = true;
            this.clientPrenomLabel.Location = new System.Drawing.Point(416, 183);
            this.clientPrenomLabel.Name = "clientPrenomLabel";
            this.clientPrenomLabel.Size = new System.Drawing.Size(129, 37);
            this.clientPrenomLabel.TabIndex = 2;
            this.clientPrenomLabel.Text = "Prenom";
            // 
            // clientNomText
            // 
            this.clientNomText.Location = new System.Drawing.Point(41, 285);
            this.clientNomText.Name = "clientNomText";
            this.clientNomText.Size = new System.Drawing.Size(361, 44);
            this.clientNomText.TabIndex = 1;
            // 
            // clientNomLabel
            // 
            this.clientNomLabel.AutoSize = true;
            this.clientNomLabel.Location = new System.Drawing.Point(34, 183);
            this.clientNomLabel.Name = "clientNomLabel";
            this.clientNomLabel.Size = new System.Drawing.Size(86, 37);
            this.clientNomLabel.TabIndex = 0;
            this.clientNomLabel.Text = "Nom";
            // 
            // tabContrats
            // 
            this.tabContrats.Controls.Add(this.rechercheContratGroup);
            this.tabContrats.Controls.Add(this.AjouterContrat);
            this.tabContrats.Location = new System.Drawing.Point(12, 58);
            this.tabContrats.Margin = new System.Windows.Forms.Padding(7);
            this.tabContrats.Name = "tabContrats";
            this.tabContrats.Padding = new System.Windows.Forms.Padding(7);
            this.tabContrats.Size = new System.Drawing.Size(2722, 1195);
            this.tabContrats.TabIndex = 1;
            this.tabContrats.Text = "Gestion Contrats";
            this.tabContrats.UseVisualStyleBackColor = true;
            // 
            // rechercheContratGroup
            // 
            this.rechercheContratGroup.Controls.Add(this.RechercherContrat);
            this.rechercheContratGroup.Controls.Add(this.prenomRechercheContratLabel);
            this.rechercheContratGroup.Controls.Add(this.nomRechercheContratLabel);
            this.rechercheContratGroup.Controls.Add(this.prenomRechercheContratText);
            this.rechercheContratGroup.Controls.Add(this.nomRechercheContratText);
            this.rechercheContratGroup.Location = new System.Drawing.Point(666, 26);
            this.rechercheContratGroup.Name = "rechercheContratGroup";
            this.rechercheContratGroup.Size = new System.Drawing.Size(1234, 231);
            this.rechercheContratGroup.TabIndex = 5;
            this.rechercheContratGroup.TabStop = false;
            this.rechercheContratGroup.Text = "Rechercher Contrat";
            // 
            // RechercherContrat
            // 
            this.RechercherContrat.Image = ((System.Drawing.Image)(resources.GetObject("RechercherContrat.Image")));
            this.RechercherContrat.Location = new System.Drawing.Point(1037, 78);
            this.RechercherContrat.Name = "RechercherContrat";
            this.RechercherContrat.Size = new System.Drawing.Size(161, 125);
            this.RechercherContrat.TabIndex = 7;
            this.RechercherContrat.UseVisualStyleBackColor = true;
            // 
            // prenomRechercheContratLabel
            // 
            this.prenomRechercheContratLabel.AutoSize = true;
            this.prenomRechercheContratLabel.Location = new System.Drawing.Point(537, 65);
            this.prenomRechercheContratLabel.Name = "prenomRechercheContratLabel";
            this.prenomRechercheContratLabel.Size = new System.Drawing.Size(129, 37);
            this.prenomRechercheContratLabel.TabIndex = 6;
            this.prenomRechercheContratLabel.Text = "Prénom";
            // 
            // nomRechercheContratLabel
            // 
            this.nomRechercheContratLabel.AutoSize = true;
            this.nomRechercheContratLabel.Location = new System.Drawing.Point(20, 65);
            this.nomRechercheContratLabel.Name = "nomRechercheContratLabel";
            this.nomRechercheContratLabel.Size = new System.Drawing.Size(86, 37);
            this.nomRechercheContratLabel.TabIndex = 5;
            this.nomRechercheContratLabel.Text = "Nom";
            // 
            // prenomRechercheContratText
            // 
            this.prenomRechercheContratText.Location = new System.Drawing.Point(544, 119);
            this.prenomRechercheContratText.Name = "prenomRechercheContratText";
            this.prenomRechercheContratText.Size = new System.Drawing.Size(438, 44);
            this.prenomRechercheContratText.TabIndex = 4;
            // 
            // nomRechercheContratText
            // 
            this.nomRechercheContratText.Location = new System.Drawing.Point(27, 119);
            this.nomRechercheContratText.Name = "nomRechercheContratText";
            this.nomRechercheContratText.Size = new System.Drawing.Size(472, 44);
            this.nomRechercheContratText.TabIndex = 3;
            // 
            // AjouterContrat
            // 
            this.AjouterContrat.Location = new System.Drawing.Point(31, 26);
            this.AjouterContrat.Name = "AjouterContrat";
            this.AjouterContrat.Size = new System.Drawing.Size(334, 80);
            this.AjouterContrat.TabIndex = 0;
            this.AjouterContrat.Text = "Nouveau Contrat";
            this.AjouterContrat.UseVisualStyleBackColor = true;
            // 
            // tabVoitures
            // 
            this.tabVoitures.Controls.Add(this.groupBox1);
            this.tabVoitures.Controls.Add(this.AjouterVoiture);
            this.tabVoitures.Location = new System.Drawing.Point(12, 58);
            this.tabVoitures.Margin = new System.Windows.Forms.Padding(7);
            this.tabVoitures.Name = "tabVoitures";
            this.tabVoitures.Size = new System.Drawing.Size(2722, 1195);
            this.tabVoitures.TabIndex = 2;
            this.tabVoitures.Text = "Gestion Voitures";
            this.tabVoitures.UseVisualStyleBackColor = true;
            // 
            // tabSalaries
            // 
            this.tabSalaries.Controls.Add(this.button1);
            this.tabSalaries.Controls.Add(this.AjouterSalarie);
            this.tabSalaries.Controls.Add(this.salarieEmailText);
            this.tabSalaries.Controls.Add(this.salarieEmailLabel);
            this.tabSalaries.Controls.Add(this.salariePrenomText);
            this.tabSalaries.Controls.Add(this.slariePrenomLabel);
            this.tabSalaries.Controls.Add(this.salarieNomText);
            this.tabSalaries.Controls.Add(this.salarieNomLabel);
            this.tabSalaries.Location = new System.Drawing.Point(12, 58);
            this.tabSalaries.Margin = new System.Windows.Forms.Padding(7);
            this.tabSalaries.Name = "tabSalaries";
            this.tabSalaries.Size = new System.Drawing.Size(2722, 1195);
            this.tabSalaries.TabIndex = 3;
            this.tabSalaries.Text = "Gestion Salariés";
            this.tabSalaries.UseVisualStyleBackColor = true;
            // 
            // AjouterVoiture
            // 
            this.AjouterVoiture.Location = new System.Drawing.Point(59, 43);
            this.AjouterVoiture.Name = "AjouterVoiture";
            this.AjouterVoiture.Size = new System.Drawing.Size(334, 80);
            this.AjouterVoiture.TabIndex = 1;
            this.AjouterVoiture.Text = "Ajouter Voiture";
            this.AjouterVoiture.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RechercherVoiture);
            this.groupBox1.Controls.Add(this.immatriculationRechercheLabel);
            this.groupBox1.Controls.Add(this.immatriculationRechercheText);
            this.groupBox1.Location = new System.Drawing.Point(635, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 231);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher Voiture";
            // 
            // RechercherVoiture
            // 
            this.RechercherVoiture.Image = ((System.Drawing.Image)(resources.GetObject("RechercherVoiture.Image")));
            this.RechercherVoiture.Location = new System.Drawing.Point(505, 78);
            this.RechercherVoiture.Name = "RechercherVoiture";
            this.RechercherVoiture.Size = new System.Drawing.Size(161, 125);
            this.RechercherVoiture.TabIndex = 7;
            this.RechercherVoiture.UseVisualStyleBackColor = true;
            // 
            // immatriculationRechercheLabel
            // 
            this.immatriculationRechercheLabel.AutoSize = true;
            this.immatriculationRechercheLabel.Location = new System.Drawing.Point(20, 65);
            this.immatriculationRechercheLabel.Name = "immatriculationRechercheLabel";
            this.immatriculationRechercheLabel.Size = new System.Drawing.Size(235, 37);
            this.immatriculationRechercheLabel.TabIndex = 5;
            this.immatriculationRechercheLabel.Text = "Immatriculation";
            // 
            // immatriculationRechercheText
            // 
            this.immatriculationRechercheText.Location = new System.Drawing.Point(27, 119);
            this.immatriculationRechercheText.Name = "immatriculationRechercheText";
            this.immatriculationRechercheText.Size = new System.Drawing.Size(472, 44);
            this.immatriculationRechercheText.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 75);
            this.button1.TabIndex = 15;
            this.button1.Text = "Rechercher Client";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AjouterSalarie
            // 
            this.AjouterSalarie.Location = new System.Drawing.Point(51, 34);
            this.AjouterSalarie.Name = "AjouterSalarie";
            this.AjouterSalarie.Size = new System.Drawing.Size(377, 75);
            this.AjouterSalarie.TabIndex = 14;
            this.AjouterSalarie.Text = "Ajouter Salarié";
            this.AjouterSalarie.UseVisualStyleBackColor = true;
            // 
            // salarieEmailText
            // 
            this.salarieEmailText.Location = new System.Drawing.Point(838, 279);
            this.salarieEmailText.Name = "salarieEmailText";
            this.salarieEmailText.Size = new System.Drawing.Size(459, 44);
            this.salarieEmailText.TabIndex = 13;
            // 
            // salarieEmailLabel
            // 
            this.salarieEmailLabel.AutoSize = true;
            this.salarieEmailLabel.Location = new System.Drawing.Point(831, 177);
            this.salarieEmailLabel.Name = "salarieEmailLabel";
            this.salarieEmailLabel.Size = new System.Drawing.Size(97, 37);
            this.salarieEmailLabel.TabIndex = 12;
            this.salarieEmailLabel.Text = "Email";
            // 
            // salariePrenomText
            // 
            this.salariePrenomText.Location = new System.Drawing.Point(433, 279);
            this.salariePrenomText.Name = "salariePrenomText";
            this.salariePrenomText.Size = new System.Drawing.Size(379, 44);
            this.salariePrenomText.TabIndex = 11;
            // 
            // slariePrenomLabel
            // 
            this.slariePrenomLabel.AutoSize = true;
            this.slariePrenomLabel.Location = new System.Drawing.Point(426, 177);
            this.slariePrenomLabel.Name = "slariePrenomLabel";
            this.slariePrenomLabel.Size = new System.Drawing.Size(129, 37);
            this.slariePrenomLabel.TabIndex = 10;
            this.slariePrenomLabel.Text = "Prenom";
            // 
            // salarieNomText
            // 
            this.salarieNomText.Location = new System.Drawing.Point(51, 279);
            this.salarieNomText.Name = "salarieNomText";
            this.salarieNomText.Size = new System.Drawing.Size(361, 44);
            this.salarieNomText.TabIndex = 9;
            // 
            // salarieNomLabel
            // 
            this.salarieNomLabel.AutoSize = true;
            this.salarieNomLabel.Location = new System.Drawing.Point(44, 177);
            this.salarieNomLabel.Name = "salarieNomLabel";
            this.salarieNomLabel.Size = new System.Drawing.Size(86, 37);
            this.salarieNomLabel.TabIndex = 8;
            this.salarieNomLabel.Text = "Nom";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2746, 1265);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainView";
            this.Text = "AutoLocParis Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tabClients.PerformLayout();
            this.tabContrats.ResumeLayout(false);
            this.rechercheContratGroup.ResumeLayout(false);
            this.rechercheContratGroup.PerformLayout();
            this.tabVoitures.ResumeLayout(false);
            this.tabSalaries.ResumeLayout(false);
            this.tabSalaries.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabContrats;
        private System.Windows.Forms.TabPage tabVoitures;
        private System.Windows.Forms.TabPage tabSalaries;
        private System.Windows.Forms.TextBox clientEmailText;
        private System.Windows.Forms.Label clientEmailLabel;
        private System.Windows.Forms.TextBox clientPrenomText;
        private System.Windows.Forms.Label clientPrenomLabel;
        private System.Windows.Forms.TextBox clientNomText;
        private System.Windows.Forms.Label clientNomLabel;
        private System.Windows.Forms.Button RechercherClient;
        private System.Windows.Forms.Button AjouterClient;
        private System.Windows.Forms.Button ModifierClient;
        private System.Windows.Forms.TextBox clientSocieteText;
        private System.Windows.Forms.Label clientSocieteLabel;
        private System.Windows.Forms.TextBox clientRibText;
        private System.Windows.Forms.Label clientRibLabel;
        private System.Windows.Forms.Button AjouterContrat;
        private System.Windows.Forms.GroupBox rechercheContratGroup;
        private System.Windows.Forms.Button RechercherContrat;
        private System.Windows.Forms.TextBox prenomRechercheContratText;
        private System.Windows.Forms.TextBox nomRechercheContratText;
        private System.Windows.Forms.Label nomRechercheContratLabel;
        private System.Windows.Forms.Label prenomRechercheContratLabel;
        private System.Windows.Forms.Button AjouterVoiture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RechercherVoiture;
        private System.Windows.Forms.Label immatriculationRechercheLabel;
        private System.Windows.Forms.TextBox immatriculationRechercheText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AjouterSalarie;
        private System.Windows.Forms.TextBox salarieEmailText;
        private System.Windows.Forms.Label salarieEmailLabel;
        private System.Windows.Forms.TextBox salariePrenomText;
        private System.Windows.Forms.Label slariePrenomLabel;
        private System.Windows.Forms.TextBox salarieNomText;
        private System.Windows.Forms.Label salarieNomLabel;
    }
}

