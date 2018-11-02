using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
   public class Physics :Math
    {
        public Physics()
        {

        }
        public Physics(string name)
        {
            Name = name;
            HomeWork = 20;
            Attendance = 20;
            FinalExam = 50;
            Quiz = 10;
        }
    }
}
