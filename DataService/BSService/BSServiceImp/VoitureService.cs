using DataService.BSService.BSServiceInt;
using DataService.DAOService.DaoServiceInt;
using DataService.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.BSService.BSServiceImp
{
    public class VoitureService : ServiceBase<Voiture>, IVoitureService
    {
        public VoitureService(IDao<Voiture> _dao) : base(_dao)
        {

        }
    }
}
