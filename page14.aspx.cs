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
    SqlConnection con = new SqlConnection(@"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
    String str, query, query1;
    int a, d, c = 0, z;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["c"] == null && Session["deep"] == null)
        {
            Response.Redirect("page1.aspx");
        }
        if (!IsPostBack)
        {
            Button2.Visible = false;
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
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    private void view()
    {

        d = Convert.ToInt16(ViewState["a"]);
        a = Convert.ToInt16(ViewState["a"]) + 1;
        ViewState["a"] = a;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
   
                        if (RadioButton1.Checked == true)
                        {
                            view();
                            if (d == Convert.ToInt16(ViewState["h"]))
                            {
                                SqlCommand com = new SqlCommand();
                                com.Connection = con;
                                com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton1.Text + "' where Question_ID='" + d + "' ";
                                con.Open();
                                com.ExecuteNonQuery();
                                con.Close();
                                quiz();
                                Button4.Visible = true;
                            }
                            else
                            {
                                SqlCommand com = new SqlCommand();
                                com.Connection = con;
                                com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton1.Text + "' where Question_ID='" + d + "' ";
                                con.Open();
                                com.ExecuteNonQuery();
                                con.Close();
                                quiz();
                            }
                        }
                        else
                        {
                            if (RadioButton2.Checked == true)
                            {
                                view();
                                if (d == Convert.ToInt16(ViewState["h"]))
                                {
                                    SqlCommand com = new SqlCommand();
                                    com.Connection = con;
                                    com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton2.Text + "' where Question_ID='" + d + "' ";
                                    con.Open();
                                    com.ExecuteNonQuery();
                                    con.Close();
                                    quiz();
                                    Button4.Visible = true;
                                }
                                else
                                {
                                    SqlCommand com = new SqlCommand();
                                    com.Connection = con;
                                    com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton2.Text + "' where Question_ID='" + d + "' ";
                                    con.Open();
                                    com.ExecuteNonQuery();
                                    con.Close();
                                    quiz();
                                }
                            }

                            else
                            {
                                if (RadioButton3.Checked == true)
                                {
                                    view();
                                    if (d == Convert.ToInt16(ViewState["h"]))
                                    {
                                        SqlCommand com = new SqlCommand();
                                        com.Connection = con;
                                        com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton3.Text + "' where Question_ID='" + d + "' ";
                                        con.Open();
                                        com.ExecuteNonQuery();
                                        con.Close();
                                        quiz();
                                        Button4.Visible = true;
                                    }
                                    else
                                    {
                                        SqlCommand com = new SqlCommand();
                                        com.Connection = con;
                                        com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton3.Text + "' where Question_ID='" + d + "' ";
                                        con.Open();
                                        com.ExecuteNonQuery();
                                        con.Close();
                                        quiz();
                                    }
                                }
                                else
                                {
                                    if (RadioButton4.Checked == true)
                                    {
                                        view();
                                        if (d == Convert.ToInt16(ViewState["h"]))
                                        {
                                            SqlCommand com = new SqlCommand();
                                            com.Connection = con;
                                            com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton4.Text + "' where Question_ID='" + d + "' ";
                                            con.Open();
                                            com.ExecuteNonQuery();
                                            con.Close();
                                            quiz();
                                            Button4.Visible = true;
                                        }
                                        else
                                        {
                                            SqlCommand com = new SqlCommand();
                                            com.Connection = con;
                                            com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton4.Text + "' where Question_ID='" + d + "' ";
                                            con.Open();
                                            com.ExecuteNonQuery();
                                            con.Close();
                                            quiz();
                                        }
                                    }
                                    else
                                    {
                                        SqlCommand com = new SqlCommand();
                                        com.Connection = con;
                                        com.CommandText = "UPDATE Question Set Select_Correct='Nil' where Question_ID='" + d + "' ";
                                        con.Open();
                                        com.ExecuteNonQuery();
                                        con.Close();
                                        view();
                                        quiz();
                                        Button4.Visible = true;
                                    }
                                }
                            }
                        }
                    }
      

    private void quiz()
    {
        String g = "select * from Coursequiz where Quiz_Id='" +ViewState["b"] + "'";
        SqlDataAdapter da = new SqlDataAdapter(g, @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
        DataSet ds = new DataSet();
        da.Fill(ds);
        String f = ds.Tables[0].Rows[0][2].ToString();
        String i = ds.Tables[0].Rows[0][3].ToString();
        if (f == a.ToString())
        {
            RadioButton1.AutoPostBack = true;
            RadioButton2.AutoPostBack = true;
            RadioButton3.AutoPostBack = true;
            RadioButton4.AutoPostBack = true;
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select * from Question where Question_ID='" + a + "' AND Quiz_ID='" + ViewState["b"]+ "'";
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            TextBox2.Text = dr["Question"].ToString();
            RadioButton1.Text = dr["OptionA"].ToString();
            RadioButton2.Text = dr["OptionB"].ToString();
            RadioButton3.Text = dr["OptionC"].ToString();
            RadioButton4.Text = dr["OptionD"].ToString();
             String ac = dr["Select_Correct"].ToString();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            if (ac == RadioButton1.Text)
            {
                RadioButton1.Checked = true;
            }
            else
            {
                if (ac == RadioButton2.Text)
                {
                    RadioButton2.Checked = true;
                }
                else
                {
                    if (ac == RadioButton3.Text)
                    {
                        RadioButton3.Checked = true;
                    }
                    else
                    {
                        if (ac == RadioButton4.Text)
                        {
                            RadioButton4.Checked = true;
                        }
                        else
                        {
                            RadioButton1.Checked = false;
                            RadioButton2.Checked = false;
                            RadioButton3.Checked = false;
                            RadioButton4.Checked = false;
                        }
                    }
                }
            }
            dr.Close();
            Button3.Visible = true;
            Button2.Visible = false;
        }
        else
        {
            RadioButton1.AutoPostBack = false;
            RadioButton2.AutoPostBack = false;
            RadioButton3.AutoPostBack = false;
            RadioButton4.AutoPostBack = false;
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select * from Question where Question_ID='" + a + "' AND Quiz_ID='" + DropDownList2.SelectedItem.Value + "'";
            SqlDataReader dr = com.ExecuteReader();
            dr.Read();
            TextBox2.Text = dr["Question"].ToString();
            RadioButton1.Text = dr["OptionA"].ToString();
            RadioButton2.Text = dr["OptionB"].ToString();
            RadioButton3.Text = dr["OptionC"].ToString();
            RadioButton4.Text = dr["OptionD"].ToString();
            String ab = dr["Select_Correct"].ToString();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            if (ab == RadioButton1.Text)
            {
                RadioButton1.Checked = true;
            }
            else
            {
                if (ab == RadioButton2.Text)
                {
                    RadioButton2.Checked = true;
                }
                else
                {
                    if (ab == RadioButton3.Text)
                    {
                        RadioButton3.Checked = true;
                    }
                    else
                    {
                        if (ab == RadioButton4.Text)
                        {
                            RadioButton4.Checked = true;
                        }
                        else
                        {
                            RadioButton1.Checked = false;
                            RadioButton2.Checked = false;
                            RadioButton3.Checked = false;
                            RadioButton4.Checked = false;
                        }
                    }
                }
            }
        }
        if (i == a.ToString())
        {
            Button4.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        GridView1.Visible = false;
        Label17.Visible = false;
            if (DropDownList1.SelectedIndex > 0 && DropDownList2.SelectedIndex > 0)
            {
                String g = "select * from Coursequiz where Quiz_Id='" + ViewState["b"] + "'";
                SqlDataAdapter da = new SqlDataAdapter(g, @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
                DataSet ds = new DataSet();
                da.Fill(ds);
                a = Convert.ToInt16(ds.Tables[0].Rows[0][3]);
                z = Convert.ToInt16(ds.Tables[0].Rows[0][2]);
                ViewState["vk"] = a;
                ViewState["zk"] = z;
                ViewState["a"] = a;

                String dh = "select * from Result where Quiz_Id='" +ViewState["b"] + "' AND Student_ID='" + Session["c"] + "'";
                SqlDataAdapter da5 = new SqlDataAdapter(dh, @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
                DataSet ds5 = new DataSet();
                da5.Fill(ds5);
                if (ds5.Tables[0].Rows.Count == 1)
                {
                    Label15.Visible = true;
                    Label15.Text = "Already performed by you";
                    Label15.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    Label15.Visible = false;
                    Label16.Visible = false;
                    Label7.Text = "Course is '" + DropDownList1.SelectedItem.Value + "' ";
                    Label8.Text = "Quiz id is '" + DropDownList2.SelectedItem.Value + "' "; ;
                    DropDownList1.Visible = false;
                    DropDownList2.Visible = false;
                    Button1.Visible = false;
                    con.Open();
                    String pr = "select * from Coursequiz where Quiz_Id='" + DropDownList2.SelectedItem.Value + "'";
                    SqlDataAdapter da2 = new SqlDataAdapter(pr, @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);
                    String f = ds2.Tables[0].Rows[0][3].ToString();
                    ViewState["h"] = f;
                    String vk = ds2.Tables[0].Rows[0][2].ToString();
                    if (f != vk)
                    {
                        Button2.Visible = true;
                        RadioButton1.AutoPostBack = false;
                        RadioButton2.AutoPostBack = false;
                        RadioButton3.AutoPostBack = false;
                        RadioButton4.AutoPostBack = false;
                        SqlCommand com = new SqlCommand();
                        com.Connection = con;
                        com.CommandText = "select * from Question where Question_ID='" + f + "' AND Quiz_ID='" + DropDownList2.SelectedItem.Value + "'";
                        SqlDataReader dr = com.ExecuteReader();
                        dr.Read();
                        TextBox2.Text = dr["Question"].ToString();
                        RadioButton1.Text = dr["OptionA"].ToString();
                        RadioButton2.Text = dr["OptionB"].ToString();
                        RadioButton3.Text = dr["OptionC"].ToString();
                        RadioButton4.Text = dr["OptionD"].ToString();
                        Button3.Visible = false;
                        Button2.Visible = true;
                    }
                    else
                    {
                        RadioButton1.AutoPostBack = true;
                        RadioButton2.AutoPostBack = true;
                        RadioButton3.AutoPostBack = true;
                        RadioButton4.AutoPostBack = true;
                        SqlCommand com = new SqlCommand();
                        com.Connection = con;
                        com.CommandText = "select * from Question where Question_ID='" + f + "' AND Quiz_ID='" + DropDownList2.SelectedItem.Value + "'";
                        SqlDataReader dr = com.ExecuteReader();
                        dr.Read();
                        TextBox2.Text = dr["Question"].ToString();
                        RadioButton1.Text = dr["OptionA"].ToString();
                        RadioButton2.Text = dr["OptionB"].ToString();
                        RadioButton3.Text = dr["OptionC"].ToString();
                        RadioButton4.Text = dr["OptionD"].ToString();

                        dr.Close();
                        Button3.Visible = true;
                        Button2.Visible = false;
                    }
                }
            }
            else
            {
                Label16.Visible = false;
                Label15.Visible = true;
                Label15.Text = "!Select Course or Quiz!";
                Label15.ForeColor = System.Drawing.Color.Red;
            }
        }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridView1.Visible = false;
        if (Session["c"] != null)
        {
                if (DropDownList1.SelectedIndex > 0)
                {
                    SqlDataAdapter da = new SqlDataAdapter("Select * from  Course where Course_Name='" + DropDownList1.SelectedItem.Value + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    str = ds.Tables[0].Rows[0][0].ToString();
                    ViewState["courseid"] = str;
                    query = "select * from Enrollment where Student_ID = '" + Session["c"] + "' AND Course_ID='" + str + "'";
                    SqlDataAdapter da1 = new SqlDataAdapter(query, @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    if (ds1.Tables[0].Rows.Count == 0)
                    {
                        Label16.Visible = false;
                        Label15.Visible = true;
                        Label15.Text = "!Not enrolled!";
                        Label15.ForeColor = System.Drawing.Color.Red;
                        Label17.Visible = false;
                    }
                    else
                    {
                        Label15.Visible = false;
                        Label16.Visible = false;
                        Label17.Visible = false;
                        query1 = "Select * from Coursequiz where Course_Name='" + DropDownList1.SelectedItem.Value + "'";
                        SqlDataAdapter da2 = new SqlDataAdapter(query1, con);
                        DataSet ds2 = new DataSet();
                        da2.Fill(ds2);
                        if (ds2.Tables[0].Rows.Count > 0)
                        {
                            DropDownList2.DataSource = ds2;
                            DropDownList2.DataTextField = "Quiz_ID";
                            DropDownList2.DataBind();
                            DropDownList2.Items.Insert(0, new ListItem("select" + DropDownList1.SelectedItem.Value + "Quiz"));
                            DropDownList2.SelectedIndex = 0;
                        }
                    }
                }
            }
        }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex > 0)
        {
            Label15.Visible = false;
            Label16.Visible = false;
            Label17.Visible = false;
            ViewState["b"] = DropDownList2.SelectedItem.Value;
            GridView1.Visible = false;
        }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton1.Text + "' where Question_ID='" +ViewState["a"]+ "' ";
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        Label17.Visible = false;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton2.Text + "' where Question_ID='" + ViewState["a"] + "' ";
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        Label17.Visible = false;
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton3.Text + "' where Question_ID='" + ViewState["a"] + "' ";
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        Label17.Visible = false;
    }
    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "UPDATE Question Set Select_Correct='" + RadioButton4.Text + "' where Question_ID='" + ViewState["a"] + "' ";
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        Label17.Visible = false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
                        ans();
        Label7.Text = "Select Course";
        Label8.Text = "Select Quiz Id";
        DropDownList1.Visible = true;
        DropDownList2.Visible = true;
        Button1.Visible = true;
        Button3.Visible = false;
        GridView1.Visible = true;
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter("Select Quiz_ID, Question, Correct from Question where Quiz_ID='"+ViewState["b"]+"' ", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
        con.Close();

    }
    private void ans()
    {

        for (int i = Convert.ToInt16(ViewState["vk"]); i <= Convert.ToInt16(ViewState["zk"]); i++)
        {
            String k = "select * from Question where Question_ID='" + i + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(k, @"Data Source=hp\SQLEXPRESS;Initial Catalog=QUIZ;Integrated Security=True");
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            String f = ds1.Tables[0].Rows[0][8].ToString();
            String ab = ds1.Tables[0].Rows[0][9].ToString();
            if (f == ab)
            {
                c = c + 1;
            }
        }
        Label17.Visible = true;
        Label17.Text = "Your score is " + c + " ";
        Label17.ForeColor = System.Drawing.Color.DarkBlue;
        TextBox2.Text = "";
        RadioButton1.Text = "optionA";
        RadioButton2.Text = "optionB";
        RadioButton3.Text = "optionC";
        RadioButton4.Text = "optionD";
        Button4.Visible = false;
        SqlCommand com = new SqlCommand();
        com.Connection = con;
        com.CommandText = "Insert into Result Values(@a,@b,@c,@d)";
        str = ViewState["courseid"].ToString();
        com.Parameters.AddWithValue("@a", str);
        com.Parameters.AddWithValue("@b", ViewState["b"]);
        com.Parameters.AddWithValue("@c", Session["c"]);
        com.Parameters.AddWithValue("@d", c);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        for (int j = Convert.ToInt16(ViewState["vk"]); j <= Convert.ToInt16(ViewState["zk"]); j++)
        {
            SqlCommand com1 = new SqlCommand();
            com1.Connection = con;
            com1.CommandText = "UPDATE Question Set Select_Correct='Nil' where Question_ID='" + j + "' ";
            con.Open();
            com1.ExecuteNonQuery();
            con.Close();
        }
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton3.Checked = false;
        RadioButton4.Checked = false;
    }
    protected void Button4_Command(object sender, CommandEventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Button2.Visible = true;
        Button3.Visible = false;
        d = Convert.ToInt16(ViewState["a"]);
        a = Convert.ToInt16(ViewState["a"]) - 1;
        ViewState["a"] = a;
        quiz();

    }
}