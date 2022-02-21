
namespace Practice_3_01_Gundorov.UserForms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtPsw = new System.Windows.Forms.TextBox();
            this.TxtPsw2 = new System.Windows.Forms.TextBox();
            this.TxtFIO = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CmbRoles = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация нового пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Пароль 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Роль";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ФИО";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(145, 104);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(100, 20);
            this.TxtLogin.TabIndex = 1;
            // 
            // TxtPsw
            // 
            this.TxtPsw.Location = new System.Drawing.Point(145, 152);
            this.TxtPsw.Name = "TxtPsw";
            this.TxtPsw.Size = new System.Drawing.Size(100, 20);
            this.TxtPsw.TabIndex = 1;
            // 
            // TxtPsw2
            // 
            this.TxtPsw2.Location = new System.Drawing.Point(145, 194);
            this.TxtPsw2.Name = "TxtPsw2";
            this.TxtPsw2.Size = new System.Drawing.Size(100, 20);
            this.TxtPsw2.TabIndex = 1;
            // 
            // TxtFIO
            // 
            this.TxtFIO.Location = new System.Drawing.Point(145, 292);
            this.TxtFIO.Name = "TxtFIO";
            this.TxtFIO.Size = new System.Drawing.Size(100, 20);
            this.TxtFIO.TabIndex = 1;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(33, 393);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(90, 36);
            this.BtnRegister.TabIndex = 2;
            this.BtnRegister.Text = "Регистрация";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(274, 393);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 36);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Выход";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbRoles
            // 
            this.CmbRoles.DataSource = this.rolesBindingSource;
            this.CmbRoles.DisplayMember = "Role";
            this.CmbRoles.FormattingEnabled = true;
            this.CmbRoles.Location = new System.Drawing.Point(124, 250);
            this.CmbRoles.Name = "CmbRoles";
            this.CmbRoles.Size = new System.Drawing.Size(121, 21);
            this.CmbRoles.TabIndex = 3;
            this.CmbRoles.ValueMember = "ID";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataSource = typeof(Practice_3_01_Gundorov.ModelEF.Roles);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 470);
            this.Controls.Add(this.CmbRoles);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TxtFIO);
            this.Controls.Add(this.TxtPsw2);
            this.Controls.Add(this.TxtPsw);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(407, 509);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtPsw;
        private System.Windows.Forms.TextBox TxtPsw2;
        private System.Windows.Forms.TextBox TxtFIO;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CmbRoles;
        private System.Windows.Forms.BindingSource rolesBindingSource;
    }
}