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
    public partial class RationForm : Form
    {
        private User user;

        public RationForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Test test = new Test(user);
            test.ShowDialog();
        }

        private void RationForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(user.Goal))
            {
                startButton.Text = "Пройти тест повторно";
            }
        }
    }
}
