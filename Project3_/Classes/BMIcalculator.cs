using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_.Classes
{
    public static class BMIcalculator
    {
        public static double CalculateBMI(int weight, double height)
        {
            height = height / 100;
            return Math.Round(weight / (height * height), 1);
        }

        public static string GetBMIStatus(double bmi, string gender)
        {
            if (gender == "Мужской")
            {
                if (bmi < 18.5)
                {
                    return "Ниже нормы";
                }
                else if (bmi >= 18.5 && bmi <= 25)
                {
                    return "В норме";
                }
                else
                {
                    return "Выше нормы";
                }
            }
            else
            {
                if (bmi < 18.5)
                {
                    return "Ниже нормы";
                }
                else if (bmi >= 18.5 && bmi <= 24)
                {
                    return "В норме";
                }
                else
                {
                    return "Выше нормы";
                }
            }
        }

        public static int GetKAL(string bmiStatus, string sport)
        {
            if (bmiStatus == "Ниже нормы")
            {
                if (sport == "Не занимаюсь")
                {
                    return 1500;
                }
                else if (sport == "Занимаюсь дома")
                {
                    return 2000;
                }
                else
                {
                    return 2500;
                }
            }
            else if (bmiStatus == "В норме")
            {
                if (sport == "Не занимаюсь")
                {
                    return 1300;
                }
                else if (sport == "Занимаюсь дома")
                {
                    return 1800;
                }
                else
                {
                    return 2500;
                }
            }
            else
            {
                if (sport == "Не занимаюсь")
                {
                    return 1000;
                }
                else if (sport == "Занимаюсь дома")
                {
                    return 1300;
                }
                else
                {
                    return 1800;
                }
            }
        }
    }
}
