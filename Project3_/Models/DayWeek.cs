using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_.Models
{
    public class DayWeek
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public int Id { get; set; }
        public string Name { get; set; }

        public DayWeek(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<DayWeek> GetDaysWeek()
        {
            List<DayWeek> dayWeeks = new List<DayWeek>();
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select * from [DayWeek]", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DayWeek dayWeek = new DayWeek(reader.GetInt32(0), reader.GetString(1));
                            dayWeeks.Add(dayWeek);
                        }
                    }
                }
                logger.Debug($"Данные о днях недели получены из базы данных, {dayWeeks.Count} записей");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
            return dayWeeks;
        }
    }
}
