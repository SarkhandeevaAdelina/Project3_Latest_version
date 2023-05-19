using NLog;
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
    public partial class InputDialog : Form
    {
        private Random random = new Random();
        private string email;
        private string code;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public InputDialog(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {
            code = random.Next(10000000, 100000000).ToString();
            try
            {
                ClassMailPassword classMailPassword = new ClassMailPassword(email, code);
                classMailPassword.MailMessag();
            }
            catch
            {
                logger.Error($"Не удалось отправить письмо на почту {email})");
                MessageBox.Show("Не удалось отправить письмо на почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string userCode = textBoxCode.Text;
            if (userCode == code)
            {
                logger.Info($"Почта подтвеждрена {email}");
                MessageBox.Show("Вы успешно подтвердили почту", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {

                MessageBox.Show("Код введен неправильно, возможно вы неверно указали почту", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        { 
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
