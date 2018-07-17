using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsAppweek1fix
{
    internal class Employee
    {
        //private variables
        string programmerName = "";
        string address;
        double grossPay = 0;
        string employeeType;
        string age;
        string department;
        string devtype;
        //Properties
        public string ProgrammerName { get => programmerName; set => programmerName = value; }
        public string Address { get => address; set => address = value; }
        public double GrossPay { get => grossPay; set => grossPay = value; }
        public string EmployeeType { get => employeeType; set => employeeType = value; }
        public string Age { get => age; set => age = value; }
        public string Department { get => department; set => department = value; }
        public string Devtype { get => devtype; set => devtype = value; }





        public void EnterEmployeeName(string Inp)
        {

            programmerName = Inp;
        }//public void EnterEmployeeName(string Inp)

        public void EnterAddress(string Inp)
        {

            address = Inp;

        }//public void EnterZipCode(string Inp)


        public void EnterGrossPay(string Inp)
        {

            try
            {

                decimal number;
                //test for only numbers
                if (!Decimal.TryParse(Inp, out number))
                {
                    //validInput remains false, break out of try/catch
                    throw new ArgumentException("Must contain only numbers.");
                }
                //Input is deemed valid                    
                grossPay = double.Parse(Inp);

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid input" + Environment.NewLine + ex.Message);
            }

        }//public void EnterGrossPay(string Inp)


        public void EnterEmployeeType(string Inp)
        {
            //Convert input to uppercase
            Inp = Inp.ToUpper();

            try
            {

                if (Inp == "W2" | Inp == "1099")
                {
                    //This is a valid input                       
                    employeeType = Inp;
                    return;
                }
                else
                {

                    throw new ArgumentException("Invalid input");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid input" + Environment.NewLine + ex.Message);

            }

        }//public void EnterEmployee age(int Inp)

        public void EnterEmployeeAge(string Inp)
        {

            age = Inp;
        }//public void EnterEmployee age(int Inp)

        public void EnterDepartment(string Inp)
        {

            department = Inp;
        }//public void EnterEmployee age(int Inp)


        public void EnterDevType(string Inp)
        {

            devtype = Inp;
        }//public void EnterEmployee age(int Inp)


        public void DisplayEmployeeInformation()
        {

            
            //display the Calculations
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Programmer Name :{0} ", programmerName);
            Console.WriteLine("Address :{0} ", address);
            Console.WriteLine("Gross monthly pay :{0:C2} ", Convert.ToDecimal(this.grossPay));
            Console.WriteLine("Annual gross pay = {0:C2}", Convert.ToDecimal(this.CalculateAnualIncome()));
            Console.WriteLine("Employee type : {0} ", employeeType);
            Console.WriteLine("Employee Age : {0} ", age);
            Console.WriteLine("Employee Department : {0} ", department);
            Console.WriteLine("Developer type : {0} ", devtype);
            Console.WriteLine("Monthly taxes payed = {0:C2}", Convert.ToDecimal(this.CalulateMonthlyTaxes()));
            Console.WriteLine("Annual taxes payed = {0:C2}", Convert.ToDecimal(this.CalculateAnnualTaxes()));

        }//public void DisplayEmployeeInformation()

        private double CalulateMonthlyTaxes()
        {
            //calculate taxes
            if (employeeType == "1099")
            {
                return 0;
            }
            else
            {
                return grossPay * .07;
            }


        }//private double CalulateMonthlyTaxes()

        private double CalculateAnualIncome()
        {
            return grossPay * 12;
        }//private double CalculateAnualIncome()

        private double CalculateAnnualTaxes()
        {
            if (employeeType == "1099")
            {
                return 0;
            }
            else
            {
                return CalculateAnualIncome() * .07;

            }

        }//private double CalculateAnnualTaxes()

        private bool ContainsOnlyNumbers(ref string inp)
        {
            foreach (char c in inp)
            {
                if (!char.IsNumber(c))
                    return false;
            }
            return true;
        }// private bool ContainsOnlyNumbers(string inp)

    }
}

