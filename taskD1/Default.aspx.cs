using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskD1
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClicked(object sender, EventArgs e)
        {
            string[] citys = new string[4];
            citys[0] = "Helsinki";
            citys[1] = "Oulu";
            citys[2] = "Hanoi";
            citys[3] = "HCMC";
            cityName.Text = string.Join(" , ", citys);

            int[] numbers = new int[500];
            Random rdn = new Random();
            for (int i = 0; i < 500; i++ )
            {
                numbers[i] = rdn.Next(0, 501);
            }
            numbersList.Text = string.Join(" , ", numbers);
        }
    }
}