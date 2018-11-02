using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public class FakeStudent :IStudent
    {
        public string InputString;
        public string OutputString;
        public string result;
        public List<Subject> listOfSubjects { get; set; } = new List<Subject>();

        public void AddDescription(string description)
        {
            result = "GotToAddDescriptionMethod";
        }
        public void ShowDescription()
        {
           result="GottoShowDescriptionMethod";
        }
        public void OverAllScore()
        {
            result = "GotToOverAllScoreMethod";
        }

        public void ShowSchedule()
        {
            result = "GotToShowScheduleMethod";
        }

        public void ShowOverAllScore()
        {
            result = "GotToShowOverAllScoreMethod";
        }
    }
}
