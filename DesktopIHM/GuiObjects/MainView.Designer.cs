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
            this.tabContrats = new System.Windows.Forms.TabPage();
            this.tabVoitures = new System.Windows.Forms.TabPage();
            this.tabSalaries = new System.Windows.Forms.TabPage();
            this.Nom = new System.Windows.Forms.Label();
            this.NomText = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AdresseMail = new System.Windows.Forms.Label();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2746, 1265);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.textBox2);
            this.tabClients.Controls.Add(this.AdresseMail);
            this.tabClients.Controls.Add(this.textBox1);
            this.tabClients.Controls.Add(this.Prenom);
            this.tabClients.Controls.Add(this.NomText);
            this.tabClients.Controls.Add(this.Nom);
            this.tabClients.Location = new System.Drawing.Point(12, 58);
            this.tabClients.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabClients.Size = new System.Drawing.Size(2722, 1195);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Gestions Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // tabContrats
            // 
            this.tabContrats.Location = new System.Drawing.Point(12, 58);
            this.tabContrats.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabContrats.Name = "tabContrats";
            this.tabContrats.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabContrats.Size = new System.Drawing.Size(2722, 1195);
            this.tabContrats.TabIndex = 1;
            this.tabContrats.Text = "Gestion Contrats";
            this.tabContrats.UseVisualStyleBackColor = true;
            // 
            // tabVoitures
            // 
            this.tabVoitures.Location = new System.Drawing.Point(12, 58);
            this.tabVoitures.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabVoitures.Name = "tabVoitures";
            this.tabVoitures.Size = new System.Drawing.Size(2722, 1195);
            this.tabVoitures.TabIndex = 2;
            this.tabVoitures.Text = "Gestion Voitures";
            this.tabVoitures.UseVisualStyleBackColor = true;
            // 
            // tabSalaries
            // 
            this.tabSalaries.Location = new System.Drawing.Point(12, 58);
            this.tabSalaries.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabSalaries.Name = "tabSalaries";
            this.tabSalaries.Size = new System.Drawing.Size(2722, 1195);
            this.tabSalaries.TabIndex = 3;
            this.tabSalaries.Text = "Gestion Salariés";
            this.tabSalaries.UseVisualStyleBackColor = true;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(180, 66);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(86, 37);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // NomText
            // 
            this.NomText.Location = new System.Drawing.Point(354, 59);
            this.NomText.Name = "NomText";
            this.NomText.Size = new System.Drawing.Size(100, 44);
            this.NomText.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(769, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 44);
            this.textBox1.TabIndex = 3;
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(595, 73);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(129, 37);
            this.Prenom.TabIndex = 2;
            this.Prenom.Text = "Prenom";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1296, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(459, 44);
            this.textBox2.TabIndex = 5;
            // 
            // AdresseMail
            // 
            this.AdresseMail.AutoSize = true;
            this.AdresseMail.Location = new System.Drawing.Point(1042, 73);
            this.AdresseMail.Name = "AdresseMail";
            this.AdresseMail.Size = new System.Drawing.Size(192, 37);
            this.AdresseMail.TabIndex = 4;
            this.AdresseMail.Text = "AdresseMail";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2746, 1265);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label AdresseMail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.TextBox NomText;
        private System.Windows.Forms.Label Nom;
    }
}

