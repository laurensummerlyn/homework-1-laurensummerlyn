// @author Lauren Watson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            int studentId;
            double h, p, q, m, f, finalGrade;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            studentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for participations?");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for quizzes?");
            q = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the midterm?");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your overall percentage grade for the final?");
            f = Convert.ToDouble(Console.ReadLine());

            finalGrade = (p / 100 * .10) + (h / 100 * .25) + (q / 100 * .1) + (m / 100 * .25) + (f / 100 * .3);

            Console.WriteLine(firstName + " " + lastName + " " + "(" + studentId + ")," + $" your final grade is {finalGrade.ToString("P2")}.");

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
