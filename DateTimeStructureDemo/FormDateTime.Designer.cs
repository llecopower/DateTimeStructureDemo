namespace DateTimeStructureDemo
{
    partial class FormDateTime
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
            this.buttonNow = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.textBoxNow = new System.Windows.Forms.TextBox();
            this.buttonMonth = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTimeOfDay = new System.Windows.Forms.Button();
            this.buttonDayOfYear = new System.Windows.Forms.Button();
            this.buttonDayOfWeek = new System.Windows.Forms.Button();
            this.buttonYear = new System.Windows.Forms.Button();
            this.buttonDay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonShortTime = new System.Windows.Forms.Button();
            this.buttonLongTime = new System.Windows.Forms.Button();
            this.buttonShortDate = new System.Windows.Forms.Button();
            this.buttonLongDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxToday = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLongDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxShortDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLongTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxShortTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonOperation = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDayOfWeek = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDayOfYear = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTimeOfDay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNow
            // 
            this.buttonNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNow.ForeColor = System.Drawing.Color.Blue;
            this.buttonNow.Location = new System.Drawing.Point(24, 30);
            this.buttonNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNow.Name = "buttonNow";
            this.buttonNow.Size = new System.Drawing.Size(140, 46);
            this.buttonNow.TabIndex = 0;
            this.buttonNow.Text = "Now ";
            this.buttonNow.UseVisualStyleBackColor = true;
            this.buttonNow.Click += new System.EventHandler(this.buttonNow_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToday.ForeColor = System.Drawing.Color.Blue;
            this.buttonToday.Location = new System.Drawing.Point(24, 82);
            this.buttonToday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(140, 46);
            this.buttonToday.TabIndex = 1;
            this.buttonToday.Text = "Today ";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // textBoxNow
            // 
            this.textBoxNow.Location = new System.Drawing.Point(59, 150);
            this.textBoxNow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNow.Name = "textBoxNow";
            this.textBoxNow.Size = new System.Drawing.Size(168, 22);
            this.textBoxNow.TabIndex = 2;
            // 
            // buttonMonth
            // 
            this.buttonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonth.ForeColor = System.Drawing.Color.Blue;
            this.buttonMonth.Location = new System.Drawing.Point(212, 137);
            this.buttonMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMonth.Name = "buttonMonth";
            this.buttonMonth.Size = new System.Drawing.Size(140, 46);
            this.buttonMonth.TabIndex = 3;
            this.buttonMonth.Text = "Month";
            this.buttonMonth.UseVisualStyleBackColor = true;
            this.buttonMonth.Click += new System.EventHandler(this.buttonMonth_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTimeOfDay);
            this.groupBox1.Controls.Add(this.buttonDayOfYear);
            this.groupBox1.Controls.Add(this.buttonDayOfWeek);
            this.groupBox1.Controls.Add(this.buttonYear);
            this.groupBox1.Controls.Add(this.buttonDay);
            this.groupBox1.Controls.Add(this.buttonNow);
            this.groupBox1.Controls.Add(this.buttonMonth);
            this.groupBox1.Controls.Add(this.buttonToday);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(723, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(377, 267);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties (Propriétés)";
            // 
            // buttonTimeOfDay
            // 
            this.buttonTimeOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeOfDay.ForeColor = System.Drawing.Color.Blue;
            this.buttonTimeOfDay.Location = new System.Drawing.Point(211, 201);
            this.buttonTimeOfDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTimeOfDay.Name = "buttonTimeOfDay";
            this.buttonTimeOfDay.Size = new System.Drawing.Size(140, 46);
            this.buttonTimeOfDay.TabIndex = 8;
            this.buttonTimeOfDay.Text = "TimeOfDay";
            this.buttonTimeOfDay.UseVisualStyleBackColor = true;
            this.buttonTimeOfDay.Click += new System.EventHandler(this.buttonTimeOfDay_Click);
            // 
            // buttonDayOfYear
            // 
            this.buttonDayOfYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDayOfYear.ForeColor = System.Drawing.Color.Blue;
            this.buttonDayOfYear.Location = new System.Drawing.Point(24, 201);
            this.buttonDayOfYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDayOfYear.Name = "buttonDayOfYear";
            this.buttonDayOfYear.Size = new System.Drawing.Size(140, 46);
            this.buttonDayOfYear.TabIndex = 7;
            this.buttonDayOfYear.Text = "DayOfYear";
            this.buttonDayOfYear.UseVisualStyleBackColor = true;
            this.buttonDayOfYear.Click += new System.EventHandler(this.buttonDayOfYear_Click);
            // 
            // buttonDayOfWeek
            // 
            this.buttonDayOfWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDayOfWeek.ForeColor = System.Drawing.Color.Blue;
            this.buttonDayOfWeek.Location = new System.Drawing.Point(24, 142);
            this.buttonDayOfWeek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDayOfWeek.Name = "buttonDayOfWeek";
            this.buttonDayOfWeek.Size = new System.Drawing.Size(140, 46);
            this.buttonDayOfWeek.TabIndex = 6;
            this.buttonDayOfWeek.Text = "DayOfWeek";
            this.buttonDayOfWeek.UseVisualStyleBackColor = true;
            this.buttonDayOfWeek.Click += new System.EventHandler(this.buttonDayOfWeek_Click);
            // 
            // buttonYear
            // 
            this.buttonYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYear.ForeColor = System.Drawing.Color.Blue;
            this.buttonYear.Location = new System.Drawing.Point(212, 82);
            this.buttonYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(140, 46);
            this.buttonYear.TabIndex = 5;
            this.buttonYear.Text = "Year";
            this.buttonYear.UseVisualStyleBackColor = true;
            this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
            // 
            // buttonDay
            // 
            this.buttonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay.ForeColor = System.Drawing.Color.Blue;
            this.buttonDay.Location = new System.Drawing.Point(212, 30);
            this.buttonDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(140, 46);
            this.buttonDay.TabIndex = 4;
            this.buttonDay.Text = "Day";
            this.buttonDay.UseVisualStyleBackColor = true;
            this.buttonDay.Click += new System.EventHandler(this.buttonDay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonShortTime);
            this.groupBox2.Controls.Add(this.buttonLongTime);
            this.groupBox2.Controls.Add(this.buttonShortDate);
            this.groupBox2.Controls.Add(this.buttonLongDate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(525, 377);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(575, 212);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Methods (Méthodes)for Formatting a Date or Time";
            // 
            // buttonShortTime
            // 
            this.buttonShortTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShortTime.ForeColor = System.Drawing.Color.Blue;
            this.buttonShortTime.Location = new System.Drawing.Point(303, 123);
            this.buttonShortTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShortTime.Name = "buttonShortTime";
            this.buttonShortTime.Size = new System.Drawing.Size(245, 46);
            this.buttonShortTime.TabIndex = 4;
            this.buttonShortTime.Text = "ToShortTimeString()";
            this.buttonShortTime.UseVisualStyleBackColor = true;
            this.buttonShortTime.Click += new System.EventHandler(this.buttonShortTime_Click);
            // 
            // buttonLongTime
            // 
            this.buttonLongTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLongTime.ForeColor = System.Drawing.Color.Blue;
            this.buttonLongTime.Location = new System.Drawing.Point(43, 123);
            this.buttonLongTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLongTime.Name = "buttonLongTime";
            this.buttonLongTime.Size = new System.Drawing.Size(245, 46);
            this.buttonLongTime.TabIndex = 3;
            this.buttonLongTime.Text = "ToLongTimeString()";
            this.buttonLongTime.UseVisualStyleBackColor = true;
            this.buttonLongTime.Click += new System.EventHandler(this.buttonLongTime_Click);
            // 
            // buttonShortDate
            // 
            this.buttonShortDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShortDate.ForeColor = System.Drawing.Color.Blue;
            this.buttonShortDate.Location = new System.Drawing.Point(303, 46);
            this.buttonShortDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShortDate.Name = "buttonShortDate";
            this.buttonShortDate.Size = new System.Drawing.Size(245, 46);
            this.buttonShortDate.TabIndex = 2;
            this.buttonShortDate.Text = "ToShortDateString()";
            this.buttonShortDate.UseVisualStyleBackColor = true;
            this.buttonShortDate.Click += new System.EventHandler(this.buttonShortDate_Click);
            // 
            // buttonLongDate
            // 
            this.buttonLongDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLongDate.ForeColor = System.Drawing.Color.Blue;
            this.buttonLongDate.Location = new System.Drawing.Point(43, 46);
            this.buttonLongDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLongDate.Name = "buttonLongDate";
            this.buttonLongDate.Size = new System.Drawing.Size(219, 46);
            this.buttonLongDate.TabIndex = 1;
            this.buttonLongDate.Text = "ToLongDateString()";
            this.buttonLongDate.UseVisualStyleBackColor = true;
            this.buttonLongDate.Click += new System.EventHandler(this.buttonLongDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Now ";
            // 
            // textBoxToday
            // 
            this.textBoxToday.Location = new System.Drawing.Point(59, 217);
            this.textBoxToday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxToday.Name = "textBoxToday";
            this.textBoxToday.Size = new System.Drawing.Size(168, 22);
            this.textBoxToday.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Today";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Month";
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(292, 151);
            this.textBoxMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(168, 22);
            this.textBoxMonth.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Day";
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(292, 222);
            this.textBoxDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(168, 22);
            this.textBoxDay.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 257);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Year";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(292, 284);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(168, 22);
            this.textBoxYear.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Long Date";
            // 
            // textBoxLongDate
            // 
            this.textBoxLongDate.Location = new System.Drawing.Point(55, 377);
            this.textBoxLongDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLongDate.Name = "textBoxLongDate";
            this.textBoxLongDate.Size = new System.Drawing.Size(205, 22);
            this.textBoxLongDate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 354);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Short Date";
            // 
            // textBoxShortDate
            // 
            this.textBoxShortDate.Location = new System.Drawing.Point(292, 378);
            this.textBoxShortDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxShortDate.Name = "textBoxShortDate";
            this.textBoxShortDate.Size = new System.Drawing.Size(203, 22);
            this.textBoxShortDate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 423);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Long Time";
            // 
            // textBoxLongTime
            // 
            this.textBoxLongTime.Location = new System.Drawing.Point(55, 447);
            this.textBoxLongTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLongTime.Name = "textBoxLongTime";
            this.textBoxLongTime.Size = new System.Drawing.Size(205, 22);
            this.textBoxLongTime.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 423);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Short Time";
            // 
            // textBoxShortTime
            // 
            this.textBoxShortTime.Location = new System.Drawing.Point(288, 447);
            this.textBoxShortTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxShortTime.Name = "textBoxShortTime";
            this.textBoxShortTime.Size = new System.Drawing.Size(207, 22);
            this.textBoxShortTime.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(241, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(613, 36);
            this.label10.TabIndex = 23;
            this.label10.Text = "Utilisation de la structure DateTime en  C#";
            // 
            // buttonOperation
            // 
            this.buttonOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOperation.ForeColor = System.Drawing.Color.Blue;
            this.buttonOperation.Location = new System.Drawing.Point(85, 519);
            this.buttonOperation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOperation.Name = "buttonOperation";
            this.buttonOperation.Size = new System.Drawing.Size(371, 46);
            this.buttonOperation.TabIndex = 24;
            this.buttonOperation.Text = "Operations on Dates and Times";
            this.buttonOperation.UseVisualStyleBackColor = true;
            this.buttonOperation.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(529, 198);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Day of Week";
            // 
            // textBoxDayOfWeek
            // 
            this.textBoxDayOfWeek.Location = new System.Drawing.Point(529, 222);
            this.textBoxDayOfWeek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDayOfWeek.Name = "textBoxDayOfWeek";
            this.textBoxDayOfWeek.Size = new System.Drawing.Size(168, 22);
            this.textBoxDayOfWeek.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(529, 257);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Day of Year";
            // 
            // textBoxDayOfYear
            // 
            this.textBoxDayOfYear.Location = new System.Drawing.Point(529, 281);
            this.textBoxDayOfYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDayOfYear.Name = "textBoxDayOfYear";
            this.textBoxDayOfYear.Size = new System.Drawing.Size(168, 22);
            this.textBoxDayOfYear.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(529, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Time of Day";
            // 
            // textBoxTimeOfDay
            // 
            this.textBoxTimeOfDay.Location = new System.Drawing.Point(529, 154);
            this.textBoxTimeOfDay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTimeOfDay.Name = "textBoxTimeOfDay";
            this.textBoxTimeOfDay.Size = new System.Drawing.Size(168, 22);
            this.textBoxTimeOfDay.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxTimeOfDay);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxDayOfYear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxDayOfWeek);
            this.Controls.Add(this.buttonOperation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxShortTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxLongTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxShortDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLongDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxToday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxNow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDateTime";
            this.Text = "DateTime Structure Demo";
            this.Load += new System.EventHandler(this.FormDateTime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNow;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.TextBox textBoxNow;
        private System.Windows.Forms.Button buttonMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.Button buttonDay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxToday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonShortTime;
        private System.Windows.Forms.Button buttonLongTime;
        private System.Windows.Forms.Button buttonShortDate;
        private System.Windows.Forms.Button buttonLongDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLongDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxShortDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLongTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxShortTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonOperation;
        private System.Windows.Forms.Button buttonTimeOfDay;
        private System.Windows.Forms.Button buttonDayOfYear;
        private System.Windows.Forms.Button buttonDayOfWeek;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDayOfWeek;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDayOfYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxTimeOfDay;
        private System.Windows.Forms.Button button1;
    }
}

