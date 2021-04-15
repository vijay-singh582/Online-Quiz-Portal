using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label6.Text = Calendar1.TodaysDate.ToShortDateString();

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
       

    }
}
