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
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label14.Visible = false;
        SqlDataAdapter da10 = new SqlDataAdapter("Select * from Student Where Email_ID='" + TextBox3.Text + "' ", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds10 = new DataSet();
        da10.Fill(ds10);
        if (ds10.Tables[0].Rows.Count > 0)
        {
            Label13.Visible = true;
            Label13.Text = "!Already Student Registered!";
            Label13.ForeColor = System.Drawing.Color.Red;
            TextBox1.Text = "";
            TextBox3.Text = "";
        }
        else
        {
            SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            SqlDataAdapter da1 = new SqlDataAdapter("Select max(Student_ID) from Student", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
            DataSet ds = new DataSet();
            da1.Fill(ds);
            int a = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            a = a + 1;
            com.Connection = con;
            com.CommandText = "Insert INTO Student Values(@a,@b,@c,@d)";
            com.Parameters.AddWithValue("@a", a);
            com.Parameters.AddWithValue("@b", TextBox1.Text);
            com.Parameters.AddWithValue("@c", TextBox2.Text);
            com.Parameters.AddWithValue("@d", TextBox3.Text);
            con.Open();
            com.ExecuteNonQuery();

            Label13.Visible = true;
            Label13.Text = "!Successfully Added your id is '" + a + "'!";
            Label13.ForeColor = System.Drawing.Color.Green;
            TextBox1.Text = "";
            TextBox3.Text = "";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label13.Visible =false;
        SqlDataAdapter da10 = new SqlDataAdapter("Select * from Teacher Where Email_ID='" + TextBox6.Text + "' ", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds10 = new DataSet();
        da10.Fill(ds10);
        if (ds10.Tables[0].Rows.Count > 0)
        {
            Label14.Visible = true;
            Label14.Text = "!Already Teacher Registered!";
            Label14.ForeColor = System.Drawing.Color.Red;
            TextBox4.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }
        else
        {
            SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            SqlCommand com1 = new SqlCommand();
            com1.Connection = con;
            SqlDataAdapter da1 = new SqlDataAdapter("Select max(Teacher_ID) from Teacher", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
            DataSet ds = new DataSet();
            da1.Fill(ds);
            int a = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
            a = a + 1;
            com.Connection = con;
            com.CommandText = "Insert INTO Teacher Values(@a,@b,@c,@d,@e)";
            com.Parameters.AddWithValue("@a", a);
            com.Parameters.AddWithValue("@b", TextBox4.Text);
            com.Parameters.AddWithValue("@c", TextBox5.Text);
            com.Parameters.AddWithValue("@d", TextBox6.Text);
            com.Parameters.AddWithValue("@e", TextBox7.Text);
            con.Open();
            com.ExecuteNonQuery();
            Label14.Visible = true;
            Label14.Text = "!Successfully Added your id is '" + a + "'!";
            Label14.ForeColor = System.Drawing.Color.Green;
            TextBox4.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
        }
    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }
}