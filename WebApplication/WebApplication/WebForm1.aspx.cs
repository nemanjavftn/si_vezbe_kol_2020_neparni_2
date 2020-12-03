using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            TeamBusiness tb = new TeamBusiness();
            List<Team> tl = tb.GetallTeams();
            foreach (Team t in tl)
            {
                ListBox1.Items.Add(t.ToString());
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TeamBusiness ab = new TeamBusiness();
            Team t = new Team (1, TextBox1.Text,  TextBox2.Text, Convert.ToInt32(TextBox3.Text));
            bool result = ab.insertTeam(t);
            ListBox1.Items.Clear();
            Page_Load(null, null);
        }
    }
}