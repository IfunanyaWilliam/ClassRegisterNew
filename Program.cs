using System;
using System.Text.RegularExpressions;

namespace ClassRegister

{
    class Program
    {

        static void Main()
        {

            //Student student2 = new Student()
            //{
            //    Firstname = "Isaac",
            //    Lastname = "Raphael",
            //    Gender = Gender.Male,
            //    Gadgets = new string[] { "Hp Laptop", "Nokia 3310", "Backpack" }
            //};

            //Student[] students = new Student[]
            //{
            //    student,
            //    student2,
            //    new Student()
            //    {
            //        Firstname = "Sarah",
            //        Gender = Gender.Female,
            //        Gadgets = new string[] { "Hp Laptop", "Samsung galaxy s12", "Handbag" }
            //    },

            //};


            GetStudentData getStudentData = new GetStudentData();
            getStudentData.Message();
            string firstName = getStudentData.GetFirstName();
            string lastName = getStudentData.GetLastName();
            Gender gender = getStudentData.GetGender();

            string[] Studentgadget = getStudentData.Gadgets();


            //This is an instance of the student class
            Student student = new Student()
            {
                Firstname = firstName,
                Lastname = lastName,
                Gender = gender,
                Gadgets = Studentgadget
            };
            //This is an instance of student from the DotNetClass
            Student[] students = new Student[] {student};












            DotNetClass netClass = new DotNetClass(students);
            netClass.PrintClassDetails();


        }
    }

}



//class object
//field representing total number of students
//field representing the list of students in the class
//method to set the number of students
//method to add students to the class
//method to remove student from class
//class name
//class description


//student object
//student name
//student gender
//student gadgets
//student id