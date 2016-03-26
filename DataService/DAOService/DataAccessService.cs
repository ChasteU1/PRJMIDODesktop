using DataService.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.DAOService
{
    /// <summary>
    /// Operations simples de lecture et d'écriture XML
    /// </summary>
    public static class DataAccessService
    {
        static DataAccessService()
        {
            _salarieDataSet = new DataSet();
            _salarieDataSet.ReadXml("Salaries.xml");
            _clientDataSet = new DataSet();
            _clientDataSet.ReadXml("Clients.xml");
            _voitureDataSet = new DataSet();
            _voitureDataSet.ReadXml("Voitures.xml");

        }

        private static DataSet _salarieDataSet;
        private static DataSet _clientDataSet;
        private static DataSet _voitureDataSet;

        public static IList<Salarie> SelectAllSalaries()
        {
            var result = from DataRow r in _salarieDataSet.Tables["Salarie"].Rows
                         select new Salarie() { Nom = r["Nom"].ToString(), Prenom = r["Prenom"].ToString(),
                             MotDePasse = r["MotDePasse"].ToString(), Email= r["Email"].ToString(),
                         DateEmbauche = DateTime.Parse(r["Email"].ToString())};
            return result.ToList();
        }

        public static void InsertSalarie(Salarie salarie)
        {
            var newRow = _salarieDataSet.Tables["Salarie"].NewRow();
            newRow["Nom"] = salarie.Nom;
            newRow["Prenom"] = salarie.Prenom;
            newRow["Email"] = salarie.Email;
            newRow["MotDePasse"] = salarie.MotDePasse;
            newRow["DateEmbauche"] = salarie.DateEmbauche.ToString("yyyy-MM-dd");
            _salarieDataSet.Tables["Salarie"].Rows.Add(newRow);
            _salarieDataSet.Tables["Salarie"].WriteXml("Salaries.xml");
        }

        public static void UpdateSalarie(Salarie salarie)
        {
            var updateRow = (from DataRow r in _salarieDataSet.Tables["Salarie"].Rows
                             where salarie.Email == r["Email"].ToString()
                             select r).First();
            updateRow["Email"] = salarie.Email;
            updateRow["MotDePasse"] = salarie.MotDePasse;
            updateRow["DateEmbauche"] = salarie.DateEmbauche.ToString("yyyy-MM-dd");
            updateRow["Nom"] = salarie.Nom;
            updateRow["Prenom"] = salarie.Prenom;
        }

        public static IList<Client> SelectAllClients()
        {
            throw new NotImplementedException();
        }

        public static void InsertClient(Client client)
        {
            throw new NotImplementedException();
        }

        public static void UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }

        public static IList<Voiture> SelectAllVoitures()
        {
            throw new NotImplementedException();
        }
        
        public static void InsertVoiture(Voiture voiture)
        {

        }

        public static void UpdateVoiture(Voiture voiture)
        {
            throw new NotImplementedException();
        }
        
        
    }
}
