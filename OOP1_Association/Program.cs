namespace OOP1_Association
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grade student1 = new Grade(91, 111222);
            Grade student2 = new Grade(52, 220033);
            Grade student3 = new Grade(77, 303101);
            //Grade student4 = new Grade(88, 404202);

            GradeList gradeList = new GradeList(3);
            //gradeList.addGrade(student4);
            gradeList.addGrade(student1);
            gradeList.addGrade(student2);
            gradeList.addGrade(student3);

            Grade[] grades = gradeList.getAllGrades();
            foreach (Grade grade in grades)
            {
                Console.WriteLine("Student ID: " + grade.getStudentID() + " Point: " + grade.getPoint());
            }

            Console.WriteLine("Average: " + gradeList.getAverage());
            Console.WriteLine("Size: " + gradeList.getSize());

            Grade grade2 = gradeList.getGrade((student1.getStudentID()));
            Console.WriteLine(grade2.getPoint());


        }
    }
}
