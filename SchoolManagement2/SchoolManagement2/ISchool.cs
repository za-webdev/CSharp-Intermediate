using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public interface ISchool
    {
        void EnrollAStudent();
        void ShowAllStudents();
        void GenerateSchedule();
        void ShowSchedule();
        void CalculateGPA();
        //void CalculateOverAllScore();
    }
}
