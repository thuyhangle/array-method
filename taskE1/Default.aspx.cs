using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace taskE1
{
    public partial class Default : System.Web.UI.Page
    {
        int num1;
        int num2;
        int result;
        string ans;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void BtnE1Clicked(object sender, EventArgs e)
        {
            try
            {
                num1 = int.Parse(int1.Text);
            }
            catch (FormatException exception)
            {
                ans = "Wrong Intput";
                sum.Text = ans.ToString();
                return;
            }

            try
            {
                num2 = int.Parse(int2.Text);
            }
            catch (FormatException exception)
            {
                ans = "Wrong Intput";
                sum.Text = ans.ToString();
                return;
            }

            result = num1 + num2;
            ans = result.ToString();
            sum.Text = "Sum = " + ans;
        }
    }
}