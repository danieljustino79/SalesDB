using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Collections;

namespace WebApp.admin
{
    public partial class level : page_authentication
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindLevel();
            }
        }



        protected void BindLevel()
        {
            LevelBLL levelBll = new LevelBLL();
            //List<DAL.Level> list = (List<DAL.Level>)levelBll.GetAll();
            //return list;

            gvwLevel.DataSource = levelBll.GetAll();
            gvwLevel.DataBind();
        }

        //protected void BindGridView(IList list)
        //{
        //    gvwLevel.DataSource = list;
        //    gvwLevel.DataBind();
        //}

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            LevelBLL levelBll = new LevelBLL();
            levelBll.Add(txtName.Text);
            BindLevel();
        }

        protected void gvwLevel_Sorting(object sender, GridViewSortEventArgs e)
        {
        //    ViewState["se"] = e.SortExpression;

        //    if (ViewState["sd"] == null)
        //        ViewState["sd"] = SortDirection.Ascending;

        //    if ((SortDirection)ViewState["sd"] == SortDirection.Ascending)
        //    {
        //        ViewState["sd"] = SortDirection.Descending;
        //    }
        //    else
        //    {
        //        ViewState["sd"] = SortDirection.Ascending;
        //    }

        //    //BindLevel(e.SortExpression);
        }

        //protected void gvwCliente_PageIndexChanging(Object sender, GridViewPageEventArgs e)
        //{
        //    //gvwLevel.PageIndex = e.NewPageIndex;
        //    gvwLevel.Sort(ViewState["se"].ToString(), (SortDirection)ViewState["sd"]);
        //    //BindLevel();
        //}

        //private const string ASCENDING = " ASC";
        //private const string DESCENDING = " DESC";

        //public SortDirection GridViewSortDirection
        //{
        //    get
        //    {
        //        if (ViewState["sortDirection"] == null)
        //            ViewState["sortDirection"] = SortDirection.Ascending;

        //        return (SortDirection)ViewState["sortDirection"];
        //    }
        //    set { ViewState["sortDirection"] = value; }
        //}

        //protected void GridView_Sorting(object sender, GridViewSortEventArgs e)
        //{
        //    string sortExpression = e.SortExpression;

        //    if (GridViewSortDirection == SortDirection.Ascending)
        //    {
        //        GridViewSortDirection = SortDirection.Descending;
        //        SortGridView(sortExpression, DESCENDING);
        //    }
        //    else
        //    {
        //        GridViewSortDirection = SortDirection.Ascending;
        //        SortGridView(sortExpression, ASCENDING);
        //    }

        //}

        //private void SortGridView(string sortExpression, string direction)
        //{
        //    //  You can cache the DataTable for improving performance
        //    DataTable dt = GetData().Tables[0];

        //    DataView dv = new DataView(dt);
        //    dv.Sort = sortExpression + direction;

        //    gvwLevel.DataSource = dv;
        //    gvwLevel.DataBind();
        //}
    }
}