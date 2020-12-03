using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationKolokvijum
{
    public partial class Teams : System.Web.UI.Page
    {
        private readonly TeamBusiness teamBusiness; //kacenje na biznis sloj
        public Teams()
        {
            this.teamBusiness = new TeamBusiness();
           
        }

        protected void ListBoxTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
            
        }
        private void RefreshData() //metoda za osvezavanje stranice
        {
            List<Team> teams = this.teamBusiness.GetAllTeams();
            ListBoxTeams.Items.Clear();

            foreach (Team t in teams)
            {
                ListBoxTeams.Items.Add(t.Id + ". " + t.Name + " - " + t.Couch + " - " + t.Points);
            }

        }

        private class TeamBusiness
        {
        }
    }
}