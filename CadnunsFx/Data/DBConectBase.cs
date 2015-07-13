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
        public bool TrueIfExists(string query)
        {
            conexao.Open();
            dbComando.CommandText = query;
            Object valor = dbComando.ExecuteScalar();
            conexao.Close();
            if (valor.Equals(null))
                return false;
            else
                return true;
        }
        /// <summary>
        ///     Retorna um Objeto do tipo DbDataReader(base de todos os DataReader's)
        ///     OBS: A
        ///</summary>
        /// <param name="query">Query SQL de busca no banco</param>
        public DbDataReader GetDataReader(string query){
            DbDataReader reader = null;            
            conexao.Open();
            dbComando.CommandText = query;
            dbComando.Connection = conexao;
            reader = dbComando.ExecuteReader();
            //conexao.Close();
            return reader;
        }
        public void CloseConn()
        {
            conexao.Close();
        }
    }
}
