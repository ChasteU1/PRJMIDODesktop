using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.DataObjects
{
    public class Voiture
    {
        public string Immatriculation { get; set; }
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Kilometrage { get; set; }
        public string Couleur { get; set; }
        public string Carburant { get; set; }
        public string Photo { get; set; }
        public DateTime DateFutureCT { get; set; }
    }
}