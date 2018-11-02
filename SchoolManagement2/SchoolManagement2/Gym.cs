using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public class Gym : Subject
    {
        public int Cleanliness { get; set; }
        public int CleanlinessGrade { get; set; }
        public Gym()
        {

        }

        public Gym(string name)
        {
            Name = name;
            Attendance = 80;
            Cleanliness = 20;
            
            
        }


        public override int ScoringSystem()
        {
            
            AttendanceGrade = rnd.Next(0, Attendance + 1);
            CleanlinessGrade = rnd.Next(0, Cleanliness + 1);
            Sum = AttendanceGrade + CleanlinessGrade;
            return Sum;
        }
    }
}
