using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplication
{
    internal class PartTimeEmployee : IEmployee
    {
        private string first_name;
        private string last_name;
        private string department;
        private string job_salary;
        private double basic_salary;

        public PartTimeEmployee(string fName, string lName, string depart, string jSalary)
        {
            this.first_name = fName;
            this.last_name = lName;
            this.department = depart;
            this.job_salary = jSalary;
           
            
        }

        public string FirstName {
            get {
                return first_name;
            }  set { 
            first_name = value;
            } 
            }
        public string LastName {
            get { 
            return last_name;
            } set { 
            last_name = value;
            } 
            }
        public string Department {
            get { 
            return department;
            }
            set {
            department = value; 
            } 
            }
        public string JobTitle {
            get { 
            return job_salary;  
            } set { 
            job_salary = value;
            }
            }
        public double BasicSalary { 
            get { 
            return basic_salary;
            }  set { 
            basic_salary = value;   
            }
            }


        
         public void computeSalary(int hoursWorked, double ratePerHour)
        {
           
            basic_salary = hoursWorked * ratePerHour;

        }
    public double getBasicSalary()
        {
            return basic_salary;

        }
    }
}
