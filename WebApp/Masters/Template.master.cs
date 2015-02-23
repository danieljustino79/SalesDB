using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Masters
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            hlBrand.NavigateUrl = "~/default.aspx";
            hlLogin.NavigateUrl = "~/login.aspx";
        }
    }
}