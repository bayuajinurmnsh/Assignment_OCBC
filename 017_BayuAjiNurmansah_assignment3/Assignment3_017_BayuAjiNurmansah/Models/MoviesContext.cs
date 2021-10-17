using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Mvc;

namespace Assignment3_017_BayuAjiNurmansah.Models
{
    public class MoviesContext
    {
        public string result = "";
        public string ConnectionString { get; set; }
        
        public MoviesContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MoviesItem> GetAllMovies()
        {
            List<MoviesItem> list = new List<MoviesItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_movies", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(new MoviesItem()
                        {
                            id = reader.GetInt32("Id"),
                            name = reader.GetString("Name"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            releaseDate = reader.GetString("ReleaseDate")

                        });
                    }
                }
            }
            return list;
        }//public List<MoviesItem> GetAllMovies()
        
        public List<MoviesItem> GetMovies(string id)
        {
            List<MoviesItem> list = new List<MoviesItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_movies where Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
    
                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(new MoviesItem()
                        {
                            id = reader.GetInt32("Id"),
                            name = reader.GetString("Name"),
                            genre = reader.GetString("Genre"),
                            duration = reader.GetString("Duration"),
                            releaseDate = reader.GetString("ReleaseDate")

                        });
                    }
                }
            }

            return list;
        }//public List<MoviesItem> GetMovies(string id)

        public string CreateMoviesItem(string name, string genre, string duration, string releaseDate)
        {
            using (MySqlConnection conn = GetConnection())
            {
                
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_movies (Name,Genre,Duration,ReleaseDate) VALUES (@Name, @Genre, @Duration, @ReleaseDate)", conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);

                MySqlDataReader reader = cmd.ExecuteReader();
            }

            return "Data has been insert";
        }

        public string UpdateMoviesItem(int id, string name, string genre, string duration, string releaseDate)
        {
            using (MySqlConnection conn = GetConnection())
            {

                conn.Open();


                MySqlCommand cmd = new MySqlCommand("UPDATE tbl_movies SET Name= @Name, Genre= @Genre, Duration= @Duration, ReleaseDate = @ReleaseDate  WHERE id=@Id", conn);

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Genre", genre);
                cmd.Parameters.AddWithValue("@Duration", duration);
                cmd.Parameters.AddWithValue("@ReleaseDate", releaseDate);

                MySqlDataReader reader = cmd.ExecuteReader();
            }

            return "Data has been update";
        }

        public string DeleteMoviesItem(int id)
        {
            using (MySqlConnection conn = GetConnection())
            {

                conn.Open();


                MySqlCommand cmd = new MySqlCommand("DELETE FROM tbl_movies WHERE id=@Id", conn);

                cmd.Parameters.AddWithValue("@Id", id);

                MySqlDataReader reader = cmd.ExecuteReader();
            }

            return $"Data with id {id} has been deleted";
        }

    }
}
