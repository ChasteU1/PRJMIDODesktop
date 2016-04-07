using DataService.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.BSService.BSServiceInt
{
    public interface IContratService :IService<Contrat>
    {
        List<Contrat> getFullContratData();
    }
}
