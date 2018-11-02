using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public class English : Subject

    {
        public English()
        {

        }
        public English(String name )
        {
            Name = name;
            HomeWork = 20;
            Attendance = 20;
            FinalExam = 40;
            Quiz = 20;

        }
               
            public override int ScoringSystem()
        {
            HomeWorkGrade = rnd.Next(0, HomeWork + 1);
            AttendanceGrade = rnd.Next(0, Attendance + 1);
            FinalExamGrade = rnd.Next(0, FinalExam + 1);
            QuizGrade = rnd.Next(0, Quiz + 1);
            Sum = HomeWorkGrade + AttendanceGrade + FinalExamGrade + QuizGrade;
            return Sum;
        }
    }
    
}
