
namespace ProgrammingExercise2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_employee = new System.Windows.Forms.ListBox();
            this.rb_morning = new System.Windows.Forms.RadioButton();
            this.rb_afternoon = new System.Windows.Forms.RadioButton();
            this.monday = new System.Windows.Forms.CheckBox();
            this.tuesday = new System.Windows.Forms.CheckBox();
            this.wednesday = new System.Windows.Forms.CheckBox();
            this.thursday = new System.Windows.Forms.CheckBox();
            this.txt_employee = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbx_wkdays = new System.Windows.Forms.ListBox();
            this.lbx_shift = new System.Windows.Forms.ListBox();
            this.gb_shift = new System.Windows.Forms.GroupBox();
            this.gb_wkday = new System.Windows.Forms.GroupBox();
            this.sunday = new System.Windows.Forms.CheckBox();
            this.saturday = new System.Windows.Forms.CheckBox();
            this.friday = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_evening = new System.Windows.Forms.RadioButton();
            this.btn_clear = new System.Windows.Forms.Button();
            this.gb_shift.SuspendLayout();
            this.gb_wkday.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_employee
            // 
            this.lbx_employee.FormattingEnabled = true;
            this.lbx_employee.ItemHeight = 15;
            this.lbx_employee.Location = new System.Drawing.Point(52, 237);
            this.lbx_employee.Name = "lbx_employee";
            this.lbx_employee.Size = new System.Drawing.Size(168, 184);
            this.lbx_employee.TabIndex = 0;
            // 
            // rb_morning
            // 
            this.rb_morning.AutoSize = true;
            this.rb_morning.Location = new System.Drawing.Point(6, 30);
            this.rb_morning.Name = "rb_morning";
            this.rb_morning.Size = new System.Drawing.Size(71, 19);
            this.rb_morning.TabIndex = 1;
            this.rb_morning.TabStop = true;
            this.rb_morning.Text = "Morning";
            this.rb_morning.UseVisualStyleBackColor = true;
            // 
            // rb_afternoon
            // 
            this.rb_afternoon.AutoSize = true;
            this.rb_afternoon.Location = new System.Drawing.Point(6, 55);
            this.rb_afternoon.Name = "rb_afternoon";
            this.rb_afternoon.Size = new System.Drawing.Size(79, 19);
            this.rb_afternoon.TabIndex = 2;
            this.rb_afternoon.TabStop = true;
            this.rb_afternoon.Text = "Afternoon";
            this.rb_afternoon.UseVisualStyleBackColor = true;
            // 
            // monday
            // 
            this.monday.AutoSize = true;
            this.monday.Location = new System.Drawing.Point(57, 22);
            this.monday.Name = "monday";
            this.monday.Size = new System.Drawing.Size(70, 19);
            this.monday.TabIndex = 3;
            this.monday.Text = "Monday";
            this.monday.UseVisualStyleBackColor = true;
            // 
            // tuesday
            // 
            this.tuesday.AutoSize = true;
            this.tuesday.Location = new System.Drawing.Point(57, 45);
            this.tuesday.Name = "tuesday";
            this.tuesday.Size = new System.Drawing.Size(69, 19);
            this.tuesday.TabIndex = 4;
            this.tuesday.Text = "Tuesday";
            this.tuesday.UseVisualStyleBackColor = true;
            // 
            // wednesday
            // 
            this.wednesday.AutoSize = true;
            this.wednesday.Location = new System.Drawing.Point(57, 68);
            this.wednesday.Name = "wednesday";
            this.wednesday.Size = new System.Drawing.Size(87, 19);
            this.wednesday.TabIndex = 5;
            this.wednesday.Text = "Wednesday";
            this.wednesday.UseVisualStyleBackColor = true;
            // 
            // thursday
            // 
            this.thursday.AutoSize = true;
            this.thursday.Location = new System.Drawing.Point(57, 91);
            this.thursday.Name = "thursday";
            this.thursday.Size = new System.Drawing.Size(74, 19);
            this.thursday.TabIndex = 6;
            this.thursday.Text = "Thursday";
            this.thursday.UseVisualStyleBackColor = true;
            // 
            // txt_employee
            // 
            this.txt_employee.Location = new System.Drawing.Point(52, 68);
            this.txt_employee.Name = "txt_employee";
            this.txt_employee.Size = new System.Drawing.Size(100, 23);
            this.txt_employee.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(615, 42);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbx_wkdays
            // 
            this.lbx_wkdays.FormattingEnabled = true;
            this.lbx_wkdays.ItemHeight = 15;
            this.lbx_wkdays.Location = new System.Drawing.Point(256, 237);
            this.lbx_wkdays.Name = "lbx_wkdays";
            this.lbx_wkdays.Size = new System.Drawing.Size(133, 184);
            this.lbx_wkdays.TabIndex = 9;
            // 
            // lbx_shift
            // 
            this.lbx_shift.FormattingEnabled = true;
            this.lbx_shift.ItemHeight = 15;
            this.lbx_shift.Location = new System.Drawing.Point(429, 237);
            this.lbx_shift.Name = "lbx_shift";
            this.lbx_shift.Size = new System.Drawing.Size(159, 184);
            this.lbx_shift.TabIndex = 10;
            // 
            // gb_shift
            // 
            this.gb_shift.Controls.Add(this.rb_afternoon);
            this.gb_shift.Controls.Add(this.rb_morning);
            this.gb_shift.Location = new System.Drawing.Point(388, 42);
            this.gb_shift.Name = "gb_shift";
            this.gb_shift.Size = new System.Drawing.Size(200, 100);
            this.gb_shift.TabIndex = 11;
            this.gb_shift.TabStop = false;
            this.gb_shift.Text = "Shift";
            // 
            // gb_wkday
            // 
            this.gb_wkday.Controls.Add(this.sunday);
            this.gb_wkday.Controls.Add(this.saturday);
            this.gb_wkday.Controls.Add(this.friday);
            this.gb_wkday.Controls.Add(this.monday);
            this.gb_wkday.Controls.Add(this.tuesday);
            this.gb_wkday.Controls.Add(this.wednesday);
            this.gb_wkday.Controls.Add(this.thursday);
            this.gb_wkday.Location = new System.Drawing.Point(182, 42);
            this.gb_wkday.Name = "gb_wkday";
            this.gb_wkday.Size = new System.Drawing.Size(200, 189);
            this.gb_wkday.TabIndex = 12;
            this.gb_wkday.TabStop = false;
            this.gb_wkday.Text = "Weekday";
            // 
            // sunday
            // 
            this.sunday.AutoSize = true;
            this.sunday.Location = new System.Drawing.Point(57, 160);
            this.sunday.Name = "sunday";
            this.sunday.Size = new System.Drawing.Size(65, 19);
            this.sunday.TabIndex = 9;
            this.sunday.Text = "Sunday";
            this.sunday.UseVisualStyleBackColor = true;
            // 
            // saturday
            // 
            this.saturday.AutoSize = true;
            this.saturday.Location = new System.Drawing.Point(57, 137);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(72, 19);
            this.saturday.TabIndex = 8;
            this.saturday.Text = "Saturday";
            this.saturday.UseVisualStyleBackColor = true;
            // 
            // friday
            // 
            this.friday.AutoSize = true;
            this.friday.Location = new System.Drawing.Point(57, 114);
            this.friday.Name = "friday";
            this.friday.Size = new System.Drawing.Size(58, 19);
            this.friday.TabIndex = 7;
            this.friday.Text = "Friday";
            this.friday.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Employee ";
            // 
            // rb_evening
            // 
            this.rb_evening.AutoSize = true;
            this.rb_evening.Location = new System.Drawing.Point(394, 122);
            this.rb_evening.Name = "rb_evening";
            this.rb_evening.Size = new System.Drawing.Size(67, 19);
            this.rb_evening.TabIndex = 3;
            this.rb_evening.TabStop = true;
            this.rb_evening.Text = "Evening";
            this.rb_evening.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(615, 83);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.rb_evening);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_wkday);
            this.Controls.Add(this.gb_shift);
            this.Controls.Add(this.lbx_shift);
            this.Controls.Add(this.lbx_wkdays);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_employee);
            this.Controls.Add(this.lbx_employee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_shift.ResumeLayout(false);
            this.gb_shift.PerformLayout();
            this.gb_wkday.ResumeLayout(false);
            this.gb_wkday.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_employee;
        private System.Windows.Forms.RadioButton rb_morning;
        private System.Windows.Forms.RadioButton rb_afternoon;
        private System.Windows.Forms.CheckBox monday;
        private System.Windows.Forms.CheckBox tuesday;
        private System.Windows.Forms.CheckBox wednesday;
        private System.Windows.Forms.CheckBox thursday;
        private System.Windows.Forms.TextBox txt_employee;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lbx_wkdays;
        private System.Windows.Forms.ListBox lbx_shift;
        private System.Windows.Forms.GroupBox gb_shift;
        private System.Windows.Forms.GroupBox gb_wkday;
        private System.Windows.Forms.CheckBox sunday;
        private System.Windows.Forms.CheckBox saturday;
        private System.Windows.Forms.CheckBox friday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_evening;
        private System.Windows.Forms.Button btn_clear;
    }
}

