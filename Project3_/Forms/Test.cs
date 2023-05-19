using NLog;
using Project3_.Classes;
using Project3_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project3_.Forms
{
    public partial class Test : Form
    {
        private List<Allergy> allergies = Allergy.GetAllergies();
        private int currentQuestion = 0;
        private User user;
        private Random random= new Random();
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Test(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            textBoxWeight.AutoSize = false;
            textBoxWeight.Height = 32;
            textBoxHeight.AutoSize = false;
            textBoxHeight.Height = 32;
            radioButtonWomen.Checked = false;
            radioButtonMen.Checked = false;
            foreach (Allergy allergy in allergies)
            {
                checkedListBoxAllegries.Items.Add(allergy.Name);
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestion == -1)
            {
                Close();
            }
            else if (currentQuestion == 6)
            {
                if (!radioButtonWomen.Checked && !radioButtonMen.Checked)
                {
                    MessageBox.Show("Ответьте на первый вопрос теста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(textBoxWeight.Text))
                {
                    MessageBox.Show("Ответьте на второй вопрос теста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(textBoxHeight.Text))
                {
                    MessageBox.Show("Ответьте на третий вопрос теста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!radioButtonNoSport.Checked && !radioButtonHomeSport.Checked && !radioButtonGymSport.Checked)
                {
                    MessageBox.Show("Ответьте на пятый вопрос теста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!radioButtonGainWeight.Checked && !radioButtonLoseWeight.Checked && !radioButtonKeepFit.Checked)
                {
                    MessageBox.Show("Ответьте на шестой вопрос теста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Ration.RemoveUserRations(user);
                    string gender;
                    if (radioButtonWomen.Checked)
                    {
                        gender = radioButtonWomen.Text;
                    }
                    else
                    {
                        gender = radioButtonMen.Text;
                    }
                    int weight = int.Parse(textBoxWeight.Text);
                    int height = int.Parse(textBoxHeight.Text);
                    List<Allergy> userAllegries = new List<Allergy>();
                    for(int i= 0; i< checkedListBoxAllegries.Items.Count; i++)
                    {
                        if (checkedListBoxAllegries.GetItemChecked(i))
                        {
                            userAllegries.Add(allergies[i]);
                        }
                    }
                    string sport;
                    if (radioButtonNoSport.Checked)
                    {
                        sport = radioButtonNoSport.Text;
                    }
                    else if (radioButtonHomeSport.Checked)
                    {
                        sport =radioButtonHomeSport.Text;
                    }
                    else
                    {
                        sport = radioButtonGymSport.Text;
                    }
                    string goal;
                    if (radioButtonGainWeight.Checked)
                    {
                        goal = radioButtonGainWeight.Text;
                    }
                    else if (radioButtonLoseWeight.Checked)
                    {
                        goal = radioButtonLoseWeight.Text;
                    }
                    else
                    {
                        goal = radioButtonKeepFit.Text;
                    }
                    double bmi = BMIcalculator.CalculateBMI(weight, height);
                    User.UpateTest(user.Id, gender, weight, height, userAllegries, sport, goal,  bmi);
                    user.Gender = gender;
                    user.Weight = weight;
                    user.Height = height;
                    user.Allergies = userAllegries;
                    user.Sport = sport;
                    user.Goal = goal;
                    user.BMI = bmi;
                    string bmiStatus = BMIcalculator.GetBMIStatus(bmi, gender);
                    if (bmiStatus == "Ниже нормы" && sport == "Не занимаюсь")
                    {
                        AddRation(300, 600, 600);
                    }
                    else if (bmiStatus == "Ниже нормы" && sport == "Занимаюсь дома")
                    {
                        AddRation(400, 800, 800);
                    }
                    else if (bmiStatus == "Ниже нормы" && sport == "Хожу в зал")
                    {
                        AddRation(500, 1000, 1000);
                    }
                    else if (bmiStatus == "В норме" && sport == "Не занимаюсь")
                    {
                        AddRation(300, 600, 600);
                    }
                    else if (bmiStatus == "В норме" && sport == "Занимаюсь дома")
                    {
                        AddRation(400, 800, 800);
                    }
                    else if (bmiStatus == "В норме" && sport == "Хожу в зал")
                    {
                        AddRation(500, 1000, 1000);
                    }
                    else if (bmiStatus == "Выше нормы" && sport == "Не занимаюсь")
                    {
                        AddRation(200, 400, 400);
                    }
                    else if (bmiStatus == "Выше нормы" && sport == "Занимаюсь дома")
                    {
                        AddRation(300, 600, 600);
                    }
                    else if (bmiStatus == "Выше нормы" && sport == "Хожу в зал")
                    {
                        AddRation(400, 800, 800);
                    }
                   logger.Info($"Прохожение теста, (Ид пользователя: {user.Id}, ИМТ: {bmi}, статус: {bmiStatus})");
                    MessageBox.Show("Вы успешно прошли тест", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                currentQuestion--;
            }
            else
            {
                if (currentQuestion == 5)
                {
                    nextButton.Text = "Завершить";
                }
                else
                {
                    nextButton.Text = "Следующий";
                }
                for (int i = 0; i < testTableLayout.ColumnStyles.Count; i++)
                {
                    if (i != currentQuestion)
                    {
                        testTableLayout.ColumnStyles[i] = new ColumnStyle(SizeType.Absolute, 0);
                    }
                    else
                    {
                        testTableLayout.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, 100);
                    }
                }
            }
        }

        private void AddRation(int breakfastKal, int lunchKal, int dinnerKal)
        {
            List<DayWeek> dayWeeks = DayWeek.GetDaysWeek();
            List<Dish> usedDishes = new List<Dish>();
            List<Dish> dishesBreakfast = Dish.GetDishesByKalAndDishType(breakfastKal, "Завтрак");
            List<Dish> dishesLunch = Dish.GetDishesByKalAndDishType(lunchKal, "Обед");
            List<Dish> dishesDinner = Dish.GetDishesByKalAndDishType(dinnerKal, "Ужин");
            for (int i = 0; i < 7; i++)
            {
                DayWeek dayWeek = dayWeeks[i];
                Dish dishBreakfast;
                while (true)
                {
                    dishBreakfast = dishesBreakfast[random.Next(dishesBreakfast.Count)];
                    if (!Exist2Dish(usedDishes, dishBreakfast))
                    {
                        usedDishes.Add(dishBreakfast);
                        break;
                    }
                }
                Dish dishLunch;
                while (true)
                {
                    dishLunch = dishesLunch[random.Next(dishesLunch.Count)];
                    if (!Exist2Dish(usedDishes, dishLunch))
                    {
                        usedDishes.Add(dishLunch);
                        break;
                    }
                }
                Dish dishDinner;
                while (true)
                {
                    dishDinner = dishesDinner[random.Next(dishesDinner.Count)];
                    if (!Exist2Dish(usedDishes, dishDinner))
                    {
                        usedDishes.Add(dishDinner);
                        break;
                    }
                }
                Ration.AddRation(user.Id, dayWeek.Id, dishBreakfast.Id, dishLunch.Id, dishDinner.Id, breakfastKal + lunchKal + dinnerKal);
            }
        }

        private bool Exist2Dish(List<Dish> usedDish, Dish dish)
        {
            int counter = 0;
            foreach (Dish d in usedDish)
            {
                if (d.Id == dish.Id)
                {
                    counter++;
                }
            }
            return counter >= 2;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            currentQuestion--;
            DisplayQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            DisplayQuestion();
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}

