using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_.Models
{
    public class Allergy
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public int Id { get; set; }
        public string Name { get; set; }

        public Allergy(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Allergy> GetAllergies()
        {
            List<Allergy> allergies = new List<Allergy>();
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select * from [Allergy]", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Allergy allergy = new Allergy(reader.GetInt32(0), reader.GetString(1));
                            allergies.Add(allergy);
                        }
                    }
                }
                logger.Debug($"Данные об аллергиях получены из базы данных, {allergies.Count} записей");
            }
            catch (Exception ex) 
            {
                logger.Error(ex.Message);
            }
            return allergies;
        }
    }
}
