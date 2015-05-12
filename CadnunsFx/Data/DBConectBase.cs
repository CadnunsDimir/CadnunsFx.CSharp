using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace CadnunsFx.Data
{
    public abstract class DBConectBase
    {
        DbConnection conexao;       
        DbCommand dbComando;
        public DBConectBase(DbConnection conexao, DbCommand dbComando)            
        {
            this.conexao = conexao;
            this.dbComando = dbComando;
        }

        public void comando(string query)
        {
            conexao.Open();
            dbComando.CommandText = query;
            dbComando.Connection = conexao;
            dbComando.ExecuteNonQuery();
            conexao.Close();
        }

        public object retornaValoresUnicos(string query)
        {
            conexao.Open();
            dbComando.CommandText = query;
            dbComando.Connection = conexao;
            Object valor = dbComando.ExecuteScalar();
            conexao.Close();
            return valor;
        }

    }
}
