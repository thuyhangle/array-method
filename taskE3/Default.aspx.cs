using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskE3
{
    public partial class Default : System.Web.UI.Page
    {
        int num1;
        int num2;
        float result;
        string ans;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void BtnE3Clicked(object sender, EventArgs e)
        {
            try
            {
                num1 = int.Parse(int1.Text);
            }
            catch (FormatException exception)
            {
                ans = "Wrong Intput";
                avg.Text = ans.ToString();
                return;
            }

            try
            {
                num2 = int.Parse(int2.Text);
            }
            catch (FormatException exception)
            {
                ans = "Wrong Intput";
                avg.Text = ans.ToString();
                return;
            }

            int sum = num1 + num2; 
            if (sum == 0)
            {
                result = 0;
            }
            else
            {
                result = (float)sum / 2;
            }
            ans = result.ToString();
            avg.Text = "Avg = " + ans;
        }
    }
}