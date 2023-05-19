using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_.Models
{
    public class Ingredient
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public int Id { get; set; }
        public string Name { get; set; }

        public Ingredient(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Ingredient> GetDishIngredients(int idDish)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select [Ingredient].[Id], [Ingredient].[Name] " +
                        $"from [DishIngredint] join [Ingredient] on [DishIngredint].[IdIngredient] = [Ingredient].[Id] and [DishIngredint].[IdDish] = {idDish}", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ingredient ingredient = new Ingredient(reader.GetInt32(0), reader.GetString(1));
                            ingredients.Add(ingredient);
                        }
                    }
                }
                logger.Debug($"Данные об ингредиентах блюда ({idDish} ид блюда) получены из базы данных, {ingredients.Count} записей");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
           
            return ingredients;
        }
    }
}
