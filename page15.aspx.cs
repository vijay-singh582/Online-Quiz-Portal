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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["c"] == null && Session["deep"] == null)
        {
            Response.Redirect("page1.aspx");
        }
        if (!IsPostBack)
        {
            String str2 = "Select  Course_ID, Quiz_ID, Student_ID, Score from Result where Student_ID='" + Session["c"] + "'";
            SqlDataAdapter da = new SqlDataAdapter(str2, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["c"]!= null)
        {
            Label15.Visible = false;
            query1 = "Select Course_ID, Quiz_ID, Student_ID, Score from Result where Quiz_ID='" + DropDownList2.SelectedItem.Value + "' AND Student_ID='" + Session["c"] + "'";
            SqlDataAdapter da2 = new SqlDataAdapter(query1, con);
            con.Open();
            DataSet ds = new DataSet();
            da2.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                Label15.Visible = true;
                Label15.Text = "this quiz not performed by you";
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
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
                Label15.Visible = true;
                Label15.Text = "!Not enrolled!";
                DropDownList2.Items.Insert(0, new ListItem("select Quiz"));
                DropDownList2.SelectedIndex = 0;
            }
            else
            {
                Label15.Visible = false;
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
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}