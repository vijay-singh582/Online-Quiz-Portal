using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["a"] = TextBox1.Text;
        Session["d"] = TextBox2.Text;
        SqlDataAdapter da = new SqlDataAdapter("select * from Admin where Admin_Name = '" + TextBox1.Text + "' and A_Password = '" + TextBox2.Text + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count > 0 )
        {
            Response.Redirect("page5.aspx");
        }
        else
        {
                Label4.Visible = true;
                Label4.Text = "Invalid Admin";
        }
    }
    protected void Button2_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("Page1.aspx");
    }
}