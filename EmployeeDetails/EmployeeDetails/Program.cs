using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int empId;
            long mobileNumber;
            DateTime dob;
            DateTime doj;
            int salary;

            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Enter empId please!");
            empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter mobile number");
            mobileNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("ENTER DATE OF BIRTH");
            dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter date of joining");
            doj = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter salary");
            salary = Convert.ToInt32(Console.ReadLine());


            DateTime today = DateTime.Now;
            int exp = today.Year - doj.Year;
            int anualSalary = salary * 12;

            Console.WriteLine("name is:{0}\nempId is:{1}\nmobileNumber is:{2}\ndob is:{3}\nexp is:{4}\nanualSalary is:{5}", name, empId, mobileNumber, dob, exp, anualSalary);
        }
    }
}
