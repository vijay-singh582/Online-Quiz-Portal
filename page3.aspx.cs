using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class page3 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da10 = new SqlDataAdapter("Select * from Student Where Email_ID='"+TextBox4.Text+"' ", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds10 = new DataSet();
        da10.Fill(ds10);
        if (ds10.Tables[0].Rows.Count > 0)
        {
            Label8.Visible = true;
            Label8.Text = "!Already Student Registered!";
            Label8.ForeColor = System.Drawing.Color.Red;
            TextBox1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
        else
        {
            Label8.Visible = false;
            Session["b"] = TextBox1.Text + " " + TextBox3.Text;
            SqlCommand com = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter("Select  max(Student_ID)from Student ", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds);
            int a = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            a = a + 1;
            com.Connection = con;
            com.CommandText = "Insert INTO Student Values(@a,@b,@c,@d)";
            com.Parameters.AddWithValue("@a", a);
            com.Parameters.AddWithValue("@b", TextBox1.Text + " " + TextBox3.Text);
            com.Parameters.AddWithValue("@c", TextBox2.Text);
            com.Parameters.AddWithValue("@d", TextBox4.Text);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            Label8.Visible = true;
            Label8.Text = "! Successfully Registered and your ID is'" + a + "'!";
            Label8.ForeColor = System.Drawing.Color.Green;
            TextBox1.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }
    }
    protected void Button2_Command(object sender, CommandEventArgs e)
    {
        Response.Redirect("Page1.aspx");
    }
}