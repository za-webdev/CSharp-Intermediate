using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public interface IStudent
    {
        void AddDescription(string description);
        void ShowDescription();
        void ShowSchedule();
        void ShowOverAllScore();
        void OverAllScore();
    }
}
