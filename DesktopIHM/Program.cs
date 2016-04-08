using DataService.BSService.BSServiceImp;
using DataService.BSService.BSServiceInt;
using DataService.DAOService.DaoServiceImp;
using DataService.DAOService.DaoServiceInt;
using DataService.DataObjects;
using GuiObjects.DesktopIHM;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopIHM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            InitUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }

        // Init unityContainer pour le IOC
        public static IUnityContainer myContainer;
        private static void InitUnityContainer()
        {
            myContainer = new UnityContainer();

            myContainer.RegisterType<Salarie>();
            myContainer.RegisterType<Voiture>();
            myContainer.RegisterType<Client>();
            myContainer.RegisterType<ISalarieDao, SalarieDao>();
            myContainer.RegisterType<IVoitureDao, VoitureDao>();
            myContainer.RegisterType<IClientDao, ClientDao>();
            myContainer.RegisterType<IContratDao, ContratDao>();
            myContainer.RegisterType<IDao<Salarie>, SalarieDao>();
            myContainer.RegisterType<IDao<Voiture>, VoitureDao>();
            myContainer.RegisterType<IDao<Client>, ClientDao>();
            myContainer.RegisterType<IDao<Contrat>, ContratDao>();
            myContainer.RegisterType<ISalarieService, SalarieService>();
            myContainer.RegisterType<IVoitureService, VoitureService>();
            myContainer.RegisterType<IClientService, ClientService>();
            myContainer.RegisterType<IContratService, ContratService>();
        }
    }
}
