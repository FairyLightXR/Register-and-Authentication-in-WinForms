using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3_01_Gundorov.UserForms
{
    public partial class AdminForm : Form
    {
        public Form prevForm = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LblHello.Text = LblHello.Text + Program.USER.FIO + "!";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.FORM.Show();
        }
        /// <summary>
        /// Обработчик события для регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm(); //Создание объекта формы регистрации
            reg.prevForm = this;
            reg.Show();

        }
    }
}
