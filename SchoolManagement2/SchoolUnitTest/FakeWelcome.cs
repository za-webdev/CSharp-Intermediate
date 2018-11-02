using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement2;

namespace SchoolUnitTest
{
    class FakeWelcome : IWelcome
    {
        public string InputString;
        public string OutputString;
        private FakeConsole fakeConsole1;
        private FakeConsole fakeConsole2;
        private FakeMenu fakeMenu;

        

        public string Hello(School school)
        {
            return "GotToHelloMethodAgain";
        }
    }
}
