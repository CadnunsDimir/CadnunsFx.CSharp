using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace CadnunsFx.Data.LocalDB
{
    public class DBConect_LocalDB : DBConectBase
    {
        
        public DBConect_LocalDB(String connString)
            : base(new SqlCeConnection(connString), new SqlCeCommand())
        {
            
        }
    }
}
