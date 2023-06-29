using System;
namespace cwiczenia_8
{
    public class zad4
    { 
        enum Gender
        {
        Male,
        Female
        }

        struct Student
        {
            public string lastName;
            public int studentId;
            public double grade;
            public Gender gender;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student[] students = new Student[5];

                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = new Student();
                    FillStudentInfo(ref students[i]);
                    Console.WriteLine();
                }

                foreach (Student student in students)
                {
                    DisplayStudentInfo(student);
                }

                double averageGrade = CalculateAverageGrade(students);
                Console.WriteLine("\nŚrednia ocen w grupie: " + averageGrade);
            }

            static void FillStudentInfo(ref Student student)
            {
                Console.Write("Nazwisko: ");
                student.lastName = Console.ReadLine();

                Console.Write("Nr albumu: ");
                student.studentId = int.Parse(Console.ReadLine());

                Console.Write("Ocena: ");
                student.grade = double.Parse(Console.ReadLine());

                if (student.grade < 2.0)
                {
                    student.grade = 2.0;
                }
                else if (student.grade > 5.0)
                {
                    student.grade = 5.0;
                }

                Console.Write("Płeć (M/F): ");
                string genderInput = Console.ReadLine();
                if (genderInput.ToUpper() == "M")
                {
                    student.gender = Gender.Male;
                }
                else
                {
                    student.gender = Gender.Female;
                }
            }

            static double CalculateAverageGrade(Student[] students)
            {
                double totalGrade = 0.0;
                foreach (Student student in students)
                {
                    totalGrade += student.grade;
                }
                return totalGrade / students.Length;
            }

            static void DisplayStudentInfo(Student student)
            {
                Console.WriteLine($"Nazwisko: {student.lastName}, Nr albumu: {student.studentId}, Ocena: {student.grade}, Płeć: {student.gender}");
            }
        }
     
    }
}


