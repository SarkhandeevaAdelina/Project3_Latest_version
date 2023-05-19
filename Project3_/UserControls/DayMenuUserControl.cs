using Project3_.Forms;
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

namespace Project3_.UserControls
{
    public partial class DayMenuUserControl : UserControl
    {
        private Ration ration;
        public DayMenuUserControl(Ration ration)
        {
            InitializeComponent();
            this.ration = ration;
        }

        private void DayMenuUserControl_Load(object sender, EventArgs e)
        {
            labelDayWeek.Text = ration.DayWeek.Name;
            labelBreakfast.Text = ration.DishBreakfast.Name;
            labelLunch.Text = ration.DishLunch.Name;
            labelDinner.Text = ration.DishDinner.Name;
            labelKal.Text = $"Калории   {ration.Kal}";
        }

        private void OpenDayMenuInfo_Click(object sender, EventArgs e)
        {
            DayMenuForm dayMenuForm = new DayMenuForm(ration);
            dayMenuForm.ShowDialog();
        }
    }
}
