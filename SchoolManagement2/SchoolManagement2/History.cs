using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
   public class History :English
    {
        public History()
        {

        }
        public History(string name)
        {
            Name = name;
            HomeWork = 20;
            Attendance = 20;
            FinalExam = 40;
            Quiz = 20;

        }
    }
}
