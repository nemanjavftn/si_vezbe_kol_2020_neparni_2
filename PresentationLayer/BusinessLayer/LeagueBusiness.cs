using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LeagueBusiness
    {
        public readonly LeagueRepository leagueRepository;

        public LeagueBusiness()
        {
            this.leagueRepository = new LeagueRepository();
        }

        public List<League> GettAll()
        {
            return this.leagueRepository.GetAllTeams();
        }

        public bool InsertTeam(League l)
        {
            if(this.leagueRepository.InsertTeam(l) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
