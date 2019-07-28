using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ConsoleTutorialWithBeqa.SQL;
using Dapper;

namespace ConsoleTutorialWithBeqa.Dapper
{
    public class DapperWorkflow : IRun
    {
        private const string connectionString = @"Data Source=DESKTOP-LUKA;Initial Catalog=TestDb; Integrated Security=true";

        public void Run()
        {
            //InsertShip(new Ship { Name = "greifsvald", Flag = "panama" });
            //UpdateShip(new Ship { Id=2, Name = "greifvald", Flag = "panama" });
            DeleteShip(2);

            var ships = GetShips();
            foreach (var ship in ships)
            {
                Console.WriteLine(ship.Description);
            }
        }

        public List<Ship> GetShips()
        {
            string sqlQueryString = @"SELECT [Name], [Flag] FROM [Ships]"; 
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                List<Ship> ships = db.Query<Ship>(sqlQueryString).ToList();

                return ships;
            }
        }

        public void InsertShip(Ship ship)
        {
            string sqlQuery = @"INSERT INTO [Ships] ([Name] ,[Flag]) VALUES (@Name , @Flag)";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                db.Execute(sqlQuery, ship);
            }
        }

        public void UpdateShip(Ship ship)
        {
            string sqlQuery = @"UPDATE [Ships] SET [Name] = @Name, [Flag] = @Flag WHERE Id = @Id";
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Open();

                db.Execute(sqlQuery, ship);
            }
        }

        public void DeleteShip(int shipId)
        {
            string sqlQuery = @"DELETE FROM [Ships] WHERE Id = @Id";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                connection.Execute(sqlQuery, new { Id = shipId });
            }
        }
    }
}
