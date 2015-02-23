using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.admin
{
    public partial class user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCombo();
            }
        }

        protected void BindCombo()
        {
            LevelBLL bll = new LevelBLL();
            var list = bll.GetAll();
            ddlLevel.DataSource = list;
            ddlLevel.DataTextField = "Name";
            ddlLevel.DataValueField = "LevelId";
            ddlLevel.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            UserBLL bll = new UserBLL();
            bll.Add(txtName.Text, txtEmail.Text, txtEmail.Text, int.Parse(ddlLevel.SelectedValue));
            //BindLevel();
        }
    }
}