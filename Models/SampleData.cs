using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Data.SqlClient;

namespace aspnet_mssql_sample.Models
{
    public class SampleData
    {
        private static string connectionString = ConnectionSetting.CONNECTION_STRING;

        public static void RetriveRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Car";

                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                Cars = new List<Car>();
                while (reader.Read())
                {
                    Cars.Add(new Car()
                    {
                        CarId = int.Parse(reader["CarId"].ToString()),
                        Model = reader["Model"].ToString(),
                        Manufacturer = reader["Manufacturer"].ToString(),
                        Year = int.Parse(reader["Year"].ToString())
                    });
                }
                reader.Close();

                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        public static bool InsertRecord(Car car)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Car (Model, Year, Manufacturer) VALUES (@Model, @Year, @Manufacturer);";

                command.Parameters.AddWithValue("@Model", car.Model);
                command.Parameters.AddWithValue("@Year", car.Year);
                command.Parameters.AddWithValue("@Manufacturer", car.Manufacturer);

                if (connection.State != System.Data.ConnectionState.Open)
                    connection.Open();

                if(command.ExecuteNonQuery() == 1) { return true; }

                return false;
            }
        }

        public static List<Car> Cars { get; set; }
    }
}
