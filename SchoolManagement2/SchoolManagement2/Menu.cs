using System;
using System.Xml.Serialization;

namespace SchoolManagement2
{
    public class Menu : IMenu
    {

        public ISchool MySchool;
        public IStudent Student;
        [XmlIgnore]
        public IInPut InputConsole { get; set; }
        [XmlIgnore]
        public IOutPut OutputConsole { get; set; }
        private Admin MyAdmin { get; set; }
        

        public Menu()
        {

        }
        public Menu(IInPut Input, IOutPut output, ISchool school)
        {
            InputConsole = Input;
            OutputConsole = output;
            MySchool = school;
            MyAdmin = new Admin(MySchool);



        }
        public void AdminAccess()
        {

            OutputConsole.WriteLine("Please Choose from the following:");
            OutputConsole.WriteLine("1 = Enroll a studnet");
            OutputConsole.WriteLine("2 = Show all the students");
            OutputConsole.WriteLine("3 = Add schedule for a student");
            OutputConsole.WriteLine("4 = Show schedule of a student");
            OutputConsole.WriteLine("5 = Find GPA of a student");

            var choicesForAdmin = InputConsole.ReadLine().ToLower();

            switch (choicesForAdmin)
            {
                case "1":
                    MySchool.EnrollAStudent();
                    break;
                case "2":
                    MySchool.ShowAllStudents();
                    break;
                case "3":
                    MySchool.GenerateSchedule();
                    break;
                case "4":
                    MySchool.ShowSchedule();
                    break;
                case "5":
                    MySchool.CalculateGPA();
                    break;
                default:
                    OutputConsole.WriteLine("Invalid Input");
                    AdminAccess();
                    break;
            }
        }

        public void StudentAccess(IStudent student)
        {
            Student = student;
            OutputConsole.WriteLine("Choose from the Following options:");
            OutputConsole.WriteLine("1 = Add Description");
            OutputConsole.WriteLine("2 = Show My Description");
            OutputConsole.WriteLine("3 = Show My Schedule");
            OutputConsole.WriteLine("4 = Show My OverAll Score");

            var choicesForStudent = InputConsole.ReadLine().ToLower();

            switch (choicesForStudent)
            {
                case "1":
                    Console.WriteLine("say something");
                    var fromConsole = Console.ReadLine();
                    student.AddDescription(fromConsole);

                    break;
                case "2":
                    student.ShowDescription();
                    break;
                case "3":
                    student.ShowSchedule();
                    break;
                case "4":
                    Student.ShowOverAllScore();
                    break;

                default:
                    OutputConsole.WriteLine("Invalid Input");
                    StudentAccess(student);
                    break;
            }
        }


    }
}