using Practice_3_01_Gundorov.ModelEF;
using Practice_3_01_Gundorov.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_3_01_Gundorov
{
    public partial class MainForm : Form
    {
        static public Form FORM = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            //Проверка на заполнение полей 
            if (LoginTxt.Text == "" || PswdTxt.Text == "")
            {
                MessageBox.Show("Введите логин и пароль в указанные ниже поля!");
                return;
            }
            Users usr = Program.db.Users.Find(LoginTxt.Text);

            if (PswdTxt.TextLength <6)
            {
                MessageBox.Show("Длина пароля должна быть не менее 6 символов!");

            }
            else
            {
                if ((usr != null) && (usr.Password == PswdTxt.Text))
                {
                    Program.USER = usr;
                    FORM = this;
                    switch (usr.RoleID)
                    {
                        case 1:
                            DirectorForm frmD = new DirectorForm();
                            frmD.Show();
                            this.Hide();
                            break;
                        case 2:
                            ManagerForm frmM = new ManagerForm();
                            frmM.Show();
                            this.Hide();
                            break;
                        case 3:
                            AdminForm frmA = new AdminForm();
                            frmA.Show();
                            this.Hide();
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Данный пользователь не найден!");
                    return;
                }
            }
           
        }
    }
}
