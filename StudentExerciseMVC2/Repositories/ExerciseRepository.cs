using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StudentExercisesMVC2.Models;

namespace StudentExercisesMVC2.Repositories
{
    public class ExerciseRepository
    {
        private static IConfiguration _config;

        public static void SetConfig(IConfiguration configuration)
        {
            _config = configuration;
        }

        public static SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }


        public static List<Exercise> GetExercises()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
            SELECT e.Id,
                e.Name,
                e.Language
            FROM Exercise e
        ";
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Exercise> exercises = new List<Exercise>();
                    while (reader.Read())
                    {
                        Exercise exercise = new Exercise
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Language = reader.GetString(reader.GetOrdinal("Language"))
                        };
                        exercises.Add(exercise);
                    }
                    reader.Close();
                    return exercises;
                    
                }
            }
        }

        public static Exercise CreateExercise(Exercise exerciseModel)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"INSERT INTO Exercise (Name, Language)         
                                         OUTPUT INSERTED.Id                                                       
                                         VALUES (@name, @language)";
                    cmd.Parameters.Add(new SqlParameter("@name", exerciseModel.Name));
                    cmd.Parameters.Add(new SqlParameter("@language", exerciseModel.Language));

                    int newId = (int)cmd.ExecuteScalar();
                    exerciseModel.Id = newId;
                    return exerciseModel;
                }
            }
        }

        public static bool DeleteExercise(int id)
        {
            
                using (SqlConnection conn = Connection)
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"DELETE FROM Exercise WHERE @id = Id";
                        cmd.Parameters.Add(new SqlParameter("@id", id));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0) return false;
                    return true;
                    }
                }
        }

        public static void UpdateExercise(int id, Exercise exercise)
        {

            using (SqlConnection conn = Connection)
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            UPDATE Exercise
                            SET Name = @name,
                                Language = @language
                            WHERE Id = @id
                        ";
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        cmd.Parameters.Add(new SqlParameter("@name", exercise.Name));
                        cmd.Parameters.Add(new SqlParameter("@language", exercise.Language));

                    cmd.ExecuteNonQuery();
                    }
                }
        }

        public static Exercise GetExercise(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                            SELECT e.Id,
                             e.Name,
                             e.Language
                             FROM Exercise e
                            WHERE e.Id = @ExerciseId
                        ";
                    cmd.Parameters.Add(new SqlParameter("@ExerciseId", id));

                    SqlDataReader reader = cmd.ExecuteReader();

                    Exercise exercise = null;
                    if (reader.Read())
                    {
                        exercise = new Exercise
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            Language = reader.GetString(reader.GetOrdinal("Language"))
                        };

                    }
                    reader.Close();
                    return exercise;

                   
                }
            }
        }
    }
}