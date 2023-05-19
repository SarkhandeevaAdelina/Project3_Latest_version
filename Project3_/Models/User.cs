using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project3_.Models
{
    public class User
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string SecondName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public List<Allergy> Allergies { get; set; }
        public string Sport { get; set; }
        public string Goal { get; set; }
        public double BMI { get; set; }

        public User(int id, string email, string login, string password, string secondName, string firstName, string patronymic)
        {
            Id = id;
            Email = email;
            Login = login;
            Password = password;
            SecondName = secondName;
            FirstName = firstName;
            Patronymic = patronymic;
        }

        public User(int id, string email, string login, string password, string secondName, string firstName, string patronymic, string gender, int weight, int height, List<Allergy> allergies, string sport, string goal, int bMI) : this(id, email, login, password, secondName, firstName, patronymic)
        {
            Gender = gender;
            Weight = weight;
            Height = height;
            Allergies = allergies;
            Sport = sport;
            Goal = goal;
            BMI = bMI;
        }

        public static User Authorizarion(string login, string password)
        {
            User user = null;
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select * from [User] where Login = '{login}' and password = '{password}'", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));

                            if (!reader.IsDBNull(7))
                            {
                                user.Gender = reader.GetString(7);
                                user.Weight = reader.GetInt32(8);
                                user.Height = reader.GetInt32(9);
                                user.Sport = reader.GetString(10);
                                user.Goal = reader.GetString(11);
                                user.BMI = reader.GetDouble(12);
                            }
                            logger.Debug($"Получения пользователя по логину ({login}) и паролю ({password}), {user.Id} ид пользователя");
                        }
                        else
                        {
                            logger.Debug($"Не получен пользователь из базы по ({login}) и паролю ({password})");
                            user = null;
                        }
                    }
                    if (user != null)
                    {
                        List<Allergy> allergies = new List<Allergy>();
                        command = new SqlCommand($"select [Allergy].[Id], [Allergy].[Name] from [UserAllergy] " +
                            $"join [Allergy] on [Allergy].[Id] = [UserAllergy].[IdAllergy] where [IdUser] = '{user.Id}'", connection);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                allergies.Add(new Allergy(reader.GetInt32(0), reader.GetString(1)));
                            }
                        }
                        user.Allergies = allergies;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

            return user;
        }

        public static void Registration(string email, string login, string password, string secondName, string firstName, string patronymic = null)
        {
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    string query;
                    if (patronymic == null)
                    {
                        query = "insert into [User] ([Email], [Login], [Password], [SecondName], [FirstName]) " +
                            $"values (N'{email}', N'{login}', N'{password}', N'{secondName}', N'{firstName}')";
                    }
                    else
                    {
                        query = "insert into [User] ([Email], [Login], [Password], [SecondName], [FirstName], [Patronymic]) " +
                            $"values (N'{email}', N'{login}', N'{password}', N'{secondName}', N'{firstName}', N'{patronymic}')";
                    }
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                logger.Debug($"Добавление пользователя в базу данных, email: {email}, логин: {login}");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

        }

        public static bool ExistEmail(string email)
        {
            int count = 0;
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select count(*) from [User] where [Email] = '{email}'", connection);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
                logger.Debug($"Получения количесвто email в базе данных, {count} - количество");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
            return count > 0;
        }

        public static bool ExistLogin(string login)
        {
            int count = 0;
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"select count(*) from [User] where [Login] = '{login}'", connection);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
                logger.Debug($"Получения количесвто логинов в базе данных, {count} - количество");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
            return count > 0;
        }

        public static void UpateTest(int idUser, string gender, int weight, int height, List<Allergy> allergies, string sport, string goal, double bmi)
        {
            try
            {
                using (SqlConnection connection = DB.Connection)
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand($"update [User] set [Gender] = N'{gender}', [Weight] = {weight}, [Height] = {height}, [Sport] = N'{sport}', [Goal] = N'{goal}', [BMI] = '{bmi.ToString().Replace(',', '.')}' " +
                        $"where Id = {idUser}", connection);
                    command.ExecuteNonQuery();
                    command = new SqlCommand($"delete from [UserAllergy] where [IdUser] = {idUser}", connection);
                    command.ExecuteNonQuery();
                    foreach (Allergy allergy in allergies)
                    {
                        command = new SqlCommand($"insert into [UserAllergy] values ({idUser}, {allergy.Id})", connection);
                        command.ExecuteNonQuery();
                    }
                }
                logger.Debug($"Обновление теста, {idUser} ид пользователя");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}
