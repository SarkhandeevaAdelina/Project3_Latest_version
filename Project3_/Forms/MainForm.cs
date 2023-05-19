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
    public partial class MainForm : Form
    {
        private Form activeForm;
        private User user;

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new NoActiveForm());
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountForm(user));
            labelTitle.Text = "Аккаунт";
        }

        private void buttonRation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RationForm(user));
            labelTitle.Text = "Рацион";
        }

        private void buttonRecipes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuForm(user));
            labelTitle.Text = "Меню";
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            activeForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
