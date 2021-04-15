using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class page17 : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
            if (Session["c"] != null)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from  Teacher where Teacher_ID='" + Session["c"] + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
                DataSet ds = new DataSet();
                da.Fill(ds);
                Label4.Visible = true;
                Label4.Text = ds.Tables[0].Rows[0][1].ToString();
                Session["tname"] = ds.Tables[0].Rows[0][1].ToString();
            }
            if (Session["c"] == null && Session["deep"] == null)
            {
                Response.Redirect("page1.aspx");
            }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["c"] = null;
        Session["deep"] = null;
        Response.Redirect("page1.aspx");
    }
}
