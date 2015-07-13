using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CadnunsFx.Data;

namespace CadnunsFx.WebDev.Ucs
{
    public partial class SqlControl : System.Web.UI.UserControl
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string cmdVerifica { get; set; }
        public string cmdExecuta { get; set; }
        public SqlControlType Type { get; set; }
        public GridView gvPainel;
        public SqlControl()
        {

        }
        public SqlControl(ref GridView gvPainel)
        {
            this.gvPainel = gvPainel;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            title.InnerText = Title;
            description.InnerText = Description;            
        }

        public enum SqlControlType
        {
            Default
        }
        protected void btnVerifRegistro_Click(object sender, EventArgs e)
        {
            
            if (gvPainel != null)
            {
                DBConect_SQLServer conexao = new DBConect_SQLServer(App_Strings.ConnString);
                gvPainel.DataSource = conexao.GetDataReader("Select * from cadfx_usuarios");
                gvPainel.DataBind();//injeta conteudo na lista
                gvPainel.Dispose();//limpa conteudo recebido
                conexao.CloseConn();//fecha conexao com o banco
                btnExecAction.Enabled = true;
            }

        }
        //criar método que verifica se um texto é número

        private static bool TrueIfNumber(string texto)
        {
            try{                
                int.Parse(texto);
                return true;
            }catch{
                return false;
            }
        }

        protected void btnExecAction_Click(object sender, EventArgs e)
        {
            if (TrueIfNumber(tboxCodCeden.Text))
            {
                statusOp.Text = "Número convertido";
            }
            else
            {
                statusOp.Text = "Erro ao converter número";
            }
            btnExecAction.Enabled = false;
        }
    }
}