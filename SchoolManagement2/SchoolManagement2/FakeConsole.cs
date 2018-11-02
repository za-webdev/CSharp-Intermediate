using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public class FakeConsole : IOutPut, IInPut
    {
        public string UserInput;
        public string OutputString;
        //public int numberOfTries;

        public string ReadLine()
        {
            //numberOfTries++;
            //if (numberOfTries > 1)
            //{
            //    return "Number of Tries Exceded";
            //}
            return UserInput;
        }

        public void WriteLine(string outputString)
        {
            OutputString = outputString;
        }
    }
}
