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
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label10.Visible = false;
        SqlDataAdapter da1 = new SqlDataAdapter("Select * from  Course where Course_Name='" + TextBox1.Text + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        if (ds1.Tables[0].Rows.Count == 1)
        {
            Label10.Visible = true;
            Label10.Text = "Course Already exist";
            Label10.ForeColor = System.Drawing.Color.Red;
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
        else
        {
            SqlCommand com = new SqlCommand("Insert Into Course Values( @a,@b,@c)", con);
            SqlDataAdapter da = new SqlDataAdapter("select max(Course_ID) from Course", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds);
            int a = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            a = a + 1;

            com.Parameters.AddWithValue("@a", a);
            com.Parameters.AddWithValue("@b", TextBox1.Text);
            com.Parameters.AddWithValue("@c", TextBox2.Text);
            con.Open();
            com.ExecuteNonQuery();
            Label11.Text = "Course id is'" + a + "'";
            Label10.ForeColor = System.Drawing.Color.Red;
            Label10.Visible = true;
            Label10.Text = "!Sucessfully Added!";
            Label10.ForeColor = System.Drawing.Color.Green;
            TextBox1.Text = "";
            TextBox2.Text = "";
            GridView1.DataBind();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView1.DataBind();
        Label11.Visible = false;
        Label10.Visible = false;
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        GridView1.DataBind();
        Label11.Visible = false;
        Label10.Visible = false;
    }
    protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
    {
        GridView1.DataBind();
        Label11.Visible = false;
        Label10.Visible = false;
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.DataBind();
        Label11.Visible = false;
        Label10.Visible = false;
    }
}