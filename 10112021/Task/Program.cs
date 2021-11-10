using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AddExam("Riyaziyyat", 65);
            student.AddExam("Ana dili", 85);
            student.AddExam("Edebiyyat", 75);
            student.AddExam("Proqramlasdirma", 5);
            student.AddExam("Idman", 95);


            Console.WriteLine($"Avg point: {student.CalcAvgPoint()}");
            Console.WriteLine($"Exams count: {student.FindExamsCount(x=>x>51)}");
            Console.WriteLine($"Exams count: {student.FindExamsCount(x => x <51)}");
            Console.WriteLine($"Exams count: {student.FindExamsCount(delegate(int n) { return n > 80; })}");
        }
    }
}
