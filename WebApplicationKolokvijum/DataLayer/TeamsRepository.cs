using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TeamsRepository
    {
        public List<Team> GetAllTeams() //kreiranje metode get all
        {
            List<Team> results = new List<Team>(); //kreiranje Liste koja vraca

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString)) // konekcija ka bazi
            {
                SqlCommand sqlCommand = new SqlCommand(); // sql obj
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Teams"; //sql upit

                sqlConnection.Open(); // otvaranje konekcije

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Team t = new Team();
                    t.Id = sqlDataReader.GetInt32(0);
                    t.Name = sqlDataReader.GetString(1);
                    t.Couch = sqlDataReader.GetString(2);
                    t.Points = sqlDataReader.GetInt32(3);

                    results.Add(t); //dodavanje redova u listu
                }
            }

            return results;
        }

        public int InsertTeam(Team s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Teams VALUES ('{0}','{1}',{2})",
                    s.Name, s.Couch, s.Points);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}


/*
 * 
 * 
 * 
 */