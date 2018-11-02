using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public class Chemistry:Biology
    {
        public Chemistry()
        {

        }
        public Chemistry(string name)
        {
            Name = name;
            HomeWork = 20;
            Attendance = 20;
            FinalExam = 50;
            PracticalLab = 10;
        }
    }
}
