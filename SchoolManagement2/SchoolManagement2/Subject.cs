using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SchoolManagement2
{
    [XmlInclude(typeof(Math))]
    [XmlInclude(typeof(Biology))]
    [XmlInclude(typeof(Sociology))]
    [XmlInclude(typeof(Gym))]
    [XmlInclude(typeof(Algebra))]
    [XmlInclude(typeof(English))]
    [XmlInclude(typeof(History))]
    [XmlInclude(typeof(Zoology))]
    [XmlInclude(typeof(Chemistry))]

    public abstract class Subject
    {
        public string Name { get; set; }
        public int Attendance { get; set; }
        public int HomeWork { get; set; }
        public int FinalExam { get; set; }
        public int Quiz { get; set; }
        public int HomeWorkGrade { get; set; }
        public int QuizGrade { get; set; }
        public int FinalExamGrade { get; set; }
        public int AttendanceGrade { get; set; }
        public int Sum { get; set; }

        public Random rnd = new Random();

        public abstract int ScoringSystem();

    }
}