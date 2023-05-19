using Project3_.Classes;
using Project3_.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project3_.Forms
{
    public partial class AccountForm : Form
    {
        private User user;

        public AccountForm(User user)
        {
            InitializeComponent();
            this.user = user;

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            labelName.Text = user.FirstName;
            labelSurname.Text = user.SecondName;
            labelGoal.Text = user.Goal;
            labelGender.Text = user.Gender;
            labelWeight.Text = user.Weight.ToString();
            labelBMI.Text = user.BMI.ToString();
            string bmiStatus = BMIcalculator.GetBMIStatus(user.BMI, user.Gender);
            labelBMIStatus.Text = bmiStatus;
            if (bmiStatus == "В норме")
            {
                labelBMI.BackColor = Color.FromArgb(228, 255, 183);
            }
            else
            {
                labelBMI.BackColor = Color.FromArgb(254, 202, 202);
            }
        }
    }
}
