namespace kyrsovaiDatabase
{
    partial class Form2
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
            this.textBoxaddID = new System.Windows.Forms.TextBox();
            this.textBoxADDdestination = new System.Windows.Forms.TextBox();
            this.textBoxADDdeparture = new System.Windows.Forms.TextBox();
            this.textBoxADDarrival = new System.Windows.Forms.TextBox();
            this.textBoxADDcount = new System.Windows.Forms.TextBox();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxaddID
            // 
            this.textBoxaddID.Location = new System.Drawing.Point(148, 86);
            this.textBoxaddID.Name = "textBoxaddID";
            this.textBoxaddID.Size = new System.Drawing.Size(229, 22);
            this.textBoxaddID.TabIndex = 0;
            this.textBoxaddID.TextChanged += new System.EventHandler(this.textBoxaddID_TextChanged);
            // 
            // textBoxADDdestination
            // 
            this.textBoxADDdestination.Location = new System.Drawing.Point(148, 132);
            this.textBoxADDdestination.Name = "textBoxADDdestination";
            this.textBoxADDdestination.Size = new System.Drawing.Size(229, 22);
            this.textBoxADDdestination.TabIndex = 1;
            // 
            // textBoxADDdeparture
            // 
            this.textBoxADDdeparture.Location = new System.Drawing.Point(148, 183);
            this.textBoxADDdeparture.Name = "textBoxADDdeparture";
            this.textBoxADDdeparture.Size = new System.Drawing.Size(229, 22);
            this.textBoxADDdeparture.TabIndex = 2;
            // 
            // textBoxADDarrival
            // 
            this.textBoxADDarrival.Location = new System.Drawing.Point(148, 229);
            this.textBoxADDarrival.Name = "textBoxADDarrival";
            this.textBoxADDarrival.Size = new System.Drawing.Size(229, 22);
            this.textBoxADDarrival.TabIndex = 3;
            // 
            // textBoxADDcount
            // 
            this.textBoxADDcount.Location = new System.Drawing.Point(148, 281);
            this.textBoxADDcount.Name = "textBoxADDcount";
            this.textBoxADDcount.Size = new System.Drawing.Size(229, 22);
            this.textBoxADDcount.TabIndex = 4;
            this.textBoxADDcount.TextChanged += new System.EventHandler(this.textBoxADDcount_TextChanged);
            // 
            // buttonADD
            // 
            this.buttonADD.Location = new System.Drawing.Point(190, 351);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(104, 42);
            this.buttonADD.TabIndex = 5;
            this.buttonADD.Text = "Добавить";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(65, 351);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 42);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "№ рейса";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(13, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(129, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Пункт назначения";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(12, 183);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Время вылета ";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(12, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(130, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Время прибытия";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.Location = new System.Drawing.Point(12, 281);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(130, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Свободные места";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.textBoxADDcount);
            this.Controls.Add(this.textBoxADDarrival);
            this.Controls.Add(this.textBoxADDdeparture);
            this.Controls.Add(this.textBoxADDdestination);
            this.Controls.Add(this.textBoxaddID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxaddID;
        private System.Windows.Forms.TextBox textBoxADDdestination;
        private System.Windows.Forms.TextBox textBoxADDdeparture;
        private System.Windows.Forms.TextBox textBoxADDarrival;
        private System.Windows.Forms.TextBox textBoxADDcount;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}