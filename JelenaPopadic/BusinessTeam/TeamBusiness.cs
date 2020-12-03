using dataLayer;
using dataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTeam
{
    public class TeamBusiness
    {
        DataRepository dr;

        public TeamBusiness()
        {
            this.dr = new DataRepository();
        }

        public List<Team> getAllteams()
        {
           
      
           return this.dr.GetAllTeams();
        }

        public bool InsertTeam(Team t)
        {
            int result = dr.InsertTeam(t);
            if (result != 0)
                return true;
            return false;
        }
    }
}
