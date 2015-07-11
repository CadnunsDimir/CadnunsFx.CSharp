using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace CadnunsFx.WebDev
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FakeData();
            }
        }

        void FakeData(){
            List<Pessoa> lista = new List<Pessoa>();

            lista.Add(new Pessoa
            {
                Nome = "Tiago",
                Job = "Desenvolvedor Jr."
            });
            lista.Add(new Pessoa
            {
                Nome = "Tiago",
                Job = "Desenvolvedor Jr."
            });
            RptPessoas.DataSource = lista;
            RptPessoas.DataBind();
        }

        class Pessoa
        {
            public string Nome { get; set; }
            public string Job { get; set; }
        }

        protected void RptPessoas_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var Titulo = (HtmlGenericControl)e.Item.FindControl("rptName");
            var Job = (HtmlGenericControl)e.Item.FindControl("rptJob");
            Titulo.InnerText = ((Pessoa)e.Item.DataItem).Nome;
            Job.InnerText = ((Pessoa)e.Item.DataItem).Job;
        }
    }
}