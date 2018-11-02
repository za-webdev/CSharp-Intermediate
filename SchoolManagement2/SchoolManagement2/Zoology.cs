using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
   public class Zoology :Subject
    {
        public int PracticalLab { get; set; }
        public int PracticalLabGrade { get; set; }
        public Zoology()
        {

        }
        public Zoology(string name)
        {
            Name = name;
            HomeWork = 20;
            Attendance = 20;
            FinalExam = 50;
            PracticalLab = 10;
        }

        public override int ScoringSystem()
        {
            HomeWorkGrade = rnd.Next(0, HomeWork + 1);
            AttendanceGrade = rnd.Next(0, Attendance + 1);
            FinalExamGrade = rnd.Next(0, FinalExam + 1);
            PracticalLabGrade = rnd.Next(0, Quiz + 1);
            Sum = HomeWorkGrade + AttendanceGrade + FinalExamGrade + PracticalLabGrade;
            return Sum;
        }
    }
}
