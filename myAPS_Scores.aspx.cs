using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myAPS_Scores : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Anything in here gets done as soon as a page loads

        myWitsAPS.Text = calculatorFunctions.theWitsAPS.ToString(); //Ensures that the value is written as text
        myUJAPS.Text = calculatorFunctions.theUJAPS.ToString();
    }
}