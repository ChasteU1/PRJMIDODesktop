using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopIHM.GuiPresenters;
using GuiObjects.DesktopIHM;

namespace DesktopIHM
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginFormPresenter();
        }
        #region databinding
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            login.DataBindings.Add ("Text", _presenter, "Email");
            password.DataBindings.Add("Text", _presenter, "MotDePasse");
            erreurAuthentifiaction.DataBindings.Add("Text", _presenter, "ErreurAuthentification"); 
            // dataGridView1.DataBindings.Add("DataSource", _presenter, "AllClients", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private LoginFormPresenter _presenter;
        #endregion
        

        private void authentifierButton_Click(object sender, EventArgs e)
        {
            bool result = _presenter.LogIn();
            if (result)
            {
                this.Visible = false;
                MainView mainView =new MainView();
                mainView.ShowDialog(); 
                this.Close();
            }
            else
            {
              
            }
           
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
;