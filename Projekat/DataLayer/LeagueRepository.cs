using System;

namespace DataLayer
{
    public class LeagueRepository
    {

        public List<League> GetAllLeagues()
        {

            public string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LeagueDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
            List<League> results = new List<League>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Leagues";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    League s = new League();
                    s.Id = sqlDataReader.GetInt32(0);
                    s.Name = sqlDataReader.GetString(1);
                    s.Couch = sqlDataReader.GetString(2);
                    s.Points = sqlDataReader.GetInt32(3);

                    results.Add(s);
                }
            }

            return results;
        }

        public int InsertLeague(League s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Leagues VALUES ('{0}', '{1}', {2})",
                        s.Name, s.Couch, s.Points);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
    }
}
