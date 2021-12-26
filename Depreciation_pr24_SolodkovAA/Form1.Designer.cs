namespace Depreciation_pr24_SolodkovAA
{
	partial class main_form
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
			this.table = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.price_object = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.finish = new System.Windows.Forms.Label();
			this.start = new System.Windows.Forms.Label();
			this.norm = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.calculate = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.month = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
			this.sum_a = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.price_object)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.month)).BeginInit();
			this.SuspendLayout();
			// 
			// table
			// 
			this.table.AllowUserToAddRows = false;
			this.table.AllowUserToDeleteRows = false;
			this.table.AllowUserToResizeColumns = false;
			this.table.AllowUserToResizeRows = false;
			dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
			this.table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
			this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.table.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle30.BackColor = System.Drawing.Color.DeepSkyBlue;
			dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
			dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.table.DefaultCellStyle = dataGridViewCellStyle31;
			this.table.EnableHeadersVisualStyles = false;
			this.table.GridColor = System.Drawing.SystemColors.Window;
			this.table.Location = new System.Drawing.Point(406, 53);
			this.table.MultiSelect = false;
			this.table.Name = "table";
			this.table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.table.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
			this.table.RowHeadersVisible = false;
			this.table.Size = new System.Drawing.Size(839, 475);
			this.table.TabIndex = 0;
			this.table.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(8, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Первоначальная стоимость";
			// 
			// price_object
			// 
			this.price_object.DecimalPlaces = 2;
			this.price_object.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.price_object.Location = new System.Drawing.Point(12, 80);
			this.price_object.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.price_object.Name = "price_object";
			this.price_object.Size = new System.Drawing.Size(261, 29);
			this.price_object.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.label5.Location = new System.Drawing.Point(5, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 37);
			this.label5.TabIndex = 9;
			this.label5.Text = "Параметры";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.sum_a);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.dateTimeStart);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.finish);
			this.panel1.Controls.Add(this.start);
			this.panel1.Controls.Add(this.norm);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.calculate);
			this.panel1.Controls.Add(this.clear);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.month);
			this.panel1.Controls.Add(this.price_object);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 540);
			this.panel1.TabIndex = 10;
			// 
			// finish
			// 
			this.finish.AutoSize = true;
			this.finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.finish.Location = new System.Drawing.Point(200, 375);
			this.finish.Name = "finish";
			this.finish.Size = new System.Drawing.Size(20, 24);
			this.finish.TabIndex = 18;
			this.finish.Text = "0";
			// 
			// start
			// 
			this.start.AutoSize = true;
			this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.start.Location = new System.Drawing.Point(200, 341);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(20, 24);
			this.start.TabIndex = 17;
			this.start.Text = "0";
			// 
			// norm
			// 
			this.norm.AutoSize = true;
			this.norm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.norm.Location = new System.Drawing.Point(200, 308);
			this.norm.Name = "norm";
			this.norm.Size = new System.Drawing.Size(20, 24);
			this.norm.TabIndex = 16;
			this.norm.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(8, 375);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(175, 24);
			this.label9.TabIndex = 15;
			this.label9.Text = "Последний месяц:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(8, 341);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(145, 24);
			this.label8.TabIndex = 14;
			this.label8.Text = "Первый месяц:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(8, 308);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(197, 24);
			this.label7.TabIndex = 13;
			this.label7.Text = "Норма амортизации:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
			this.label6.Location = new System.Drawing.Point(5, 260);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(162, 37);
			this.label6.TabIndex = 12;
			this.label6.Text = "Результат";
			// 
			// calculate
			// 
			this.calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.calculate.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.calculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.calculate.Location = new System.Drawing.Point(103, 482);
			this.calculate.Name = "calculate";
			this.calculate.Size = new System.Drawing.Size(140, 46);
			this.calculate.TabIndex = 11;
			this.calculate.Text = "Рассчитать";
			this.calculate.UseVisualStyleBackColor = false;
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// clear
			// 
			this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.clear.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.clear.Location = new System.Drawing.Point(250, 482);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(140, 46);
			this.clear.TabIndex = 10;
			this.clear.Text = "Очистить";
			this.clear.UseVisualStyleBackColor = false;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// month
			// 
			this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.month.Location = new System.Drawing.Point(12, 150);
			this.month.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.month.Name = "month";
			this.month.Size = new System.Drawing.Size(261, 29);
			this.month.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(8, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(378, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Срок полезного использования (в месяцах)";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(848, 9);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(397, 37);
			this.label13.TabIndex = 11;
			this.label13.Text = "Детализация амортизации";
			// 
			// Column1
			// 
			this.Column1.FillWeight = 80F;
			this.Column1.HeaderText = "Месяц";
			this.Column1.Name = "Column1";
			this.Column1.Width = 70;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "Дата";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "Остаточная стоимость на начало месяца";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "Сумма амортизации за месяц";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "Остаточная стоимость на конец месяца";
			this.Column5.Name = "Column5";
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Накопленый износ";
			this.Column6.Name = "Column6";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(8, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Дата принятие объекта";
			// 
			// dateTimeStart
			// 
			this.dateTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateTimeStart.Location = new System.Drawing.Point(12, 215);
			this.dateTimeStart.Name = "dateTimeStart";
			this.dateTimeStart.Size = new System.Drawing.Size(261, 29);
			this.dateTimeStart.TabIndex = 20;
			// 
			// sum_a
			// 
			this.sum_a.AutoSize = true;
			this.sum_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sum_a.Location = new System.Drawing.Point(287, 409);
			this.sum_a.Name = "sum_a";
			this.sum_a.Size = new System.Drawing.Size(20, 24);
			this.sum_a.TabIndex = 22;
			this.sum_a.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(8, 409);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(282, 24);
			this.label10.TabIndex = 21;
			this.label10.Text = "Сумма амортизации за месяц:";
			// 
			// main_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(1250, 540);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.table);
			this.MinimumSize = new System.Drawing.Size(1200, 560);
			this.Name = "main_form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Кредитный калькулятор - Выполнил Солодков А.А.";
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.price_object)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.month)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown price_object;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Label finish;
		private System.Windows.Forms.Label start;
		private System.Windows.Forms.Label norm;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown month;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.Label sum_a;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dateTimeStart;
		private System.Windows.Forms.Label label2;
	}
}

