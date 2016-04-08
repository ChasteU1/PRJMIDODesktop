using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.DAOService.DataObjects
{
    /// <summary>
    /// Attribute pour distinguer les champs dont nous voullons pas inclure dans les fichiers XML
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Property ) ]
    class Ignored : System.Attribute
    {
    }
}
