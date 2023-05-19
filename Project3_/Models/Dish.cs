using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_.Models
{
    public class Dish
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public int Id { get; set; }
        public string Name { get; set; }
        public int Kal { get; set; }
        public string DishType { get; set; }

        public Dish(int id, string name, int kal, string dishType)
        {
            Id = id;
            Name = name;
            Kal = kal;
            DishType = dishType;
        }

        public static List<Dish> GetDishesByKalAndDishType(int kal, string dishType)
        {
            List<Dish> dishes = new List<Dish>();
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select * from [Dish] where Kal = {kal} and DishType = N'{dishType}'", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dish dish = new Dish(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                            dishes.Add(dish);
                        }
                    }
                }
                logger.Debug($"Данные о блюде по каллорийности ({kal}) и типу получены ({dishType}) из базы данных, {dishes.Count} блюд");
            }
            catch (Exception ex)
            {
                 logger.Error(ex.Message);
            }

            return dishes;
        }
    }
}
