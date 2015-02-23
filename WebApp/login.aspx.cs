using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(Request["error"]) && 
                (Request["error"].Equals("1") || Request["error"].Equals("2")))
                lbAlert.Text = Resource1.errorLoginEmpty;
            else if(!string.IsNullOrEmpty(Request["error"]) && Request["error"].Equals("3"))
                lbAlert.Text = Resource1.errorLoginEmpty;

            if (!string.IsNullOrEmpty(Request["info"]) && Request["info"].Equals("1"))
                lbInfo.Text = Resource1.infoLogoutOk;

            //if (!IsPostBack)
            //{
            //    ////----
            //    UserBLL bll = new UserBLL();
            //    txtName.Text = bll.MD5("admin123");
            //}
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtName.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                Response.Redirect("login.aspx?error=1");
            }



            UserBLL bll = new UserBLL();
            int count = bll.LoginCount(email, password);

            if (count > 0)
            {
                Session["objUser"] = bll.GetObjByLogin(email, password);
                Response.Redirect("customer-list.aspx");
            }
            else
            {
                Response.Redirect("login.aspx?error=2");
            }
        }

    }
}
