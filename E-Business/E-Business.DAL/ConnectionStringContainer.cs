using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.DAL
{
    public class ConnectionStringContainer
    {
        internal static string ConnectionString
        {
            get { return "Server=.;Database=E-BusinessDB;User Id=SA;Password = 123;MultipleActiveResultSets=true;"; }
        }
    }
}
