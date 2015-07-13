using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadnunsFx.WebDev.Ucs
{
    public partial class Login : System.Web.UI.UserControl
    {
        
        private bool _isAuth = false;
        public bool IsAuth
        {
            get { return _isAuth; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAuth_Click(object sender, EventArgs e)
        {
            statusOp.Text = "Função não implementada completamente";
            _isAuth = true;
        }
    }
}