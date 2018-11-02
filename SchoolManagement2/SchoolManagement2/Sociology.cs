using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public class Sociology : Subject
    {
        public int Research { get; set; }
        public int ResearchGrade { get; set; }
        public Sociology()
        {

        }

        public Sociology(string name)
        {
            Name = name;
            HomeWork = 10;
            Attendance = 20;
            FinalExam = 40;
            Research = 20;
        }


        public override int ScoringSystem()
        {
            HomeWorkGrade = rnd.Next(0, HomeWork + 1);
            AttendanceGrade = rnd.Next(0, Attendance + 1);
            FinalExamGrade = rnd.Next(0, FinalExam + 1);
            ResearchGrade = rnd.Next(0, Quiz + 1);
            Sum = HomeWorkGrade + AttendanceGrade + FinalExamGrade + ResearchGrade;
            return Sum;
        }
    }
}
