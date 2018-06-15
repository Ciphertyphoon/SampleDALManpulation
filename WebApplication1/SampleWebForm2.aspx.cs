using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DALObj dal = new DALObj();

            DataSet ds = dal.BindGrid();
            gvCustomers.DataSource = ds.Tables[0];
            gvCustomers.DataBind();


        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            DALObj dal = new DALObj();

            DataSet ds = dal.BindGrid();
            gvEmployees.DataSource = ds.Tables[1];
            gvEmployees.DataBind();

        }


    }
}