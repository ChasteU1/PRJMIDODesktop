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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.eMailText = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.prenomText = new System.Windows.Forms.TextBox();
            this.LabelPrenom = new System.Windows.Forms.Label();
            this.nomText = new System.Windows.Forms.TextBox();
            this.LabelNom = new System.Windows.Forms.Label();
            this.tabContrats = new System.Windows.Forms.TabPage();
            this.tabVoitures = new System.Windows.Forms.TabPage();
            this.tabSalaries = new System.Windows.Forms.TabPage();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.LabelSociete = new System.Windows.Forms.Label();
            this.societeText = new System.Windows.Forms.TextBox();
            this.labelRib = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabClients.SuspendLayout();
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
            this.tabClients.Controls.Add(this.textBox1);
            this.tabClients.Controls.Add(this.labelRib);
            this.tabClients.Controls.Add(this.societeText);
            this.tabClients.Controls.Add(this.LabelSociete);
            this.tabClients.Controls.Add(this.Modifier);
            this.tabClients.Controls.Add(this.Rechercher);
            this.tabClients.Controls.Add(this.Ajouter);
            this.tabClients.Controls.Add(this.eMailText);
            this.tabClients.Controls.Add(this.LabelEmail);
            this.tabClients.Controls.Add(this.prenomText);
            this.tabClients.Controls.Add(this.LabelPrenom);
            this.tabClients.Controls.Add(this.nomText);
            this.tabClients.Controls.Add(this.LabelNom);
            this.tabClients.Location = new System.Drawing.Point(12, 58);
            this.tabClients.Margin = new System.Windows.Forms.Padding(7);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(7);
            this.tabClients.Size = new System.Drawing.Size(2722, 1195);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Gestions Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // eMailText
            // 
            this.eMailText.Location = new System.Drawing.Point(828, 285);
            this.eMailText.Name = "eMailText";
            this.eMailText.Size = new System.Drawing.Size(459, 44);
            this.eMailText.TabIndex = 5;
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(821, 183);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(97, 37);
            this.LabelEmail.TabIndex = 4;
            this.LabelEmail.Text = "Email";
            // 
            // prenomText
            // 
            this.prenomText.Location = new System.Drawing.Point(423, 285);
            this.prenomText.Name = "prenomText";
            this.prenomText.Size = new System.Drawing.Size(379, 44);
            this.prenomText.TabIndex = 3;
            // 
            // LabelPrenom
            // 
            this.LabelPrenom.AutoSize = true;
            this.LabelPrenom.Location = new System.Drawing.Point(416, 183);
            this.LabelPrenom.Name = "LabelPrenom";
            this.LabelPrenom.Size = new System.Drawing.Size(129, 37);
            this.LabelPrenom.TabIndex = 2;
            this.LabelPrenom.Text = "Prenom";
            // 
            // nomText
            // 
            this.nomText.Location = new System.Drawing.Point(41, 285);
            this.nomText.Name = "nomText";
            this.nomText.Size = new System.Drawing.Size(361, 44);
            this.nomText.TabIndex = 1;
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(34, 183);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(86, 37);
            this.LabelNom.TabIndex = 0;
            this.LabelNom.Text = "Nom";
            // 
            // tabContrats
            // 
            this.tabContrats.Location = new System.Drawing.Point(12, 58);
            this.tabContrats.Margin = new System.Windows.Forms.Padding(7);
            this.tabContrats.Name = "tabContrats";
            this.tabContrats.Padding = new System.Windows.Forms.Padding(7);
            this.tabContrats.Size = new System.Drawing.Size(2722, 1195);
            this.tabContrats.TabIndex = 1;
            this.tabContrats.Text = "Gestion Contrats";
            this.tabContrats.UseVisualStyleBackColor = true;
            // 
            // tabVoitures
            // 
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
            this.tabSalaries.Location = new System.Drawing.Point(12, 58);
            this.tabSalaries.Margin = new System.Windows.Forms.Padding(7);
            this.tabSalaries.Name = "tabSalaries";
            this.tabSalaries.Size = new System.Drawing.Size(2722, 1195);
            this.tabSalaries.TabIndex = 3;
            this.tabSalaries.Text = "Gestion Salariés";
            this.tabSalaries.UseVisualStyleBackColor = true;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(41, 40);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(299, 75);
            this.Ajouter.TabIndex = 6;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(744, 40);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(304, 75);
            this.Rechercher.TabIndex = 7;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(1485, 40);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(319, 75);
            this.Modifier.TabIndex = 8;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            // 
            // LabelSociete
            // 
            this.LabelSociete.AutoSize = true;
            this.LabelSociete.Location = new System.Drawing.Point(1296, 183);
            this.LabelSociete.Name = "LabelSociete";
            this.LabelSociete.Size = new System.Drawing.Size(122, 37);
            this.LabelSociete.TabIndex = 9;
            this.LabelSociete.Text = "Societe";
            // 
            // societeText
            // 
            this.societeText.Location = new System.Drawing.Point(1303, 285);
            this.societeText.Name = "societeText";
            this.societeText.Size = new System.Drawing.Size(361, 44);
            this.societeText.TabIndex = 10;
            // 
            // labelRib
            // 
            this.labelRib.AutoSize = true;
            this.labelRib.Location = new System.Drawing.Point(1669, 183);
            this.labelRib.Name = "labelRib";
            this.labelRib.Size = new System.Drawing.Size(68, 37);
            this.labelRib.TabIndex = 11;
            this.labelRib.Text = "RIB";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1676, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 44);
            this.textBox1.TabIndex = 12;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabContrats;
        private System.Windows.Forms.TabPage tabVoitures;
        private System.Windows.Forms.TabPage tabSalaries;
        private System.Windows.Forms.TextBox eMailText;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox prenomText;
        private System.Windows.Forms.Label LabelPrenom;
        private System.Windows.Forms.TextBox nomText;
        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.TextBox societeText;
        private System.Windows.Forms.Label LabelSociete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelRib;
    }
}

