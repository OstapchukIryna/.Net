using System;

namespace Homework2
{
    class Student
    {
        public string name, group,surname, patronymic;
        public int age;

        public Student(string surname, string name, string patronymic, int age, string group)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.age = age;
            this.group = group;
        }
        public int[][] Grades = new int[3][] { new int[0], new int[0], new int[0] };
        public void GradeProg(int n)
        {
            int[] buf = new int[Grades[0].Length + 1];
            for (int i = 0; i < buf.Length -1; i++)
            {
                buf[i] = Grades[0][i];
            }
            buf[buf.Length - 1] = n;
            Grades[0] = new int[buf.Length];
            for (int i = 0; i < buf.Length; i++)
            {
                Grades[0][i] = buf[i];
            }
        }
        public void GradeAdmin(int n)
        {
            int[] buf = new int[Grades[1].Length + 1];
            for (int i = 0; i < buf.Length - 1; i++)
            {
                buf[i] = Grades[1][i];
            }
            buf[buf.Length - 1] = n;
            Grades[1] = new int[buf.Length];
            for (int i = 0; i < buf.Length; i++)
            {
                Grades[1][i] = buf[i];
            }
        }
        public void GradeDesign(int n)
        {
            int[] buf = new int[Grades[2].Length + 1];
            for (int i = 0; i < buf.Length - 1; i++)
            {
                buf[i] = Grades[2][i];
            }
            buf[buf.Length - 1] = n;
            Grades[2] = new int[buf.Length];
            for (int i = 0; i < buf.Length; i++)
            {
                Grades[2][i] = buf[i];
            }
        }

        /*public void AddMark(int n)
        {
            
            var addMarkSTR = Console.ReadLine();
            bool addMark = bool.Parse(addMarkSTR);
            if (addMark)
            {
                Console.WriteLine("Type the grade: ");
                int newMark = int.Parse(Console.ReadLine());
            }
        }*/

        public void GetInfo()
        {
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Patronymic: {patronymic}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Group: {group}");
            double midProg = 0, midAdmin = 0, midDesign = 0;
            Console.WriteLine("Programming: ");
            for (int i = 0; i < Grades[0].Length; i++)
            {
                midProg += Grades[0][i];
                Console.WriteLine(Grades[0][i] + " ");
            }
            Console.WriteLine($"Average mark: {midProg / Grades[0].Length}");

            Console.WriteLine("Administration: ");
            for (int i = 0; i < Grades[1].Length; i++)
            {
                midAdmin += Grades[1][i];
                Console.WriteLine(Grades[1][i] + " ");
            }
            Console.WriteLine($"Average mark: {midAdmin / Grades[1].Length}");

            Console.WriteLine("Design: ");
            for (int i = 0; i < Grades[2].Length; i++)
            {
                midDesign += Grades[2][i];
                Console.WriteLine(Grades[2][i] + " ");
            }
            Console.WriteLine($"Average mark: {midDesign / Grades[2].Length}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ostapchuk", "Iryna", "Oleksandrivna", 18, "CS18b");
            //Console.WriteLine("Wanna add mark to Programming? Type 0 or 1: ");
            student.GradeProg(10);
            student.GradeProg(11);
            student.GradeProg(12);
            student.GradeAdmin(9);
            student.GradeAdmin(10);
            student.GradeAdmin(10);
            student.GradeAdmin(12);
            student.GradeDesign(10);
            student.GradeDesign(10);
            student.GradeDesign(10);

            student.GetInfo();
             
            Console.ReadKey();
        }
    }
}
