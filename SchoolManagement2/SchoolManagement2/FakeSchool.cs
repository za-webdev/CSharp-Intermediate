using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public class FakeSchool :ISchool
    {
        public string InputString;
        public string OutputString;
        public string result ;

        public void EnrollAStudent()
        {
            result = "GotToEnrollStudentMethod";
        }


        public void ShowAllStudents()
        {
            result = "GotToShowAllStudentsMethod";
        }

        public void GenerateSchedule()
        {
            result = "GotToGenerateScheduleMethod";

        }

        public void ShowSchedule()
        {
            result = "GotToShowStudentScheduleMethod";

        }

        public void CalculateGPA()
        {
            
        }

        public void CalculateOverAllScore()
        {
            result = "GotToCalculateOverAllScore";
        }
    }
}
