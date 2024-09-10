using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace PROG6212_POEPART1.Models
{
    public class Lecturer : PageModel
    {
        public List<LecturerInfo> lecturerInfos = new List<LecturerInfo>();

        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM dbo.Lecturer";
                    using (SqlCommand command = new SqlCommand(sql, connection)) 
                    {
                        using (SqlDataReader reader = command.ExecuteReader()) 
                        {
                            while (reader.Read()) 
                            {
                                LecturerInfo info = new LecturerInfo();
                                info.LecturerID = reader.GetInt32(0);
                                info.FirstName = reader.GetString(1);
                                info.LastName = reader.GetString(2);
                                info.Department = reader.GetString(3);
                                info.Email = reader.GetString(4);

                                lecturerInfos.Add(info);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
        }

        public class LecturerInfo {
            public int LecturerID; 
            public string FirstName;
            public string LastName; 
            public string Department;
            public string Email;
        }
    }
}
