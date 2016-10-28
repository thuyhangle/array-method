using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskE6
{
    public partial class Default : System.Web.UI.Page
    {
        int num1;
        int result = 1;
        string ans;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnE6Clicked(object sender, EventArgs e)
        {
            try
            {
                num1 = int.Parse(int1.Text);
            }
            catch (FormatException exception)
            {
                ans = "Wrong Intput";
                fac.Text = ans.ToString();
                return;
            }
            for ( int i = 1; i <= num1; i++)
            {
                result *= i;
            }
            ans = result.ToString();
            fac.Text = "Factorial = " + ans;
        }
    }
}