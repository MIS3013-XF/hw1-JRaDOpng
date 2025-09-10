// HW1b Grade

// Your Name: Jaime Ramirez
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            string StudentID;

            double Homework;
            double Participation;
            double Exam1;
            double Exam2;
            double Exam3;
            double Grade;

            string HomeworkGrade;
            string ParticipationGrade;
            string Exam1Grade;
            string Exam2Grade;
            string Exam3Grade;



            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();
            Console.WriteLine("What is your student ID?");
            StudentID = Console.ReadLine();
            Console.WriteLine("What is your overall homework grade?");
            HomeworkGrade = Console.ReadLine();
            Console.WriteLine("What is your overall participation grade?");
            ParticipationGrade = Console.ReadLine();
            Console.WriteLine("What is your Exam 1 grade?");
            Exam1Grade = Console.ReadLine();
            Console.WriteLine("What is your Exam 2 grade?");
            Exam2Grade = Console.ReadLine();
            Console.WriteLine("What is your Exam 3 grade?");
            Exam3Grade = Console.ReadLine();

            Homework = Convert.ToDouble(HomeworkGrade);
            Participation = Convert.ToDouble(ParticipationGrade);
            Exam1 = Convert.ToDouble(Exam1Grade);
            Exam2 = Convert.ToDouble(Exam2Grade);
            Exam3 = Convert.ToDouble(Exam3Grade);


            Grade = ((Homework * 20) + (Participation * 15) + (Exam1 * 15) + (Exam2 * 25) + (Exam3 * 25)) / 100;

            Console.WriteLine(FirstName + " " + LastName + " (" + StudentID + ")," + " your final grade is " + Grade);






                

        }
    }
}
