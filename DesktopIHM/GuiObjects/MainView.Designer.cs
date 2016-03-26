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
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1156, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabClients
            // 
            this.tabClients.Location = new System.Drawing.Point(4, 25);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(1148, 518);
            this.tabClients.TabIndex = 0;
            this.tabClients.Text = "Gestions Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // tabContrats
            // 
            this.tabContrats.Location = new System.Drawing.Point(4, 25);
            this.tabContrats.Name = "tabContrats";
            this.tabContrats.Padding = new System.Windows.Forms.Padding(3);
            this.tabContrats.Size = new System.Drawing.Size(1149, 518);
            this.tabContrats.TabIndex = 1;
            this.tabContrats.Text = "Gestion Contrats";
            this.tabContrats.UseVisualStyleBackColor = true;
            // 
            // tabVoitures
            // 
            this.tabVoitures.Location = new System.Drawing.Point(4, 25);
            this.tabVoitures.Name = "tabVoitures";
            this.tabVoitures.Size = new System.Drawing.Size(1149, 518);
            this.tabVoitures.TabIndex = 2;
            this.tabVoitures.Text = "Gestion Voitures";
            this.tabVoitures.UseVisualStyleBackColor = true;
            // 
            // tabSalaries
            // 
            this.tabSalaries.Location = new System.Drawing.Point(4, 25);
            this.tabSalaries.Name = "tabSalaries";
            this.tabSalaries.Size = new System.Drawing.Size(1149, 518);
            this.tabSalaries.TabIndex = 3;
            this.tabSalaries.Text = "Gestion Salariés";
            this.tabSalaries.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 547);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainView";
            this.Text = "AutoLocParis Manager";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabContrats;
        private System.Windows.Forms.TabPage tabVoitures;
        private System.Windows.Forms.TabPage tabSalaries;
    }
}

