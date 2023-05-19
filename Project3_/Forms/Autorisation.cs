using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Project3_.Forms;
using Project3_.Models;
using Project3_.Classes;
using NLog;

namespace Project3_
{
    public partial class Autorisation : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Autorisation()
        {
            InitializeComponent();

        }

        private void Autorisation_Load(object sender, EventArgs e)
        {
            textBoxLogin.AutoSize = false;
            textBoxLogin.Height = 32;
            textBoxLogin.ForeColor = Color.Gray;
            textBoxPassword.AutoSize = false;
            textBoxPassword.ForeColor = Color.Gray;
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                textBoxLogin.Text = @"Логин";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == @"Логин")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                textBoxPassword.Text = "Пароль";
                textBoxPassword.ForeColor = Color.Gray;
            }

        }
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            User user = User.Authorizarion(login, password);
            if (user == null)
            {
                logger.Info($"Неудачная попытка входа (Логин: {login}, пароль {password})");
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                logger.Info($"Вход в систему (Ид: {user.Id}, логин: {user.Login})");
                MessageBox.Show("Добро пожаловать", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                Hide();
                textBoxLogin.Text = @"Логин\Email";
                textBoxLogin.ForeColor = Color.Black;
                textBoxPassword.Text = "Пароль";
                textBoxPassword.ForeColor = Color.Black;
            }
        }


        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar)
            {
                textBoxPassword.UseSystemPasswordChar = false;           
                pictureBoxHide.Image = Properties.Resources.eye1_112378;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                pictureBoxHide.Image = Properties.Resources.eye_112470;
            }
        }

        private void linkLabelRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Hide();
            textBoxLogin.Text = @"Логин";
            textBoxLogin.ForeColor = Color.Gray;
            textBoxPassword.Text = "Пароль";
            textBoxPassword.ForeColor = Color.Gray;
        }
    }
}
