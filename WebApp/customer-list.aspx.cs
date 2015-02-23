using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp
{
    public partial class customer_list : page_authentication
    {
        private DAL.User user;

        protected void Page_Load(object sender, EventArgs e)
        {
            user = (DAL.User)Session["objUser"];

            DisplayFilterAdmin();

            if (!IsPostBack)
            {
                BindComboCity();
                BindComboRegion();

                BindCustomer();
            }
        }

        protected void DisplayFilterAdmin()
        {
            if (user.LevelId == 1)
                divSeller.Visible = true;
        }

        protected void BindComboCity()
        {
            CityBLL bll = new CityBLL();
            var list = bll.GetAll();
            ddlCity.DataSource = list;
            ddlCity.DataTextField = "Name";
            ddlCity.DataValueField = "CityId";
            ddlCity.DataBind();
        }

        protected void BindComboRegion()
        {
            RegionBLL bll = new RegionBLL();
            var list = bll.GetAll();
            ddlRegion.DataSource = list;
            ddlRegion.DataTextField = "Name";
            ddlRegion.DataValueField = "RegionId";
            ddlRegion.DataBind();
        }

        protected void BindCustomer()
        {
            CustomerBLL bll = new CustomerBLL();

            gvwCustomer.DataSource = bll.GetVW();
            gvwCustomer.DataBind();
        }
    }
}