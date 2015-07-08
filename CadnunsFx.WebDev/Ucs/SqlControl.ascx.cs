using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadnunsFx.WebDev.Ucs
{
    public partial class SqlControl : System.Web.UI.UserControl
    {
        public string Title { get; set; }
        public string Description { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            title.InnerText = Title;
            description.InnerText = Description; 
                //@"Usado para criar template padronizado para comandos SQL" : Description;
        }
    }
}