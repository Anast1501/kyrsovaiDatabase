namespace kyrsovaiDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.PlaneDataGrid = new System.Windows.Forms.DataGridView();
            this.RaceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textPlaneIdDel = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.CityFound = new System.Windows.Forms.DataGridView();
            this.ColumnPlaneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFreeSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityFound)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1154, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1154, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1154, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 38);
            this.button3.TabIndex = 0;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1154, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 38);
            this.button4.TabIndex = 0;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PlaneDataGrid
            // 
            this.PlaneDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlaneDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RaceNumber,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.PlaneDataGrid.Location = new System.Drawing.Point(23, 199);
            this.PlaneDataGrid.Name = "PlaneDataGrid";
            this.PlaneDataGrid.RowHeadersVisible = false;
            this.PlaneDataGrid.RowHeadersWidth = 51;
            this.PlaneDataGrid.RowTemplate.Height = 24;
            this.PlaneDataGrid.Size = new System.Drawing.Size(1210, 325);
            this.PlaneDataGrid.TabIndex = 1;
            this.PlaneDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RaceNumber
            // 
            this.RaceNumber.HeaderText = "№ рейса";
            this.RaceNumber.MinimumWidth = 6;
            this.RaceNumber.Name = "RaceNumber";
            this.RaceNumber.Width = 105;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "пункт назначения ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "время вылета";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "время прибытия ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "количество свободных мест в салоне";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 200;
            // 
            // textPlaneIdDel
            // 
            this.textPlaneIdDel.Location = new System.Drawing.Point(1022, 143);
            this.textPlaneIdDel.Name = "textPlaneIdDel";
            this.textPlaneIdDel.Size = new System.Drawing.Size(100, 22);
            this.textPlaneIdDel.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(1022, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(96, 15);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "№ рейса";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Волгоград",
            "Горно-Алтайск",
            "Иркутск",
            "Казань",
            "Краснодар",
            "Красноярск",
            "Москва",
            "Новосибирск",
            "Санкт-Петербург",
            "Улан-Удэ"});
            this.comboBox1.Location = new System.Drawing.Point(618, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(618, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 15);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Выберите город:";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonFind
            // 
            this.buttonFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFind.Location = new System.Drawing.Point(775, 73);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(85, 39);
            this.buttonFind.TabIndex = 6;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // CityFound
            // 
            this.CityFound.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.CityFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityFound.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlaneId,
            this.ColumnFreeSpace});
            this.CityFound.Location = new System.Drawing.Point(261, 51);
            this.CityFound.Name = "CityFound";
            this.CityFound.RowHeadersVisible = false;
            this.CityFound.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.CityFound.RowTemplate.Height = 24;
            this.CityFound.Size = new System.Drawing.Size(341, 133);
            this.CityFound.TabIndex = 7;
            // 
            // ColumnPlaneId
            // 
            this.ColumnPlaneId.HeaderText = "№ рейса";
            this.ColumnPlaneId.MinimumWidth = 6;
            this.ColumnPlaneId.Name = "ColumnPlaneId";
            this.ColumnPlaneId.Width = 125;
            // 
            // ColumnFreeSpace
            // 
            this.ColumnFreeSpace.HeaderText = "Свободные места";
            this.ColumnFreeSpace.MinimumWidth = 6;
            this.ColumnFreeSpace.Name = "ColumnFreeSpace";
            this.ColumnFreeSpace.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 524);
            this.Controls.Add(this.CityFound);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textPlaneIdDel);
            this.Controls.Add(this.PlaneDataGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Flight Schedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityFound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView PlaneDataGrid;
        private System.Windows.Forms.TextBox textPlaneIdDel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView CityFound;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlaneId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFreeSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn RaceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

