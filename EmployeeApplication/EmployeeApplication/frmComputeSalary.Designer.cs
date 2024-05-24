namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            First_Name = new TextBox();
            Last_Name = new TextBox();
            Department = new TextBox();
            Job_Title = new TextBox();
            Rate_Per_Hour = new TextBox();
            Total_Hours_Worked = new TextBox();
            Compute_Salary = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            F_name = new Label();
            L_name = new Label();
            B_salary = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 61);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(287, 61);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 107);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(287, 107);
            label4.Name = "label4";
            label4.Size = new Size(57, 17);
            label4.TabIndex = 3;
            label4.Text = "Job Title";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(83, 211);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 4;
            label5.Text = "Rate per hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(287, 211);
            label6.Name = "label6";
            label6.Size = new Size(120, 17);
            label6.TabIndex = 5;
            label6.Text = "Total hours worked";
            // 
            // First_Name
            // 
            First_Name.Location = new Point(83, 81);
            First_Name.Name = "First_Name";
            First_Name.Size = new Size(198, 23);
            First_Name.TabIndex = 6;
            // 
            // Last_Name
            // 
            Last_Name.Location = new Point(287, 81);
            Last_Name.Name = "Last_Name";
            Last_Name.Size = new Size(198, 23);
            Last_Name.TabIndex = 7;
            // 
            // Department
            // 
            Department.Location = new Point(83, 127);
            Department.Name = "Department";
            Department.Size = new Size(198, 23);
            Department.TabIndex = 8;
            // 
            // Job_Title
            // 
            Job_Title.Location = new Point(287, 127);
            Job_Title.Name = "Job_Title";
            Job_Title.Size = new Size(198, 23);
            Job_Title.TabIndex = 9;
            // 
            // Rate_Per_Hour
            // 
            Rate_Per_Hour.Location = new Point(83, 231);
            Rate_Per_Hour.Name = "Rate_Per_Hour";
            Rate_Per_Hour.Size = new Size(198, 23);
            Rate_Per_Hour.TabIndex = 10;
            // 
            // Total_Hours_Worked
            // 
            Total_Hours_Worked.Location = new Point(287, 231);
            Total_Hours_Worked.Name = "Total_Hours_Worked";
            Total_Hours_Worked.Size = new Size(198, 23);
            Total_Hours_Worked.TabIndex = 11;
            // 
            // Compute_Salary
            // 
            Compute_Salary.BackColor = SystemColors.ActiveBorder;
            Compute_Salary.Location = new Point(215, 260);
            Compute_Salary.Name = "Compute_Salary";
            Compute_Salary.Size = new Size(142, 48);
            Compute_Salary.TabIndex = 12;
            Compute_Salary.Text = "Compute Salary";
            Compute_Salary.UseVisualStyleBackColor = false;
            Compute_Salary.Click += Compute_Salary_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(83, 351);
            label7.Name = "label7";
            label7.Size = new Size(74, 17);
            label7.TabIndex = 13;
            label7.Text = "First Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(83, 386);
            label8.Name = "label8";
            label8.Size = new Size(73, 17);
            label8.TabIndex = 14;
            label8.Text = "Last Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(83, 420);
            label9.Name = "label9";
            label9.Size = new Size(79, 17);
            label9.TabIndex = 15;
            label9.Text = "Basic Salary:";
            // 
            // F_name
            // 
            F_name.AutoSize = true;
            F_name.Location = new Point(163, 353);
            F_name.Name = "F_name";
            F_name.Size = new Size(0, 15);
            F_name.TabIndex = 16;
            // 
            // L_name
            // 
            L_name.AutoSize = true;
            L_name.Location = new Point(163, 388);
            L_name.Name = "L_name";
            L_name.Size = new Size(0, 15);
            L_name.TabIndex = 17;
            // 
            // B_salary
            // 
            B_salary.AutoSize = true;
            B_salary.Location = new Point(163, 422);
            B_salary.Name = "B_salary";
            B_salary.Size = new Size(0, 15);
            B_salary.TabIndex = 18;
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 496);
            Controls.Add(B_salary);
            Controls.Add(L_name);
            Controls.Add(F_name);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(Compute_Salary);
            Controls.Add(Total_Hours_Worked);
            Controls.Add(Rate_Per_Hour);
            Controls.Add(Job_Title);
            Controls.Add(Department);
            Controls.Add(Last_Name);
            Controls.Add(First_Name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmComputeSalary";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox First_Name;
        private TextBox Last_Name;
        private TextBox Department;
        private TextBox Job_Title;
        private TextBox Rate_Per_Hour;
        private TextBox Total_Hours_Worked;
        private Button Compute_Salary;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label F_name;
        private Label L_name;
        private Label B_salary;
    }
}
