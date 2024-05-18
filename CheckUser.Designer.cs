namespace kyrsovaiDatabase
{
    partial class CheckUser
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
            this.textBoxUserPass = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserPass
            // 
            this.textBoxUserPass.Location = new System.Drawing.Point(25, 76);
            this.textBoxUserPass.Name = "textBoxUserPass";
            this.textBoxUserPass.Size = new System.Drawing.Size(352, 22);
            this.textBoxUserPass.TabIndex = 0;
            this.textBoxUserPass.TextChanged += new System.EventHandler(this.textBoxUserPass_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(111, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Введите пароль";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.Location = new System.Drawing.Point(132, 106);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(116, 23);
            this.ButtonCheck.TabIndex = 2;
            this.ButtonCheck.Text = "Подтвердить";
            this.ButtonCheck.UseVisualStyleBackColor = true;
            this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click_1);
            // 
            // CheckUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 141);
            this.Controls.Add(this.ButtonCheck);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxUserPass);
            this.Name = "CheckUser";
            this.Text = "ChekUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserPass;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ButtonCheck;
    }
}