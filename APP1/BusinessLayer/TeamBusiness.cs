using DataLayer4;
using DataLayer4.Models;
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
            public List<TeamT> getallteams()
            {
                return this.tr.GetAllTeams();
            }
            public bool insertteam(TeamT t)
            {
                int result = this.tr.InsertTeam(t);
                if (result != 0)
                    return true;
                else
                    return false;
            }
        }
    }
