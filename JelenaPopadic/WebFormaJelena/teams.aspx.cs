using BusinessTeam;
using dataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormaJelena
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            TeamBusiness tb = new TeamBusiness();
            List<Team> lista = new List<Team>();
            lista = tb.getAllteams();
            int i = 1;
            foreach(Team t in lista)
            {
                ListBox1.Items.Add(i+" " + t.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TeamBusiness tb = new TeamBusiness();
            Team t = new Team(1, TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox3.Text));
            bool result = tb.InsertTeam(t);
            if (result)
                Label1.Text = "Valid";
            else
                Label1.Text = "Invalid";
        }
    }
}