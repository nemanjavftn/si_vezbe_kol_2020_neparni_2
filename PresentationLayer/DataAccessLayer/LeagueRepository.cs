using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class LeagueRepository
    {
        public List<League> GetAllTeams()
        {
            List<League> all = new List<League>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Teams";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    League l = new League();
                    l.Id = sqlDataReader.GetInt32(0);
                    l.Name = sqlDataReader.GetString(1);
                    l.Couch = sqlDataReader.GetString(2);
                    l.Points = sqlDataReader.GetInt32(3);

                    all.Add(l);
                }
            }
                return all;
            }

        public int InsertTeam(League l)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = String.Format("INSERT INTO Vets VALUES('{0}', '{1}', {2})", l.Name, l.Couch, l.Points);
                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
