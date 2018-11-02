using System;

namespace SchoolManagement2
{
    public class Welcome : IWelcome
    {

        public IInPut InputConsole { get; set; }
        public IOutPut OutputConsole { get; set; }
        public ISchool School { get; set; }
        public string Name { get; set; }
        public bool IsPresent { get; set; }
        private readonly IMenu menu;
       
        public Welcome()
        {

        }
        public Welcome(IMenu menu, IInPut input, IOutPut output)
        {
            this.menu = menu;
            InputConsole = input;
            OutputConsole = output;
        }

        public string Hello(School school)
        {

            var mySchool = school;
            IsPresent = false;
            OutputConsole.WriteLine("who are you? admin/student");
            var userInput = InputConsole.ReadLine();

            if (userInput.ToLower() != "admin" && userInput.ToLower() != "student")
            {
                Console.WriteLine("Invalid Input");
                Hello(mySchool);
            }
            else if (userInput.ToLower() == "admin")
            {
                menu.AdminAccess();
            }
            else if (userInput.ToLower() == "student")
            {
                OutputConsole.WriteLine("What is your name?");
                var studentName = InputConsole.ReadLine();
                Student student = new Student();
                for (int i = 0; i < mySchool.ListOfStudents.Count; i++)
                {
                    if (studentName == mySchool.ListOfStudents[i].Name)
                    {
                        student = mySchool.ListOfStudents[i];
                        IsPresent = true;
                    }
                }
                if (!IsPresent)
                {
                    Console.WriteLine("Cant find a student by this name.");
                }
                else
                {
                    menu.StudentAccess(student);
                }
            }
            OutputConsole.WriteLine("Do you Wish to continue? yes/no");
            var wish = InputConsole.ReadLine();
            return wish;
        }

    }
}
