using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer
{
    public partial class _Default : Page
    {
        private LeagueBusiness leagueBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.leagueBusiness = new LeagueBusiness();

            List<League> results = this.leagueBusiness.GettAll();

            ListBox.Items.Clear();
            foreach (League l in results)
            {
                ListBox.Items.Add(l.Id + ", " + l.Name + ", " + l.Couch + ", " + l.Points);
            }

        }
    }
}