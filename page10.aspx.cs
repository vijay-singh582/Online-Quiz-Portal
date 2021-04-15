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
    String str;
    SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        Label10.Visible = false;
            
            String Query = "select *from Admin where Admin_Name='" + TextBox4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "UPDATE Admin Set Admin_Name='" + TextBox5.Text + "'Where Admin_Name='" + TextBox4.Text + "'";
                con.Open();
                com.ExecuteNonQuery();
                Label11.Visible = true;
                Label11.Text = "!Update Successfully!";
                Label10.ForeColor = System.Drawing.Color.Green;
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
        else
        {
            Label11.Visible = true;
            Label11.Text = "!Invalid Admin!";
            Label10.ForeColor = System.Drawing.Color.Red;
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label11.Visible = false;
        if (Session["d"] != null)
        {
            if (TextBox1.Text.ToString() == Session["d"].ToString())
            {
                String Query = "select *from Admin where A_Password='" + TextBox1.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    com.CommandText = "UPDATE Admin Set A_Password='" + TextBox2.Text + "' where A_Password='" + TextBox1.Text + "'";
                    con.Open();
                    com.ExecuteNonQuery();
                    Label10.Visible = true;
                    Label10.Text = "!Updated Successfully!";
                    Label10.ForeColor = System.Drawing.Color.Green;
                    Session["d"] = TextBox2.Text;
                }
                else
                {
                    Label10.Visible = true;
                    Label10.Text = "!Invalid Current Password!";
                    Label10.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                Label10.Visible = true;
                Label10.Text = "!Invalid Current Password!";
                Label10.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}