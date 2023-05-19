using NLog;
using Project3_.Classes;
using Project3_.Forms;
using Project3_.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_
{
    public partial class Registration : Form
    {
        private bool isExit = true;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            textBoxEmail.AutoSize = false;
            textBoxEmail.Height = 32;
            textBoxLogin.AutoSize = false;
            textBoxLogin.Height = 32;
            textBoxPasswod.AutoSize = false;
            textBoxPasswod.Height = 32;
            textBoxSecondPassword.AutoSize = false;
            textBoxSecondPassword.Height = 32;
            textBoxSecondName.AutoSize = false;
            textBoxSecondName.Height = 32;
            textBoxFirstName.AutoSize = false;
            textBoxFirstName.Height = 32;
            textBoxPatronymic.AutoSize = false;
            textBoxPatronymic.Height = 32;
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Equals("Логин"))
            {
                textBoxLogin.Clear();
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLogin.Text))
            {
                textBoxLogin.Text = "Логин";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = Color.Gray;
            }
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswod_Enter(object sender, EventArgs e)
        {
            if (textBoxPasswod.Text.Equals("Пароль"))
            {
                textBoxPasswod.Clear();
                textBoxPasswod.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswod_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPasswod.Text))
            {
                textBoxPasswod.Text = "Пароль";
                textBoxPasswod.ForeColor = Color.Gray;
            }
        }

        private void textBoxSecondPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSecondPassword.Text))
            {
                textBoxSecondPassword.Text = "Повторите пароль";
                textBoxSecondPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxSecondPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxSecondPassword.Text.Equals("Повторите пароль"))
            {
                textBoxSecondPassword.Clear();
                textBoxSecondPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                textBoxFirstName.Text = "Имя";
                textBoxFirstName.ForeColor = Color.Gray;
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text.Equals("Имя"))
            {
                textBoxFirstName.Clear();
                textBoxFirstName.ForeColor = Color.Black;
            }
        }

        private void textBoxSurename_Enter(object sender, EventArgs e)
        {
            if (textBoxSecondName.Text.Equals("Фамилия"))
            {
                textBoxSecondName.Clear();
                textBoxSecondName.ForeColor = Color.Black;
            }
        }

        private void textBoxSurename_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSecondName.Text))
            {
                textBoxSecondName.Text = "Фамилия";
                textBoxSecondName.ForeColor = Color.Gray;
            }
        }

        private void textBoxFathername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPatronymic.Text))
            {
                textBoxPatronymic.Text = "Отчество (если есть)";
                textBoxPatronymic.ForeColor = Color.Gray;
            }
        }

        private void textBoxFathername_Enter(object sender, EventArgs e)
        {
            if (textBoxPatronymic.Text.Equals("Отчество (если есть)"))
            {
                textBoxPatronymic.Clear();
                textBoxPatronymic.ForeColor = Color.Black;
            }
        }

        private void buttonRegestration_Click(object sender, EventArgs e)
        {
            string emailPattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            string email = textBoxEmail.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPasswod.Text;
            string secondPassword = textBoxSecondPassword.Text;
            string secondName = textBoxSecondName.Text;
            string firstName = textBoxFirstName.Text;
            string patronymic = textBoxPatronymic.Text;
            if (string.IsNullOrWhiteSpace(email) || email == "Email" || string.IsNullOrWhiteSpace(login) || email == "Логин" 
                || string.IsNullOrWhiteSpace(password) || email == "Пароль" || string.IsNullOrWhiteSpace(secondPassword) || secondPassword == "Повторите пароль" 
                || string.IsNullOrWhiteSpace(firstName) || email == "Имя" || string.IsNullOrWhiteSpace(secondName) || email == "Фамилия")
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != secondPassword)
            {
                MessageBox.Show("Пароли различаются", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (User.ExistEmail(email))
            {
                MessageBox.Show("Email уже используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (User.ExistLogin(login))
            {
                MessageBox.Show("Логин уже используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.Match(email, emailPattern, RegexOptions.IgnoreCase).Success)
            {
                MessageBox.Show("Email введен не верно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InputDialog inputDialog = new InputDialog(email);
                DialogResult dialogResult = inputDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    logger.Info($"Неудачная регистрация, почта неподтверждена (Логин: {login}, email: {email})");
                    MessageBox.Show("Вы не подтвердили почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(patronymic) || patronymic == "Отчество (если есть)")
                    {
                        User.Registration(email, login, password, secondName, firstName);
                    }
                    else
                    {
                        User.Registration(email, login, password, secondName, firstName, patronymic);
                    }
                    logger.Info($"Регистрация в системе (Логин: {login}, email: {email})");
                    MessageBox.Show("Вы успешно зарегистрировались", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isExit = false;
                    Close();
                }
            }
        }

        private void linkLabelAutorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isExit = false;
            Close();
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
            else
            {
                (Application.OpenForms[0] as Autorisation).Show();
            }
        }
    }
}
