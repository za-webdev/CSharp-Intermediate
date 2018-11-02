using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
   public class FakeMenu: IMenu
    {
        public string InputString;
        public string OutputString;
        public string result;

        public void AdminAccess()
        {
            result = "GotToAdminAccessMethod";
        }

        //public void StudentAccess()
        //{
        //    result = "GotToStudentAccessMethod";
        //}

        public void StudentAccess(IStudent student)
        {
            result = "GotToStudentAccessMethod";
        }

        public void WriteLine(string str)
        {
            OutputString = str;
        }

    }

}

