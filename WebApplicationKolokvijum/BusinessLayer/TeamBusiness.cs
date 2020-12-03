using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class TeamBusiness
    {
        private readonly TeamsRepository teamRepository; // povezivanje sa Data slojem

        public TeamBusiness()
        {
            this.teamRepository = new TeamsRepository();
        }

        public List<Team> GetAllTeams()
        {
            return this.teamRepository.GetAllTeams();
        }

        public bool InsertTeam(Team t)
        {
            if (this.teamRepository.InsertTeam(t) > 0)
            {
                return true;
            }
            return false;
        }

        public List<Team> SortTeamsPoints(int points)
        {
            return this.teamRepository.GetAllTeams().OrderBy(t => t.Points).ToList();
        }
    }
}
