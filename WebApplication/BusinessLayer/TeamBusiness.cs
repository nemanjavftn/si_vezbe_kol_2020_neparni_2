using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TeamBusiness
    {
      public TeamRepository tr;
            public TeamBusiness()
            {

                this.tr = new TeamRepository();

            }
            public List<Team> GetallTeams()
            {
                return this.tr.GetAllTeams();
            }
            public bool insertTeam(Team t)
            {
                int result = this.tr.insertTeam(t);
                if (result != 0)

                    return true;
                return false;
            
            }
        public List<Team> SortTeams(Team t)
        {
            TeamBusiness tb = new TeamBusiness();
            List<Team> Team = tb.GetallTeams();
            Team.OrderBy(x => x.Points1).ToList();
            return Team;
        }
       
        }
}
