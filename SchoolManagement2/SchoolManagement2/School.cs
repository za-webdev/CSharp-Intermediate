using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SchoolManagement2
{
    public class School : ISchool
    {
        [XmlIgnore]
        public IInPut InputConsole { get; set; }
        [XmlIgnore]
        public IOutPut OutputConsole { get; set; }
        public List<Student> ListOfStudents { get; set; } = new List<Student>();
        public List<Subject> AllSubjects { get; set; } = new List<Subject>();
        public string NameFromConsole { get; set; }
        public bool IsPresent { get; set; }
        public Double Total { get; set; }
        public Double GPA { get; set; }

        public School()
        {

        }

        public School(IInPut Input, IOutPut output)
        {
            InputConsole = Input;
            OutputConsole = output;
            AllSubjects.Add(new Math("math"));
            AllSubjects.Add(new Biology("biology"));
            AllSubjects.Add(new Sociology("sociology"));
            AllSubjects.Add(new Gym("gym"));
            AllSubjects.Add(new Zoology("Zoology"));
            AllSubjects.Add(new English("english"));
            AllSubjects.Add(new Chemistry("chemistry"));
            AllSubjects.Add(new Algebra("algebra"));
            AllSubjects.Add(new History("history"));


        }
        public void EnrollAStudent()
        {
            IsPresent = false;
            OutputConsole.WriteLine("Name of Student");
            NameFromConsole = InputConsole.ReadLine();
            if (ListOfStudents.Count == 0)
            {
                ListOfStudents.Add(new Student(NameFromConsole));
            }
            else
            {

                for (int i = 0; i < ListOfStudents.Count; i++)
                {
                    if (ListOfStudents[i].Name == NameFromConsole)
                    {
                        IsPresent = true;
                    }
                }
                if (!IsPresent)
                {
                    ListOfStudents.Add(new Student(NameFromConsole));
                }
                else
                {

                    Console.WriteLine("This student already exists");
                }
            }

        }

        public void ShowAllStudents()
        {
            foreach (var student in ListOfStudents)
            {
                OutputConsole.WriteLine(student.Name);
            }
        }

        public void GenerateSchedule()
        {
            Random rnd = new Random();
            int count = 0;
            IsPresent = false;
            Student student = new Student();
            OutputConsole.WriteLine("Provide name of Student");
            NameFromConsole = InputConsole.ReadLine();
            for (int i = 0; i < ListOfStudents.Count; i++)
            {
                if (ListOfStudents[i].Name == NameFromConsole)
                {
                    student = ListOfStudents[i];
                    IsPresent = true;
                }
            }

            if (!IsPresent)
            {
                OutputConsole.WriteLine("Cant find student by this name in the list of students");
            }
            if(student.listOfSubjects != null)
            {
                Console.WriteLine("you have already set a schedule for this student");
            }
            else
            {
                while (count < 9)
                {
                    Subject subject = AllSubjects[rnd.Next(0, AllSubjects.Count)];
                    if (!student.listOfSubjects.Contains(subject))
                    {
                        student.listOfSubjects.Add(subject);
                    }
                    count++;
                }

            }
        }

        public void ShowSchedule()
        {
            Student student = new Student();
            IsPresent = false;
            OutputConsole.WriteLine("Provide name of Student");
            NameFromConsole = InputConsole.ReadLine();
            for (int i = 0; i < ListOfStudents.Count; i++)
            {
                if (ListOfStudents[i].Name == NameFromConsole)
                {
                    student = ListOfStudents[i];
                    IsPresent = true;
                }

            }
            if (!IsPresent)
            {
                OutputConsole.WriteLine("Cant find student by this name in the list of students");
            }
            else if (student.listOfSubjects.Count == 0)
            {
                Console.WriteLine("No schedule found for this student");
            }

            else
            {
                foreach (var subject in student.listOfSubjects)
                {

                    OutputConsole.WriteLine(subject.Name);
                }

            }

        }
        //public void CalculateOverAllScore()
        //{
        //    Student student = new Student();
        //    IsPresent = false;
        //    OutputConsole.WriteLine("Provide name of Student");
        //    NameFromConsole = InputConsole.ReadLine();
        //    for (int i = 0; i < ListOfStudents.Count; i++)
        //    {
        //        if (ListOfStudents[i].Name == NameFromConsole)
        //        {
        //            student = ListOfStudents[i];
        //            IsPresent = true;
        //        }

        //    }
        //    if (!IsPresent)
        //    {
        //        OutputConsole.WriteLine("Cant find student by this name in the list of students");
        //    }
        //    else if (student.listOfSubjects.Count == 0)
        //    {
        //        Console.WriteLine("No schedule found for this student");
        //    }
        //    else
        //    {
        //        student.OverAllScore();
        //    }

        //}

        public void CalculateGPA()
        {
            Student student = new Student();
            IsPresent = false;

            OutputConsole.WriteLine("Provide name of Student");
            NameFromConsole = InputConsole.ReadLine();
            for (int i = 0; i < ListOfStudents.Count; i++)
            {
                if (ListOfStudents[i].Name == NameFromConsole)
                {
                    student = ListOfStudents[i];
                    IsPresent = true;
                }

            }
            if (!IsPresent)
            {
                OutputConsole.WriteLine("Cant find student by this name in the list of students");
            }
            else if (student.listOfSubjects.Count == 0)
            {
                Console.WriteLine("Set Schedule for this student first");
            }

            else
            {
                student.OverAllScore();
                Total = student.GrandSum / student.listOfSubjects.Count;
                Console.WriteLine(Total);
                GPA = (Total - 50) / 10;
                if (GPA < 0)
                {
                    Console.WriteLine("Student failed GPA is 0");
                }
                if(GPA > 5)
                {
                    Console.WriteLine("GPA is 4.5");
                }
                else if(GPA > 0 && GPA <5 )

                    Console.WriteLine("GPA is {0}",GPA);
            }
        }

        //public void ShowStudentsBasedOnGPA()
        //{
        //    for (int i = 0; i < ListOfStudents.Count; i++)
        //    {
        //        ListOfStudents[i].OverAllScore();
        //        GPA = ListOfStudents[i].GrandSum / (ListOfStudents[i].listOfSubjects.Count - 50) / 10;
        //        Console.WriteLine("{0} - {1}", ListOfStudents[i], GPA);

        //    }

        //}
    }


}



