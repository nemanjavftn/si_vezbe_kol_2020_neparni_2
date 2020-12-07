using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TeamRepository
    {
        public List<Team> GetAllTeams()
        {
            List<Team> teamList = new List<Team>();
            string conString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LeagueDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string commandText = "Select * from Teams";
                SqlCommand com = new SqlCommand(commandText, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Team t = new Team(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3));
                    teamList.Add(t);
                }
            }

            return teamList;
        }
        public int insertTeam(Team t)
        {
            int result;
            string conString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LeagueDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(conString))

            {
                con.Open();
                string commandText = "Insert into Teams (Name,Couch,Points) values(@Name,@Couch,@Points)";
                SqlCommand com = new SqlCommand(commandText, con);
                com.Parameters.AddWithValue("@Marka", t.Name1);
                com.Parameters.AddWithValue("@godinaProizvodnje", t.Couch1);
                com.Parameters.AddWithValue("@cena", t.Points1);
                result = com.ExecuteNonQuery();

            }
            return result;
        }





    }
}
