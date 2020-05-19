using System;
using System.Diagnostics;

namespace NumbertoText
{
    public partial class NumberToText1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnSubmit_OnClick(object sender, EventArgs e)
        {
            try
            {
                lblText.Text = NumberToText.NumberToTexts(Int32.Parse(txtNumber.Text), false);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                lblText.Text= "Invalid Number";
            }      
        }
    }
}