using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SchoolManagement2
{
    public class Student :IStudent
    {

        [XmlIgnore]
        public IInPut InputConsole { get; set; }
        [XmlIgnore]
        public IOutPut OutputConsole { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StudentNameFromConsole { get; set; }
        public string StudentInput { get; set; }
        public int GrandSum { get; set; }
        public List<Subject> listOfSubjects { get; set; } = new List<Subject>();
        public bool IsPresent { get; set; }

        
        public Student()
        {

        }
        public Student(string name)
        {
            Name = name;
        }

        public void AddDescription(string description)
        {
            Description = description;
            
        }
        public void ShowDescription()
        {
            Console.WriteLine(Description);
        }

        public void ShowSchedule()
        {
            if(listOfSubjects.Count == 0)
            {
                Console.WriteLine("You donot have a schedule yet");
            }
            else
            {
                foreach(var subject in listOfSubjects)
                {
                    Console.WriteLine(subject.Name);
                }
            }
        }

        public void OverAllScore()
        {
            
            if (listOfSubjects.Count == 0)
            {
                Console.WriteLine("You donot have a schedule yet");
            }
            else
            {
                for (int i = 0; i < listOfSubjects.Count; i++)
                {
                    var sum= listOfSubjects[i].ScoringSystem();
                    Console.WriteLine("{0} = {1}", listOfSubjects[i].Name ,sum);
                    GrandSum += sum;
                }
                Console.WriteLine("Total = {0}",GrandSum);
            }

        }

        public void ShowOverAllScore()
        {
            if (GrandSum == 0)
            {
                Console.WriteLine("Your classes has not been scored yet");
            }
            else
                Console.WriteLine("Your over all score is {0}",GrandSum);
        }
      
    }
    }

