using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleTutorialWithBeqa.SQL
{
    public class SQLWorkflow : IRun
    {
        public void Run()
        {
            List<Ship> ships = GetShips();

            foreach (Ship ship in ships)
            {
                Console.WriteLine(ship.Description);
            }
        }

        public List<Ship> GetShips()
        {
            string connectionString = @"Data Source=DESKTOP-LUKA;Initial Catalog=FerryDb2; Integrated Security=true";

            string sqlString = @"
SELECT [Name], [Flag]
FROM [Ships]
";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<Ship> ships = new List<Ship>();

                while (reader.Read())
                {
                    Ship ship = new Ship
                    {
                        Name = reader["Name"].ToString(),
                        Flag = reader["Flag"].ToString()
                    };

                    ships.Add(ship);
                }

                return ships;
            }
        }
    }
}
