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
    SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            String str1 = "Select * from Course";
            SqlDataAdapter da2 = new SqlDataAdapter(str1, con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            if (ds2.Tables[0].Rows.Count > 0)
            {
                DropDownList1.DataSource = ds2;
                DropDownList1.DataTextField = "Course_Name";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("select Course"));
                DropDownList1.SelectedIndex = 0;

            }
        }
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Course where Course_Name='" + DropDownList1.SelectedItem.Value + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
        DataSet ds = new DataSet();
        da.Fill(ds);
        String str=ds.Tables[0].Rows[0][0].ToString();
        ViewState["id"] = str;
        SqlDataAdapter da1 = new SqlDataAdapter("Select * from Teacher where Course_ID='" +str+ "' And Teacher_ID='"+Session["c"]+"'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
        DataSet ds1 = new DataSet();
        da1.Fill(ds1);
        if (ds1.Tables[0].Rows.Count == 1)
        {
            ViewState["str"] = DropDownList1.SelectedItem.Value;
            Label7.Visible = true;
            TextBox1.Visible = true;
            Label19.Visible = true;
            Label21.Visible = true;
            Label19.Text = "Course ID is " + str;
            Label20.Visible = false;
        }
        else
        {
            Label19.Visible = false;
            Label20.Visible = true;
            Label20.Text = "!you Not a Teacher of selected Course!";
            Label7.Visible = false;
            Label21.Visible = false;
            TextBox1.Visible = false;
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Label22.Visible = false;
        ViewState["text"] = TextBox1.Text;
        SqlDataAdapter da = new SqlDataAdapter("Select * from Coursequiz where Course_Name='" + ViewState["str"] + "' AND Quiz_ID='" + TextBox1.Text + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
        DataSet ds = new DataSet();
        da.Fill(ds);
        if (ds.Tables[0].Rows.Count == 1)
        {
            Label20.Visible = true;
            Label20.Text = "!set unique quizID!";
        }
        else
        {
            DropDownList1.Visible = false;
            TextBox1.Visible = false;
            Label6.Text = "Course is '" + ViewState["str"] + "'";
            Label21.Text = "Quiz id is '" + ViewState["text"]+ "'";
            Label7.Visible = false;
            Button3.Visible = false;
            Label20.Visible = false;
            Label9.Visible = true;
            Label10.Visible = true;
            Label14.Visible = true;
            Label15.Visible = true;
            Label16.Visible = true;
            Label17.Visible = true;
            Label18.Visible = true;
            TextBox2.Visible = true;
            TextBox7.Visible = true;
            TextBox8.Visible = true;
            TextBox9.Visible = true;
            TextBox10.Visible = true;
            TextBox11.Visible = true;
            Button1.Visible = true;
            Button2.Visible = true;
            
            SqlDataAdapter da2 = new SqlDataAdapter("Select  MAX(Question_ID)from Question ", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            int a = Convert.ToInt16(ds2.Tables[0].Rows[0][0]);
            a = a + 1;
            ViewState["sq"] = a; 
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select  max(Question_ID)from Question ", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds = new DataSet();
        da.Fill(ds);
        int a = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
        a = a + 1;
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "Insert INTO Question Values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";
        com.Parameters.AddWithValue("@a", a);
        com.Parameters.AddWithValue("@b", ViewState["id"].ToString());
        com.Parameters.AddWithValue("@c", ViewState["text"].ToString());
        com.Parameters.AddWithValue("@d", TextBox2.Text);
        com.Parameters.AddWithValue("@e", TextBox7.Text);
        com.Parameters.AddWithValue("@f", TextBox8.Text);
        com.Parameters.AddWithValue("@g", TextBox9.Text);
        com.Parameters.AddWithValue("@h", TextBox10.Text);
        com.Parameters.AddWithValue("@i", TextBox11.Text);
        com.Parameters.AddWithValue("@j", "Nil");
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        TextBox2.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select  max(Question_ID)from Question ", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds = new DataSet();
        da.Fill(ds);
        int a = Convert.ToInt16(ds.Tables[0].Rows[0][0]);
        a = a + 1;
        ViewState["lq"] = a;
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "Insert INTO Question Values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)";
        com.Parameters.AddWithValue("@a", a);
        com.Parameters.AddWithValue("@b", ViewState["id"].ToString());
        com.Parameters.AddWithValue("@c", ViewState["text"].ToString());
        com.Parameters.AddWithValue("@d", TextBox2.Text);
        com.Parameters.AddWithValue("@e", TextBox7.Text);
        com.Parameters.AddWithValue("@f", TextBox8.Text);
        com.Parameters.AddWithValue("@g", TextBox9.Text);
        com.Parameters.AddWithValue("@h", TextBox10.Text);
        com.Parameters.AddWithValue("@i", TextBox11.Text);
        com.Parameters.AddWithValue("@j", "Nil");
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        DropDownList1.Visible = true;
        TextBox1.Visible = true;
        Label21.Text = "*Try to set unique quiz id";
        Label6.Text = "Select Course";
        Label7.Visible = true;
        Button3.Visible = true;
        Label20.Visible = false;
        Label9.Visible = false;
        Label10.Visible = false;
        Label14.Visible = false;
        Label15.Visible = false;
        Label16.Visible = false;
        Label17.Visible = false;
        Label18.Visible = false;
        TextBox2.Visible = false;
        TextBox7.Visible = false;
        TextBox8.Visible = false;
        TextBox9.Visible = false;
        TextBox10.Visible = false;
        TextBox11.Visible = false;
        Button1.Visible = false;
        Button2.Visible = false;
        SqlCommand com1 = new SqlCommand();
        com1.Connection = con;
        com1.CommandText = "Insert INTO Coursequiz Values(@k,@vk,@ak,@jk)";
        com1.Parameters.AddWithValue("@k",ViewState["str"].ToString());
        com1.Parameters.AddWithValue("@vk", ViewState["text"].ToString());
        com1.Parameters.AddWithValue("@ak", ViewState["lq"].ToString());
        com1.Parameters.AddWithValue("@jk", ViewState["sq"].ToString());
        con.Open();
        com1.ExecuteNonQuery();
        con.Close();
        Label22.Visible = true;
        Label22.Text =  ViewState["text"]+" is successfully created";
        Label22.ForeColor = System.Drawing.Color.Green;
    }
}