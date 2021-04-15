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
    SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
    String str;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["c"] == null && Session["deep"] == null)
        {
            Response.Redirect("page1.aspx");
        }

        String query1 = "Select * from Enrollment where Student_ID='" + Session["c"] + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query1, con);
        con.Open();
        DataSet ds = new DataSet();
        da2.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
   
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from  Course where Course_Name='" + DropDownList1.SelectedItem.Value + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds = new DataSet();
        da.Fill(ds);
        Label11.Visible = true;
        Label11.Text = ds.Tables[0].Rows[0][0].ToString();
        SqlDataAdapter da1 = new SqlDataAdapter("Select * from  Teacher where Course_ID='" + Label11.Text + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        if(ds1.Tables[0].Rows.Count==1)
        {
        Label13.Visible = true;
        Label13.Text = ds1.Tables[0].Rows[0][0].ToString();
        }
         else
        {
            Label15.Visible = true;
            Label15.Text = "!this subject is not assigned to any teacher!";
            Label15.ForeColor = System.Drawing.Color.Red;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         string query = "select * from Enrollment where Student_ID = '" + Session["c"] + "' AND Course_ID='" + Label11.Text + "'";
        SqlDataAdapter da = new SqlDataAdapter(query, @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count == 1)
        {
            Label15.Visible = true;
            Label15.Text = "!Already enrolled!";
            Label15.ForeColor=System.Drawing.Color.Red;
        }
        else
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from  Student where Student_ID='" + Session["c"] + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            if (ds2.Tables[0].Rows.Count == 1)
            {
                str = ds2.Tables[0].Rows[0][1].ToString();
                SqlCommand com = new SqlCommand();
                com.CommandText = "Insert into Enrollment values(@a, @b, @c, @d)";
                com.Connection = con;
                com.Parameters.AddWithValue("@a", Label13.Text);
                com.Parameters.AddWithValue("@b", Session["c"]);
                com.Parameters.AddWithValue("@c", str);
                com.Parameters.AddWithValue("@d", Label11.Text);
                com.ExecuteNonQuery();
                Label15.Visible = true;
                Label15.Text = "!Successfully Enrolled!";
                Label15.ForeColor = System.Drawing.Color.Green;
                Label11.Visible = false;
                Label13.Visible = false;
            }
            else
            {
                Label15.Text = "!Invalid Student ID!";
                Label15.ForeColor = System.Drawing.Color.Red;
                Label11.Visible = false;
                Label13.Visible = false;
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}