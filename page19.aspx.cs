using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
     SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        String query1 = "Select * from Enrollment where Teacher_ID='" +Session["c"]+ "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query1, con);
        con.Open();
        DataSet ds = new DataSet();
        da2.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
     
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}