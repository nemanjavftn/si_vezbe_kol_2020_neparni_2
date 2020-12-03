using DataLayerTeams;
using DataLayerTeams.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayerTeams
{
    
    public  class TeamsBussiness
    {
        private readonly TeamsRepository teamsRepository;

        public TeamsBussiness()
        {
            this.teamsRepository = new TeamsRepository();
        }

        public List<Team> GetallTeam()
        {
            return this.teamsRepository.GetAllTeams();
        }

        public bool InsertVeterinar(Team t)
        {
            if (this.teamsRepository.InsertTeam(t) > 0)
            {
                return true;
            }
            return false;
        }
    }


}
