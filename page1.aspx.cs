using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
       
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["c"] = TextBox3.Text;
        Session["deep"] = TextBox2.Text;
        SqlDataAdapter da = new SqlDataAdapter("select * from Student where Student_ID = '" +TextBox3.Text+"' and S_Password = '"+ TextBox2.Text+"'",@"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True" );
        DataSet ds = new DataSet();
        SqlDataAdapter da1 = new SqlDataAdapter("select * from Teacher where Teacher_ID = '" + TextBox3.Text + "' and T_Password = '" + TextBox2.Text + "'", @"Data Source=hp\SQLEXPRESS;Initial Catalog=Quiz;Integrated Security=True");
        DataSet ds1 = new DataSet();
        da.Fill(ds);
        da1.Fill(ds1);
        if (ds.Tables[0].Rows.Count >0 && RadioButton2.Checked==true )
        {
            Response.Redirect("page12.aspx");
        }
        else
        {
            if (ds1.Tables[0].Rows.Count > 0 && RadioButton1.Checked == true)
            {
                Response.Redirect("page18.aspx");
            }
            else
            {
                if (RadioButton1.Checked == false && RadioButton2.Checked == false)
                {
                    Label2.Visible = true;
                    Label2.Text = "select who are you";
                }
                else
                {
               
                    Label2.Text = "";
                    Label1.Visible = true;
                    Label1.Text = "User Id and Password not match";
                }
            }
        }
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("page3.aspx");
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("page2.aspx");
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (args.Value.Length == 4)
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false;
        }
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
       
    }
}