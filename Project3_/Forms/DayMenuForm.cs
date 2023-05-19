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

namespace Project3_.Forms
{
    public partial class DayMenuForm : Form
    {
        private Ration ration;

        public DayMenuForm(Ration ration)
        {
            InitializeComponent();
            this.ration = ration;
        }

        private void DayMenuForm_Load(object sender, EventArgs e)
        {
            labelDayWeek.Text = ration.DayWeek.Name;
            labelBreakfastDish.Text = ration.DishBreakfast.Name;
            foreach(Ingredient ingredient in Ingredient.GetDishIngredients(ration.DishBreakfast.Id))
            {
                labelBreakfastIngredients.Text += $"{ingredient.Name}\n";
            }
            labelBreakfastKal.Text = ration.DishBreakfast.Kal.ToString();

            labelLunchDish.Text = ration.DishLunch.Name;
            foreach (Ingredient ingredient in Ingredient.GetDishIngredients(ration.DishLunch.Id))
            {
                labelLunchIngredients.Text += $"{ingredient.Name}\n";
            }
            labelLunchKal.Text = ration.DishLunch.Kal.ToString();

            labelDinnerDish.Text = ration.DishDinner.Name;
            foreach (Ingredient ingredient in Ingredient.GetDishIngredients(ration.DishDinner.Id))
            {
                labelDinnerIngredients.Text += $"{ingredient.Name}\n";
            }
            labeDinnerKal.Text = ration.DishDinner.Kal.ToString();
        }
    }
}
