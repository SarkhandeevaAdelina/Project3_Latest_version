using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project3_.Models
{
    public class Ration
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public int Id { get; set; }
        public User User { get; set; }
        public DayWeek DayWeek { get; set; }
        public Dish DishBreakfast { get; set; }
        public Dish DishLunch { get; set; }
        public Dish DishDinner { get; set;}
        public int Kal { get; set; }

        public Ration(int id, User user, DayWeek dayWeek, Dish dishBreakfast, Dish dishLunch, Dish dishDinner, int kal)
        {
            Id = id;
            User = user;
            DayWeek = dayWeek;
            DishBreakfast = dishBreakfast;
            DishLunch = dishLunch;
            DishDinner = dishDinner;
            Kal = kal;
        }

        public static void AddRation(int idUser, int idDayWeek, int idDishBreakfast, int idDishLunch, int idDishDinner, int kal)
        {
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("insert into [Ration] ([IdUser], [IdDayWeek], [IdDishBreakfast], [IdDishLunch], [IdDishDinner], [Kal]) " +
                            $"values ({idUser}, {idDayWeek}, {idDishBreakfast}, {idDishLunch}, {idDishDinner}, {kal})", connection);
                    command.ExecuteNonQuery();
                }
                logger.Debug($"Добавлен рацион в базу данных, {idUser} ид пользователя");
            }
            catch(Exception ex)
            {
                logger.Error(ex.Message);
            }

        }

        public static void RemoveUserRations(User user)
        {
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"delete from [Ration] where [IdUser] = {user.Id}", connection);
                    command.ExecuteNonQuery();
                }
                logger.Debug($"Удален рацион, {user.Id} ид пользователя");
            }
            catch (Exception ex) 
            {
                logger.Error(ex.Message);
            }
        }

        public static List<Ration> GetUserRations(User user)
        {
            List<Ration> rations = new List<Ration>();
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select [Ration].[Id], [DayWeek].[Id], [DayWeek].[Name], " +
                        $"[DishBreakfast].[Id], [DishbreakFast].[Name],  [DishBreakfast].[Kal], [DishbreakFast].[DishType], " +
                        $"[DishLunch].[Id], [DishLunch].[Name],  [DishLunch].[Kal], [DishLunch].[DishType], " +
                        $"[DishDinner].[Id], [DishDinner].[Name],  [DishDinner].[Kal], [DishDinner].[DishType], [Ration].[Kal] " +
                        $"from [Ration] join [DayWeek] on [Ration].[IdDayWeek] = [DayWeek].[Id] " +
                        $"join [Dish] as [DishBreakfast] on [Ration].[IdDishBreakfast] = [DishBreakfast].[Id] " +
                        $"join [Dish] as [DishLunch] on [Ration].[IdDishLunch] = [DishLunch].[Id] " +
                        $"join [Dish] as [DishDinner] on [Ration].[IdDishDinner] = [DishDinner].[Id] " +
                        $"where [IdUser] = {user.Id}", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ration ration = new Ration(reader.GetInt32(0), user, new DayWeek(reader.GetInt32(1), reader.GetString(2)),
                                new Dish(reader.GetInt32(3), reader.GetString(4), reader.GetInt32(5), reader.GetString(6)),
                                new Dish(reader.GetInt32(7), reader.GetString(8), reader.GetInt32(9), reader.GetString(10)),
                                new Dish(reader.GetInt32(11), reader.GetString(12), reader.GetInt32(13), reader.GetString(14)),
                                reader.GetInt32(15));
                            rations.Add(ration);
                        }
                    }
                }
                logger.Debug($"Получен рацион пользователя {user.Id} ид, {rations.Count}");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
           
            return rations;
        }
    }
}
