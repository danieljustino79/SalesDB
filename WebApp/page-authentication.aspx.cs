using System;

namespace WebApp
{
    public partial class page_authentication : System.Web.UI.Page
    {
        public page_authentication()
	    {
		    this.Load += new System.EventHandler(this.Page_Load);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((DAL.User)Session["objUser"] == null)
            {
                Response.Redirect("~/login.aspx?error=3");
            }
        }
    }
}