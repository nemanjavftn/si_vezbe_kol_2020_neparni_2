using DataLayerTeams.NewFolder1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayerTeams
{
    public class TeamsRepository
    {
        public List<Team> GetAllTeams()
        {
            List<Team> teams = new List<Team>();
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Constants.connString;

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Teams";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Team t = new Team();
                    t.Id = sqlDataReader.GetInt32(0);
                    t.Name = sqlDataReader.GetString(1);
                    t.Couch = sqlDataReader.GetString(2);
                    t.Points = sqlDataReader.GetInt32(3);
                    teams.Add(t);
                }
            }

            return teams;
        }

        public int InsertTeam(Team t)
        {
            List<Team> teams = new List<Team>();
            using (SqlConnection sqlConnection = new SqlConnection())
            {
                sqlConnection.ConnectionString = Constants.connString;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format(
                    "INSERT INTO Teams VALUES ('{0}','{1}',{2})",
                    t.Name, t.Couch, t.Points
                    );

                return sqlCommand.ExecuteNonQuery();


            }
        }
    }
}
