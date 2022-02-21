
namespace Practice_3_01_Gundorov.UserForms
{
    partial class ManagerForm
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnReport4 = new System.Windows.Forms.Button();
            this.BtnReport3 = new System.Windows.Forms.Button();
            this.LblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(137, 265);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 36);
            this.BtnBack.TabIndex = 3;
            this.BtnBack.Text = "Выйти";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnReport4
            // 
            this.BtnReport4.Location = new System.Drawing.Point(226, 162);
            this.BtnReport4.Name = "BtnReport4";
            this.BtnReport4.Size = new System.Drawing.Size(82, 34);
            this.BtnReport4.TabIndex = 4;
            this.BtnReport4.Text = "Отчет 4";
            this.BtnReport4.UseVisualStyleBackColor = true;
            // 
            // BtnReport3
            // 
            this.BtnReport3.Location = new System.Drawing.Point(65, 162);
            this.BtnReport3.Name = "BtnReport3";
            this.BtnReport3.Size = new System.Drawing.Size(75, 34);
            this.BtnReport3.TabIndex = 5;
            this.BtnReport3.Text = "Отчет 3";
            this.BtnReport3.UseVisualStyleBackColor = true;
            // 
            // LblHello
            // 
            this.LblHello.AutoSize = true;
            this.LblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHello.Location = new System.Drawing.Point(61, 64);
            this.LblHello.Name = "LblHello";
            this.LblHello.Size = new System.Drawing.Size(131, 20);
            this.LblHello.TabIndex = 2;
            this.LblHello.Text = "Добрый день, ";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 361);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnReport4);
            this.Controls.Add(this.BtnReport3);
            this.Controls.Add(this.LblHello);
            this.MaximumSize = new System.Drawing.Size(406, 400);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnReport4;
        private System.Windows.Forms.Button BtnReport3;
        private System.Windows.Forms.Label LblHello;
    }
}