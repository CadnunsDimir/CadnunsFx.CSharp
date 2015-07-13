using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadnunsFx.Data
{
    public class DBConect_SQLServer : DBConectBase
    {
        public DBConect_SQLServer(String connString)
            : base(new SqlConnection(connString), new SqlCommand())
        {
            
        }
    }
}
