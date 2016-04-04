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

namespace GuiObjects.DesktopIHM
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitUnityContainer();
            InitializeComponent();
            //DaoBase<Salarie> dao = new SalarieDao();
            //dao.SelectAll();
            IService<Salarie> SalarieService = myContainer.Resolve<IService<Salarie>>();
            var lst = SalarieService.SelectAll();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
