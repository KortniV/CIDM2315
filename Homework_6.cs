using System;

namespace Homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor();
            p1.profName = "Alice";
            p1.classTeach = "Java";
            p1.SetSalary(9000);

            Professor p2 = new Professor();
            p2.profName = "Bob";
            p2.classTeach = "Math";
            p2.SetSalary(8000);

            Student s1 = new Student();
            s1.studentName = "Lisa";
            s1.classEnroll = "Java";
            s1.SetGrade(90);

            Student s2 = new Student();
            s2.studentName = "Tom";
            s2.classEnroll = "Math";
            s2.SetGrade(80);

            // Print details
            Console.WriteLine($"Professor {p1.profName} teaches {p1.classTeach} and the salary is: {p1.GetSalary()}");

            Console.WriteLine($"Professor {p2.profName} teaches {p2.classTeach} and the salary is: {p2.GetSalary()}");

            Console.WriteLine($"Student {s1.studentName} enrolls {s1.classEnroll}, and the grade is: {s1.GetGrade()}");

            Console.WriteLine($"Student {s2.studentName} enrolls {s2.classEnroll}, and the grade is: {s2.GetGrade()}");

            // Compare method
            Compare(p1, p2);
            Compare(s1, s2);
        }

        static void Compare(object obj1, object obj2)
            {
                if (obj1 is Student && obj2 is Student)
                    {
                        Student student1 = (Student)obj1;
                        Student student2 = (Student)obj2;
                        double totalGrade = student1.GetGrade() + student2.GetGrade();
                        Console.WriteLine($"The total grade of {student1.studentName} and {student2.studentName} is: {totalGrade}");
                    }
                else if (obj1 is Professor && obj2 is Professor)
                    {
                        Professor prof1 = (Professor)obj1;
                        Professor prof2 = (Professor)obj2;
                        double salaryDifference = Math.Abs(prof1.GetSalary() - prof2.GetSalary());
                        Console.WriteLine($"The salary difference between {prof1.profName} and {prof2.profName} is: {salaryDifference}");
                    }
                else
                    {
                        Console.WriteLine("\nError: Objects are not of the same type (either both students or both professors).");
                    }
}

    class Professor
    {
        // Declare variables
        public string? profName;
        public string? classTeach;
        private double salary;

        // Declare methods
        public void SetSalary(double salary_amount)
        {
            salary = salary_amount;
        }

        public double GetSalary()
        {
            return salary;
        }
    }

    class Student
    {
        // Declare variables
        public string? studentName;
        public string? classEnroll;
        private double studentGrade;

        // Declare methods
        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        public double GetGrade()
        {
            return studentGrade;
        }
    }
    }
}
