using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        IList<int> intList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };


        Console.WriteLine(intList.Count);

        IList<Student> studentList = new List<Student>() {
                new Student(){ StudentID=1, StudentName="Amol"},
                new Student(){ StudentID=2, StudentName="Anil"},
                new Student(){ StudentID=3, StudentName="Rahul"},
                new Student(){ StudentID=4, StudentName="Vishaal"}
            };

        Console.WriteLine(studentList.Count);

    }
}

public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }

}