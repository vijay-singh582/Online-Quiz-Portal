using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page4 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
    
        if (Session["a"] != null)
        {
            Label4.Visible = true;
            Label4.Text = Session["a"].ToString();
        }
        if(Session["a"]==null && Session["d"]==null)
        {
            Response.Redirect("page1.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["a"] = null;
        Session["d"] = null;
            Response.Redirect("page1.aspx");
        
    }
}
