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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            LblHello.Text = LblHello.Text + Program.USER.FIO + "!";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm.FORM.Show();
        }
    }
}
