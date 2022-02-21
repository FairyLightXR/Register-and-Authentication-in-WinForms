using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice_3_01_Gundorov.ModelEF;
using Practice_3_01_Gundorov.UserForms;

namespace Practice_3_01_Gundorov.UserForms
{
    public partial class RegisterForm : Form
    {
        public Form prevForm = null;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            rolesBindingSource.DataSource = Program.db.Roles.ToList();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            prevForm.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (TxtLogin.Text == "" || TxtPsw.Text == "" 
                || TxtPsw2.Text == "" || TxtFIO.Text =="")
            {
                MessageBox.Show("Не все данные введены!");
                return;

            }
            if (TxtPsw.Text != TxtPsw2.Text)
            {
                MessageBox.Show("Введённые пароль не совпадает с первым");
                return;
            }
            Users usr = Program.db.Users.Find(TxtLogin.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return;
            }
            else
            {
                usr = new Users();
                usr.Login = TxtLogin.Text;
                usr.Password = TxtPsw.Text;
                usr.RoleID = (int)CmbRoles.SelectedValue;
                usr.FIO = TxtFIO.Text;
            }
            
            Program.db.Users.Add(usr);
            try
            {
                Program.db.SaveChanges();
                MessageBox.Show($"Пользователь {TxtLogin.Text} успешно зарегистрирован!");
                this.Hide();
                prevForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
