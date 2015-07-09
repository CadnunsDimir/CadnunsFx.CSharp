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
        public string cmdVerifica { get; set; }
        public string cmdExecuta { get; set; }
        public SqlControlType Type { get; set; }
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
            btnExecAction.Enabled = true;
        }

        protected void btnExecAction_Click(object sender, EventArgs e)
        {
            btnExecAction.Enabled = false;
        }
    }
}