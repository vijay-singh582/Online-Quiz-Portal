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
                 DropDownList1.DataTextField = "Course_ID";
                 DropDownList1.DataBind();
                 DropDownList1.Items.Insert(0, new ListItem("select Course ID"));
                 DropDownList1.SelectedIndex = 0;
             }
         }
     }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label15.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Label15.Visible = false;
        if (DropDownList1.SelectedIndex > 0)
        {
            String str1 = "Select  Course_ID, Quiz_ID, Student_ID, Score from Result where Course_ID='" + DropDownList1.SelectedItem.Value + "'";
            SqlDataAdapter da2 = new SqlDataAdapter(str1, con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            if (ds2.Tables[0].Rows.Count > 0)
            {
                GridView1.Visible = true;
                GridView1.DataSource = ds2;
                GridView1.DataBind();
            }
            else
            {
                Label15.Visible = true;
                Label15.Text = "No One Attend";
                Label15.ForeColor = System.Drawing.Color.Red;
                GridView1.Visible = false; ;
            }
        }
        else
        {
            Label15.Visible = true;
            Label15.Text = "Select Course ID";
            Label15.ForeColor = System.Drawing.Color.Red;
        }

      }
}