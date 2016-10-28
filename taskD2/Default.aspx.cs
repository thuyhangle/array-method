using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace taskD2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn2Clicked(object sender, EventArgs e)
        {
            string[,] Letters = new string[,]
            {
                {"α", "a" },
                {"β", "b" },
                {"γ", "g" },
                {"δ", "d" },
                {"ε", "e" },
                {"θ", "t" }
            };
            for (int i = 0; i < 6; i++)
            {
                string greek = Letters[i, 0];
                string western = Letters[i, 1];
                string gw = string.Format("{0}, {1}", greek, western);
                letter.Text += gw + ", ";
            }
        }
    }
}