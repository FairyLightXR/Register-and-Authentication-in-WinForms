
namespace Practice_3_01_Gundorov.UserForms
{
    partial class AdminForm
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
            this.LblHello = new System.Windows.Forms.Label();
            this.BtnAcc = new System.Windows.Forms.Button();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHello
            // 
            this.LblHello.AutoSize = true;
            this.LblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHello.Location = new System.Drawing.Point(22, 83);
            this.LblHello.Name = "LblHello";
            this.LblHello.Size = new System.Drawing.Size(131, 20);
            this.LblHello.TabIndex = 0;
            this.LblHello.Text = "Добрый день, ";
            // 
            // BtnAcc
            // 
            this.BtnAcc.Location = new System.Drawing.Point(99, 153);
            this.BtnAcc.Name = "BtnAcc";
            this.BtnAcc.Size = new System.Drawing.Size(167, 32);
            this.BtnAcc.TabIndex = 1;
            this.BtnAcc.Text = "Все учетные записи";
            this.BtnAcc.UseVisualStyleBackColor = true;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(99, 202);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(167, 30);
            this.BtnAddUser.TabIndex = 1;
            this.BtnAddUser.Text = "Добавить пользователя";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(145, 261);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 28);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Выйти";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 361);
            this.Controls.Add(this.BtnAddUser);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnAcc);
            this.Controls.Add(this.LblHello);
            this.MaximumSize = new System.Drawing.Size(406, 400);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHello;
        private System.Windows.Forms.Button BtnAcc;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button BtnBack;
    }
}