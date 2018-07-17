using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppweek1fix
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static void Run (string[] args)
        {

            
           

            //Create a collection of Employees
            var employeeList = new List<Employee>();

            //This method is for manualy entering employee data
            //EnterEmployeeData(employeeList);

            //This Method is for retrieving employee data from a CSV file
            using (var reader = new StreamReader("Employees.csv"))
            {
                while (!reader.EndOfStream)
                {
                    //Create a new employee object
                    Employee newEmployee = new Employee();

                    //Read a line and parse the values
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    newEmployee.EnterEmployeeName(values[0]);
                    newEmployee.EnterAddress(values[1]);
                    newEmployee.EnterGrossPay(values[2]);
                    newEmployee.EnterEmployeeType(values[3]);
                    newEmployee.EnterEmployeeAge(values[4]);
                    newEmployee.EnterDepartment(values[5]);
                    newEmployee.EnterDevType(values[6]);

                   


                    //Add the record to the collection
                    employeeList.Add(newEmployee);
                }
            }

            //Display all of the employees
            foreach (Employee employee in employeeList)
            {
                employee.DisplayEmployeeInformation();

            }
            

        }//static void Main(string[] args)


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
