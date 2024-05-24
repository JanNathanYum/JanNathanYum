namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Compute_Salary_Click(object sender, EventArgs e)
        {
            PartTimeEmployee partTimeE = new PartTimeEmployee(First_Name.Text,Last_Name.Text,Department.Text,Job_Title.Text);
            partTimeE.computeSalary(Convert.ToInt32(Total_Hours_Worked.Text), Convert.ToDouble(Rate_Per_Hour.Text));

            B_salary.Text = Convert.ToString(partTimeE.getBasicSalary());
            L_name.Text = partTimeE.LastName;
            F_name.Text = partTimeE.FirstName;
        }
    }
}
