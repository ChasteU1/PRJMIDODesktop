using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.DataObjects
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomSociete { get; set; }
        public string CodeIban { get; set; }
    }
}
