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
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label11.Visible = false;
        if (TextBox1.Text == Session["deep"].ToString())
        {
            String Query = "select *from Teacher where Teacher_ID='" + Session["c"] + "' AND T_Password='" + TextBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "UPDATE Teacher Set T_Password='" + TextBox2.Text + "' where Teacher_ID='" + Session["c"] + "'";
                con.Open();
                com.ExecuteNonQuery();
                Label10.Visible = true;
                Label10.Text = "!Updated Successfully!";
                Label10.ForeColor = System.Drawing.Color.Green;
                Session["deep"] = TextBox2.Text;
            }
        }
        else
        {
            Label10.Visible = true;
            Label10.Text = "!Invalid Current Password!";
            Label10.ForeColor = System.Drawing.Color.Red;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label10.Visible = false;
        if (TextBox4.Text == Session["tname"].ToString())
        {
            String Query = "select *from Teacher where Teacher_ID='" + Session["c"] + "' AND Teacher_Name='" + TextBox4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "UPDATE Teacher Set Teacher_Name='" + TextBox5.Text + "'Where Teacher_ID='" + Session["c"] + "'";
                con.Open();
                com.ExecuteNonQuery();
                Label11.Visible = true;
                Label11.Text = "!Update Successfully!";
                Label11.ForeColor = System.Drawing.Color.Green;
                Session["tname"] = TextBox5.Text;
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
        }
        else
        {
            Label11.Visible = true;
            Label11.Text = "!Invalid Teacher Name!";
            Label11.ForeColor = System.Drawing.Color.Red;
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
    }
}