using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Masters
{
    public partial class TemplateAuth : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DAL.User user = (DAL.User)Session["objUser"];
            lbName.Text = user.Name;

            hlBrand.NavigateUrl = "~/customer-list.aspx";
            hlLogout.NavigateUrl = "~/logout.aspx";
        }
    }
}