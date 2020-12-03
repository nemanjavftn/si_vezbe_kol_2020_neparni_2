using DataLayer4.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer4
{
    public class TeamRepository
    {

        public List<TeamT> GetAllTeams()
        {
            List<TeamT> teamList = new List<TeamT>();
            string sqlcon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LeagueDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                string commandText = "select * from Teams";
                SqlCommand com = new SqlCommand(commandText, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    TeamT t = new TeamT(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3));
                    teamList.Add(t);
                }
            }
            return teamList;
        }
        public int InsertTeam(TeamT t)
        {
            int result;
            string sqlcon = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LeagueDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                string commandText = "insert into Teams(Name,Couch,Points) values(@nam, @cou, @poi)";
                SqlCommand com = new SqlCommand(commandText, con);
                com.Parameters.AddWithValue("@nam", t.Name1);
                com.Parameters.AddWithValue("@cou", t.Couch1);
                com.Parameters.AddWithValue("@averagem", t.Points1);
                result = com.ExecuteNonQuery();
            }
            return result;
        }
    }
}
