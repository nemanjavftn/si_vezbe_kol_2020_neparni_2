using BusinessLayer;
using DataLayer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APP1
{
    public partial class teams : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            TeamBusiness tb = new TeamBusiness();
            List<TeamT> teamList = tb.getallteams();
            foreach (TeamT t in teamList)
            {
                ListBox1.Items.Add(t.ToString());
                refreshList();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TeamBusiness sb = new TeamBusiness();
            TeamT t = new TeamT(1, TextBox1.Text, TextBox2.Text, Convert.ToInt32(TextBox3.Text));
            bool result = sb.insertteam(t);
            if (result == true)
            {
                refreshList();
            }

        }
        private void refreshList()
        {
            ListBox1.Items.Clear();
            TeamBusiness tb = new TeamBusiness();
            List<TeamT> teamList = tb.getallteams();
            foreach (TeamT t in teamList)
            {
                ListBox1.Items.Add(t.ToString());
            }
        }

    }
}