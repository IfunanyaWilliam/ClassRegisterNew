
namespace ClassRegister
{
    public class Student
    {
        
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public string Firstname { get ; set ; }
        public string Lastname { get; set; }
        public string Fullname
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Lastname) ? $"{Lastname} {Firstname}" : Firstname;
            }
        }
        public Gender Gender { get; set; }
        public string[] Gadgets { get; set; }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Here are your details");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            return $"Id: {Id}\nFullname: {Fullname}\nGender: {Gender}\nGadgets: {string.Join(", ", Gadgets)}\n";
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