using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow gr = GridView1.SelectedRow;
        TextBox11.Text = gr.Cells[4].Text;
        TextBox7.Text = gr.Cells[5].Text;
        TextBox8.Text = gr.Cells[6].Text;
        TextBox9.Text = gr.Cells[7].Text;
        TextBox10.Text = gr.Cells[8].Text;
        TextBox12.Text = gr.Cells[9].Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
        if (Session["c"] != null)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Teacher where Teacher_ID='" + Session["c"] + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
            DataSet ds = new DataSet();
            da.Fill(ds);
            int a = Convert.ToInt16(ds.Tables[0].Rows[0][4]);
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Course where Course_ID='" + a + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            String vk = ds2.Tables[0].Rows[0][1].ToString();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Coursequiz where Quiz_ID='" + TextBox1.Text + "' AND Course_Name='" + vk + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            if (ds1.Tables[0].Rows.Count == 1)
            {
                Label10.Visible = false;
                Button3.Visible = true;
                GridView1.Visible = true;
            }
            else
            {
                Label10.Visible = true;
                Label10.Text = "You are not teacher of selected  course";
                Label10.ForeColor = System.Drawing.Color.Red;
                Button3.Visible = false;
                GridView1.Visible = false;
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand();
        SqlCommand com1 = new SqlCommand();
        SqlCommand com2 = new SqlCommand();
        SqlCommand com3 = new SqlCommand();
        SqlCommand com4 = new SqlCommand();
        SqlCommand com5 = new SqlCommand();
        com.Connection = con;
        com1.Connection = con;
        com2.Connection = con;
        com3.Connection = con;
        com4.Connection = con;
        com5.Connection = con;
       com.CommandText = "UPDATE Question Set Question='" + TextBox11.Text + "' Where Quiz_ID='" + TextBox1.Text + "' ";
       com1.CommandText = "UPDATE Question Set OptionA='" + TextBox7.Text + "' Where Quiz_ID='" + TextBox1.Text + "' ";
       com2.CommandText = "UPDATE Question Set  OptionB='" + TextBox8.Text + "' Where Quiz_ID='" + TextBox1.Text + "' ";
       com3.CommandText = "UPDATE Question Set  OptionC='" + TextBox9.Text + "' Where Quiz_ID='" + TextBox1.Text + "' ";
       com4.CommandText = "UPDATE Question Set  OptionD='" + TextBox10.Text + "' Where Quiz_ID='" + TextBox1.Text + "'";
       com5.CommandText = "UPDATE Question Set  Correct='" + TextBox12.Text + "' Where Quiz_ID='" + TextBox1.Text + "' ";
        con.Open();
       com.ExecuteNonQuery();
       com1.ExecuteNonQuery();
       com2.ExecuteNonQuery();
       com3.ExecuteNonQuery();
       com4.ExecuteNonQuery();
       com5.ExecuteNonQuery();
       con.Close();
       GridView1.DataBind();
        TextBox11.Text="";
        TextBox12.Text="";
        TextBox10.Text="";
        TextBox7.Text="";
        TextBox8.Text="";
        TextBox9.Text = "";
    }
}