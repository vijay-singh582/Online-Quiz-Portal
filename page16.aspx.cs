using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["c"] == null && Session["deep"] == null)
        {
            Response.Redirect("page1.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label11.Visible = false;
        if (TextBox1.Text == Session["deep"].ToString())
        {
            String Query = "select *from Student where Student_ID='" + Session["c"] + "'  AND S_Password='" + TextBox1.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "UPDATE Student Set S_Password='" + TextBox2.Text + "' where Student_ID='" + Session["c"] + "'";
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
        if (TextBox4.Text == Session["name"].ToString())
        {
            String Query = "select *from Student where Student_ID='" + Session["c"] + "' AND Student_Name='" + TextBox4.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "UPDATE Student Set Student_Name='" + TextBox5.Text + "'Where Student_ID='" + Session["c"] + "'";
                con.Open();
                com.ExecuteNonQuery();
                string str = "UPDATE Enrollment SET Enrollment.Student_Name=Student.Student_Name FROM Enrollment INNER JOIN Student ON Student.STudent_ID=Enrollment.Student_ID";
                SqlCommand com1 = new SqlCommand(str, con);
                com1.ExecuteNonQuery();
                Label11.Visible = true;
                Label11.Text = "!Update Successfully!";
                Label11.ForeColor = System.Drawing.Color.Green;
                Session["name"] = TextBox5.Text;
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
        }
        else
        {
            Label11.Visible = true;
            Label11.Text = "!Invalid Student Name!";
            Label11.ForeColor = System.Drawing.Color.Red;
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
        
      
    }
}