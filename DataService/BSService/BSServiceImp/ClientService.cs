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
    public class ClientService : ServiceBase<Client> , IClientService
    {
        public ClientService(IDao<Client> _dao) : base(_dao)
        {

        }
    }
}
