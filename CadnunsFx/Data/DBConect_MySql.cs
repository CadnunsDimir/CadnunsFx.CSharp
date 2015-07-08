//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

//namespace CadnunsFx.Data.MySql
//{
//    public class DBConect_MySql : DBConectBase
//    {
//        public DBConect_MySql(String ip, String login, String senha, String db) :
//            base(new MySqlConnection("Database='" + db + "';Data Source='" + ip + "';User Id='" + login + "';Password='" + senha + "';pooling=false"), new MySqlCommand())
//        {

//        }
//        public DBConect_MySql(String ip, String login, String senha, String db,int porta) :
//            base(new MySqlConnection("Database='" + db + "';Data Source='" + ip + "';User Id='" + login + "';Password='" + senha + "'; Port=" + porta + ";pooling=false"), new MySqlCommand())
//        {
           
//        }
//    }
//}
