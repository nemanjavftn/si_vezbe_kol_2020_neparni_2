using dataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataLayer
{
    public class DataRepository
    {
        public List<Team> GetAllTeams()
        {
            List<Team> lista = new List<Team>();
            string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LeagueDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using(SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string command = "Select * From Teams";
                SqlCommand com = new SqlCommand(command, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                    lista.Add(new Team(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetInt32(3)));
            }
            return lista;
        }

        public int InsertTeam(Team t)
        {
            int result;
            string constring = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LeagueDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(constring))
            {
                con.Open();
                string command = "Insert INTO Team (Name, Couch, Points) VALUES (@Name, @Couch, @Points) where Id=@Id";
                SqlCommand com = new SqlCommand(command, con);
                com.Parameters.AddWithValue("@Name", t.getSetName);
                com.Parameters.AddWithValue("@Couch", t.getSetCouch);
                com.Parameters.AddWithValue("@Points", t.getSetPoints);
                result = com.ExecuteNonQuery();
            }
            return result;
        }
    }
}
