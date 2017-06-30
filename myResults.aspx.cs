using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class myResults : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    //Calculating the UJ APS, a function for that
    public int ujAPSCal()
    {
        int toReturn = 0;
        if (calculatorFunctions.theMarkForEnglish >= 50 && calculatorFunctions.theMarkForEnglish <= 59)
        {
            toReturn = toReturn + 5; //Whatever the value is that the actually add
        }
        if (calculatorFunctions.theMarkForEnglish >= 60 && calculatorFunctions.theMarkForEnglish <= 69)
        {
            toReturn = toReturn + 6; //Whatever the value is that the actually add
        }
        if (calculatorFunctions.theMarkForEnglish >= 70 && calculatorFunctions.theMarkForEnglish <= 79)
        {
            toReturn = toReturn + 7; //Whatever the value is that the actually add
        }
        if (calculatorFunctions.theMarkForEnglish >= 80 && calculatorFunctions.theMarkForEnglish <= 100)
        {
            toReturn = toReturn + 8; //Whatever the value is that the actually add
        }

        if (calculatorFunctions.theMarkForMaths >= 50 && calculatorFunctions.theMarkForMaths <= 59)
        {
            toReturn = toReturn + 5;
        }
        if (calculatorFunctions.theMarkForMaths >= 60 && calculatorFunctions.theMarkForMaths <= 69)
        {
            toReturn = toReturn + 6;
        }
        if (calculatorFunctions.theMarkForMaths >= 70 && calculatorFunctions.theMarkForMaths <= 79)
        {
            toReturn = toReturn + 7;
        }
        if (calculatorFunctions.theMarkForMaths >= 80 && calculatorFunctions.theMarkForMaths <= 100)
        {
            toReturn = toReturn + 8;
        }

        if (calculatorFunctions.theMarkForPhysicalSciences >= 50 && calculatorFunctions.theMarkForPhysicalSciences <= 59)
        {
            toReturn = toReturn + 5;
        }
        if (calculatorFunctions.theMarkForPhysicalSciences >= 60 && calculatorFunctions.theMarkForPhysicalSciences <= 69)
        {
            toReturn = toReturn + 6;
        }
        if (calculatorFunctions.theMarkForPhysicalSciences >= 70 && calculatorFunctions.theMarkForPhysicalSciences <= 79)
        {
            toReturn = toReturn + 7;
        }
        if (calculatorFunctions.theMarkForPhysicalSciences >= 80 && calculatorFunctions.theMarkForPhysicalSciences <= 100)
        {
            toReturn = toReturn + 8;
        }
        return toReturn;
    }

    //Calculating the wits APS, a function for that
    public int witsAPSCal()
    {
        int toReturn = 0; //Used to store the results and output it
        if(calculatorFunctions.theMarkForEnglish >= 50 && calculatorFunctions.theMarkForEnglish <= 59)
        {
            toReturn = toReturn + 5; //Whatever the value is that the actually add
        }
        if (calculatorFunctions.theMarkForEnglish >= 60 && calculatorFunctions.theMarkForEnglish <= 69)
        {
            toReturn = toReturn + 6; //Whatever the value is that the actually add
        }
        if (calculatorFunctions.theMarkForEnglish >= 70 && calculatorFunctions.theMarkForEnglish <= 100)
        {
            toReturn = toReturn + 7; //Whatever the value is that the actually add
        }
        if (calculatorFunctions.theMarkForMaths >= 50 && calculatorFunctions.theMarkForMaths <= 59)
        {
            toReturn = toReturn + 5;
        }
        if (calculatorFunctions.theMarkForMaths >= 60 && calculatorFunctions.theMarkForMaths <= 69)
        {
            toReturn = toReturn + 6;
        }
        if (calculatorFunctions.theMarkForMaths >= 70 && calculatorFunctions.theMarkForMaths <= 100)
        {
            toReturn = toReturn + 7;
        }
        if (calculatorFunctions.theMarkForPhysicalSciences >= 50 && calculatorFunctions.theMarkForPhysicalSciences <= 59)
        {
            toReturn = toReturn + 5;
        }
        if (calculatorFunctions.theMarkForPhysicalSciences >= 60 && calculatorFunctions.theMarkForPhysicalSciences <= 69)
        {
            toReturn = toReturn + 6;
        }
        if (calculatorFunctions.theMarkForPhysicalSciences >= 70 && calculatorFunctions.theMarkForPhysicalSciences <= 100)
        {
            toReturn = toReturn + 7;
        }
        return toReturn;
    }


    protected void doCalculations_Click(object sender, EventArgs e)
    {
        calculatorFunctions.theMarkForEnglish = Int32.Parse(myEnglish.Value);
        calculatorFunctions.theMarkForMaths = Int32.Parse(myMaths.Value);
        calculatorFunctions.theMarkForPhysicalSciences = Int32.Parse(myPhysicalSciences.Value);

        calculatorFunctions.theWitsAPS = witsAPSCal(); //Calculating asnd storing the APS
        calculatorFunctions.theUJAPS = ujAPSCal(); //Calculating asnd storing the APS
        //Moving to the next page
        Response.Redirect("myAPS_Scores.aspx");
    }
}