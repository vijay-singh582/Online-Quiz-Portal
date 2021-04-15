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
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label12.Visible = false;
        GridViewRow gr = GridView1.SelectedRow;
        Label6.Visible = true;
        Label6.Text = gr.Cells[0].Text;
        TextBox2.Text = gr.Cells[1].Text;
        TextBox3.Text = gr.Cells[2].Text;
        TextBox4.Text = gr.Cells[3].Text;
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label12.Visible = false;
        String Query = "select *from Student where Student_ID='" + Label6.Text + "'";
        SqlDataAdapter da1 = new SqlDataAdapter(Query, con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        if (ds1.Tables[0].Rows.Count == 1)
        {
            SqlCommand com = new SqlCommand();
            SqlCommand com1 = new SqlCommand();
            SqlCommand com2 = new SqlCommand();
            com.Connection = con;
            com1.Connection = con;
            com2.Connection = con;
            com1.CommandText = "UPDATE Student Set Student_Name='" + TextBox2.Text + "' Where Student_ID='" + Label6.Text + "'";
            com.CommandText = "UPDATE Student Set S_Password='" + TextBox3.Text + "' Where Student_ID='" + Label6.Text + "'";
            com2.CommandText = "UPDATE Student Set Email_ID='" + TextBox4.Text + "' Where Student_ID='" + Label6.Text + "'";
            string str = "UPDATE Enrollment SET Enrollment.Student_Name=Student.Student_Name FROM Enrollment INNER JOIN Student ON Student.STudent_ID=Enrollment.Student_ID";
            SqlCommand com3 = new SqlCommand(str, con);
            con.Open();
            com1.ExecuteNonQuery();
            com.ExecuteNonQuery();
            com2.ExecuteNonQuery();
            com3.ExecuteNonQuery();
            Label10.Visible = true;
            Label10.Text = "!Succesfully updated!";
            Label10.ForeColor = System.Drawing.Color.Green;
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label6.Text = "";
            GridView1.DataBind();
        }
        else
        {
            Label10.Visible = true;
            Label10.Text = "!Invalid Student!";
            Label10.ForeColor = System.Drawing.Color.Red;
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            Label6.Text = "";
        }
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {
        GridView1.DataBind();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label10.Visible = false;
        GridViewRow gr = GridView2.SelectedRow;
        Label11.Visible = true;
        Label11.Text = gr.Cells[0].Text;
        TextBox6.Text = gr.Cells[1].Text;
        TextBox7.Text = gr.Cells[2].Text;
        TextBox8.Text = gr.Cells[3].Text;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label10.Visible = false;
        String Query = "select *from Teacher where Teacher_ID='" + Label11.Text + "' OR Teacher_Name='" + TextBox6.Text + "'";
        SqlDataAdapter da1 = new SqlDataAdapter(Query, con);
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        if (ds1.Tables[0].Rows.Count == 1)
        {
            SqlCommand com = new SqlCommand();
            SqlCommand com1 = new SqlCommand();
            SqlCommand com2 = new SqlCommand();
            com.Connection = con;
            com1.Connection = con;
            com2.Connection = con;
            com.CommandText = "UPDATE Teacher Set T_Password='" + TextBox7.Text + "' Where Teacher_ID='" + Label11.Text + "'";
            com1.CommandText = "UPDATE Teacher Set Teacher_Name='" + TextBox6.Text + "' Where  Teacher_ID='" + Label11.Text + "'";
            com2.CommandText = "UPDATE Teacher Set Email_ID='" + TextBox8.Text + "' Where  Teacher_ID='" + Label11.Text + "'";
            con.Open();
            com.ExecuteNonQuery();
            com1.ExecuteNonQuery();
            com2.ExecuteNonQuery();
            Label12.Visible = true;
            Label12.Text = "!Succesfully updated!";
            Label12.ForeColor = System.Drawing.Color.Green;
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            Label11.Text = "";
            GridView2.DataBind();
        }
        else
        {
            Label12.Visible = true;
            Label12.Text = "!Invalid Teacher!";
            Label12.ForeColor = System.Drawing.Color.Red;
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            Label11.Text = "";
        }
    }
}