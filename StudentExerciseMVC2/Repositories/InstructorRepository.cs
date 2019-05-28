using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using StudentExercisesMVC2.Models;
public class InstructorRepository
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


    public static List<Instructor> GetInstructors()
    {
        using (SqlConnection conn = Connection)
        {
            conn.Open();
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
            SELECT i.Id,
                i.FirstName,
                i.LastName,
                i.SlackHandle,
                i.CohortId
            FROM Instructor i
        ";
                SqlDataReader reader = cmd.ExecuteReader();

                List<Instructor> instructors = new List<Instructor>();
                while (reader.Read())
                {
                    Instructor instructor = new Instructor
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                        SlackHandle = reader.GetString(reader.GetOrdinal("SlackHandle")),
                        CohortId = reader.GetInt32(reader.GetOrdinal("CohortId"))
                    };
                    instructors.Add(instructor);
                }
                reader.Close();

                return instructors;
            }
        }
    }

    public static Instructor CreateInstructor(Instructor instructor)
    {

        using (SqlConnection conn = Connection)
        {
            conn.Open();
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Instructor (FirstName, LastName, SlackHandle, CohortId)         
                                         OUTPUT INSERTED.Id                                                       
                                         VALUES (@firstName, @lastName, @handle, @cId)";
                cmd.Parameters.Add(new SqlParameter("@firstName", instructor.FirstName));
                cmd.Parameters.Add(new SqlParameter("@lastName", instructor.LastName));
                cmd.Parameters.Add(new SqlParameter("@handle", instructor.SlackHandle));
                cmd.Parameters.Add(new SqlParameter("@cId", instructor.CohortId));

               
              

                int newId = (int)cmd.ExecuteScalar();
                instructor.Id = newId;
                return instructor;
            }
        }
    }

    public static bool DeleteInstructor(int id)
    {
        try
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"DELETE FROM Instructor WHERE Id = @id";
                    cmd.Parameters.Add(new SqlParameter("@id", id));

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0) return false;
                    return true;
                }
            }
        }
        catch
        {
            return false;
        }
    }

    public static void UpdateInstructor(Instructor instructor)
    {
        using (SqlConnection conn = Connection)
        {
            conn.Open();
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"UPDATE Instructor
                                            SET FirstName = @firstName,
                                                LastName = @lastName,
                                                SlackHandle = @handle,
                                                CohortId = @cId
                                            WHERE Id = @id";
                cmd.Parameters.Add(new SqlParameter("@firstName", instructor.FirstName));
                cmd.Parameters.Add(new SqlParameter("@lastName", instructor.LastName));
                cmd.Parameters.Add(new SqlParameter("@handle", instructor.SlackHandle));
                cmd.Parameters.Add(new SqlParameter("@cId", instructor.CohortId));
                cmd.Parameters.Add(new SqlParameter("@id", instructor.Id));

                cmd.ExecuteNonQuery();
            }
        }
    }

    public static Instructor GetInstructor(int id)
    {
        Instructor instructor = null;
        using (SqlConnection conn = Connection)
        {
            conn.Open();
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"
                             SELECT i.Id,
                i.FirstName,
                i.LastName,
                i.SlackHandle,
                i.CohortId
            FROM Instructor i
                            WHERE i.Id = @InstructorId
                        ";
                cmd.Parameters.Add(new SqlParameter("@InstructorId", id));

                SqlDataReader reader = cmd.ExecuteReader();


                if (reader.Read())
                {
                    instructor = new Instructor
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                        LastName = reader.GetString(reader.GetOrdinal("LastName")),
                        SlackHandle = reader.GetString(reader.GetOrdinal("SlackHandle")),
                        CohortId = reader.GetInt32(reader.GetOrdinal("CohortId"))
                    };
                }

                reader.Close();
                return instructor;
            }
        }
    }
}