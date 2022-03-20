using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {

        string[] studentName = new string[] { "Shakeel","Usman","Yaqob","Ahmed","Saeed","Junaid","Akram","Noor","Anjum","Haider" };
        int[] studentMark = new int[] {50,60,70,80,96,67,85,76,88,65 };
        int Min;
        int Max;
        double Mean; 
        public void Run()
        {
            Outputheading();
            string[] choices =
           {
                " Input Marks",
                " Show Marks",
                " Show Grades",
                " Show Statistics",
                " Show Grade Profile",
                " Quit"
            };
            int choice = ConsoleHelper.SelectChoice(choices);
            if (choice == 1)
            {
                InputMarks();
            }
            else if (choice==2)
            {
                ShowMarks();
            }
            else if (choice == 3)
            {
                ShowGrades();
            }
            else if (choice == 4)
            {
                ShowStatistics();
            }
            else if (choice == 5)
            {
                ShowGradeProfile();
            }
        }

        private void ShowGradeProfile()
        {
            int A_Grade, B_Grade, C_Grade, D_Grade, F_Grade;
            A_Grade = 0;
            B_Grade = 0;
            C_Grade = 0;
            D_Grade = 0;
            F_Grade = 0;
            for (int i = 0; i < studentName.Length; i++)
            {
                if (CalculateGrades(studentMark[i]) == "A")
                    A_Grade = A_Grade + 1;
                else if (CalculateGrades(studentMark[i]) == "B")
                    B_Grade = B_Grade + 1;
                else if (CalculateGrades(studentMark[i]) == "C")
                    C_Grade = C_Grade + 1;
                else if (CalculateGrades(studentMark[i]) == "D")
                    D_Grade = D_Grade + 1;
                else if (CalculateGrades(studentMark[i]) == "F")
                    F_Grade = F_Grade + 1;
            }


            Console.WriteLine(" A Grade: Count " + A_Grade+" ("+(A_Grade*100/studentMark.Length)+"%)");
            Console.WriteLine(" B Grade: Count " + B_Grade + " (" + (B_Grade * 100 / studentMark.Length) + "%)");
            Console.WriteLine(" C Grade: Count " + C_Grade + " (" + (C_Grade * 100 / studentMark.Length) + "%)");
            Console.WriteLine(" D Grade: Count " + D_Grade + " (" + (D_Grade * 100 / studentMark.Length) + "%)");
            Console.WriteLine(" F Grade: Count " + F_Grade + " (" + (F_Grade * 100 / studentMark.Length) + "%)");
        }

        // Calculate Statistic
        private void CalculateStatistics()
        {
            Max = studentMark[0];
            Min = studentMark[0];
            double total = 0;
            for (int i = 0; i < studentName.Length; i++)
            {
                if (studentMark[i] > Max) Max = studentMark[i];
                if (studentMark[i] < Min) Min = studentMark[i];

                total += studentMark[i];

            }
            Mean = total / studentName.Length;
        }
        // Show mean , max and min marks 
        private void ShowStatistics()
        {
            CalculateStatistics();
            Console.WriteLine("-------Marks Statistics-------");
            Console.WriteLine("Maximum Marks ="+Max);
            Console.WriteLine("Minimum Marks ="+Min);
            Console.WriteLine("Mean          ="+Mean);


            Run();
        }

        //Show heading
        private void Outputheading()
        {
            Console.WriteLine(" =================================================");
            Console.WriteLine("   App03 | Student Marks | By Muhammad Shakeel");
            Console.WriteLine(" =================================================");
        }


        //input marks for all students
        private void InputMarks()
        {
            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine("Enter student Mark for "+studentName[i]);
                studentMark[i]= Convert.ToInt32(Console.ReadLine());

            }
            Run();
        }
        //Show all marks for students
        private void ShowMarks()
        {
            for(int i=0;i<studentName.Length;i++)
            {
                Console.WriteLine(studentName[i] + " Got " + studentMark[i] + " Marks");
            }


            Run();
        }
        //Show grades
        private void ShowGrades()
        {
            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine(studentName[i] + " Got " + studentMark[i] + " Marks | "+CalculateGrades(studentMark[i])+ " Grade");
            }
            Run();
        }
        //calculate number into grades
        private string CalculateGrades(int mark)
        {

            if (mark >= 70 & mark <= 100)
                return $"{Grades.A}";
            if (mark >= 60 & mark <= 69)
                return $"{Grades.B}";
            if (mark >= 50 & mark <= 59)
                return $"{Grades.C}";
            if (mark >= 40 & mark <= 49)
                return $"{Grades.D}";
            if (mark >= 0 & mark <= 39)
                return $"{Grades.F}";
            else
                return "X";

        }
    }
}
