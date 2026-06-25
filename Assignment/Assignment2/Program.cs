using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        //string name;
        //bool gender;
        //int age;
        //int std;
        //char div;
        //double marks;
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;
        public Student()
        {

        }
        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetGender(bool gender)
        {
            this.gender = gender;

        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void SetStd(int std)
        {
            this.std = std;
        }
        public void SetDiv(char div)
        {
            this.div = div;
        }

        public void SetMarks(double marks)
        {
            this.marks = marks;
        }

        public string GetName()
        {
            return name;
        }
        public bool GetGender()
        {
            return gender;
        }
        public int GetAge()
        {
            return age;
        }
        public char GetDiv()
        {
            return div;
        }

        public double GetMarks()
        {
            return marks;
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender(true= Male, false= Female)");
            gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine( "Enter Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter standard");
            std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Division:");
            div= Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter marks");
            marks= Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {

            Console.WriteLine("Name :"+name);
            Console.WriteLine("Gender :" + gender);
            Console.WriteLine("AGE :"+age);
            Console.WriteLine(" Standard : "+ std);
            Console.WriteLine("Division"+ div);
            Console.WriteLine("Marks :" + marks);
         }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1= new Student();

            s1.AcceptDetails();
            s1.PrintDetails();
         }
    }
}
