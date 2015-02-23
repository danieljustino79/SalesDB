using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class logout : page_authentication
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["objUser"] = null;

            Response.Redirect("~/login.aspx?info=1");
        }
    }
}