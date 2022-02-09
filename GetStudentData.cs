using System;
using System.Text.RegularExpressions;


namespace ClassRegister
{
    //Displays welcome message one line at a time with 2 seconds delay
    public class GetStudentData
    {

        public void Message()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string WelcomeMessage1 = "Welcome to world of developers. It's a class for programmers,with the ultimate";
            string WelcomeMessage2 = "intent of collectively increasing the sum total of good programming knowledge in the world";
            string WelcomeMessage3 = "No matter what programming language you use, better programming is our goal.\n";

            string[] WelcomeMessage = { WelcomeMessage1, WelcomeMessage2, WelcomeMessage3 };
            foreach (string message in WelcomeMessage)
            {
                Console.WriteLine(message);
                Thread.Sleep(500);
            }

        }

        public string GetFirstName()
        {
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Enter your First Name: ");
            return Console.ReadLine();

        }

        public string GetLastName()
        {
            Console.WriteLine("Enter your Last Name: ");
            return Console.ReadLine();
        }

        public Gender GetGender()
        {
            Console.WriteLine("Please enter the number next to your gender: ");
            Console.WriteLine("Enter 1 -> Male");
            Console.WriteLine("Enter 2 -> Female");
            Console.WriteLine("Enter 3 -> Ohers");

            string choice = Console.ReadLine();

            while (!Regex.IsMatch(choice, @"^[1|2|3]{1}$"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You input is invalid. Choose one of the Options");
                choice = Console.ReadLine();
            }
            
            if (choice == "1")
            {
                return Gender.Male;
            }
            else if (choice == "2")
            {
                return Gender.Female;
            }
            else
            {
                return Gender.Other;
            }


        }
        //This method takes a string and split it into an array using space as the delimiter
        public string[] Gadgets()
        {
            Console.WriteLine("Enter the list of your Gadgets separated by space: ");
            string txt = Console.ReadLine();
            string[] gadgets = txt.Split(' ');
            return gadgets;
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