using System.Drawing;
namespace DesktopIHM
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.authentifierButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.erreurAuthentifiaction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(241, 159);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(216, 22);
            this.login.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(241, 187);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(216, 22);
            this.password.TabIndex = 3;
            this.password.PasswordChar = '*';
            // 
            // authentifierButton
            // 
            this.authentifierButton.Location = new System.Drawing.Point(241, 215);
            this.authentifierButton.Name = "authentifierButton";
            this.authentifierButton.Size = new System.Drawing.Size(102, 28);
            this.authentifierButton.TabIndex = 4;
            this.authentifierButton.Text = "S\'authentifier";
            this.authentifierButton.UseVisualStyleBackColor = true;
            this.authentifierButton.Click += new System.EventHandler(this.authentifierButton_Click);
            // 
            // annulerButton
            // 
            this.annulerButton.Location = new System.Drawing.Point(355, 215);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(102, 28);
            this.annulerButton.TabIndex = 5;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(0, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 100);
            this.panel2.TabIndex = 7;
            // 
            // erreurAuthentifiaction
            // 
            this.erreurAuthentifiaction.AutoSize = true;
            this.erreurAuthentifiaction.ForeColor = System.Drawing.Color.Crimson;
            this.erreurAuthentifiaction.Location = new System.Drawing.Point(50, 136);
            this.erreurAuthentifiaction.Name = "erreurAuthentifiaction";
            this.erreurAuthentifiaction.Size = new System.Drawing.Size(0, 17);
            this.erreurAuthentifiaction.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(605, 268);
            this.Controls.Add(this.erreurAuthentifiaction);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.annulerButton);
            this.Controls.Add(this.authentifierButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Authentifiez-vous";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button authentifierButton;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label erreurAuthentifiaction;
    }
}