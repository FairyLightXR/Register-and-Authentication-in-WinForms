
namespace Practice_3_01_Gundorov.UserForms
{
    partial class DirectorForm
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
            this.BtnReport1 = new System.Windows.Forms.Button();
            this.BtnReport2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHello
            // 
            this.LblHello.AutoSize = true;
            this.LblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHello.Location = new System.Drawing.Point(39, 73);
            this.LblHello.Name = "LblHello";
            this.LblHello.Size = new System.Drawing.Size(131, 20);
            this.LblHello.TabIndex = 0;
            this.LblHello.Text = "Добрый день, ";
            // 
            // BtnReport1
            // 
            this.BtnReport1.Location = new System.Drawing.Point(65, 158);
            this.BtnReport1.Name = "BtnReport1";
            this.BtnReport1.Size = new System.Drawing.Size(75, 34);
            this.BtnReport1.TabIndex = 1;
            this.BtnReport1.Text = "Отчет 1";
            this.BtnReport1.UseVisualStyleBackColor = true;
            // 
            // BtnReport2
            // 
            this.BtnReport2.Location = new System.Drawing.Point(226, 158);
            this.BtnReport2.Name = "BtnReport2";
            this.BtnReport2.Size = new System.Drawing.Size(82, 34);
            this.BtnReport2.TabIndex = 1;
            this.BtnReport2.Text = "Отчет 2";
            this.BtnReport2.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(151, 269);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 36);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Выйти";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 361);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnReport2);
            this.Controls.Add(this.BtnReport1);
            this.Controls.Add(this.LblHello);
            this.MaximumSize = new System.Drawing.Size(406, 400);
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма Директора";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHello;
        private System.Windows.Forms.Button BtnReport1;
        private System.Windows.Forms.Button BtnReport2;
        private System.Windows.Forms.Button BtnBack;
    }
}