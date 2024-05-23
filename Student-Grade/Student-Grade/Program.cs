// See https://aka.ms/new-console-template for more information
using Student_Grade;
bool exit = true;
Classroom classroom = new Classroom();
while (exit) { 
Console.WriteLine("Enter the number students that want to you introduce: ");
int numberStudents;
bool isNumber = int.TryParse(Console.ReadLine(), out numberStudents);
    if (!isNumber || numberStudents < 0)
    {
        Console.WriteLine("Please enter a valid number.");
    }
    else
    {
        for (int i = 0; i < numberStudents; i++)
        {
            Console.Write("Introduce the student's name: ");
            string name = Console.ReadLine();

            Student student = new Student(name);

            Console.Write("Introduce the student's grades (separated by spaces): ");
            string gradesInput = Console.ReadLine();

            string[] gradesStrings = gradesInput.Split(' ');

            foreach (string gradeString in gradesStrings)
            {
                int grade = int.Parse(gradeString);
                student.AddGrade(grade);
            }

            classroom.AddStudent(student);
        }
        exit = false;
    }

}

Console.WriteLine("Class average grade: " + classroom.GetClassAverageGrade());