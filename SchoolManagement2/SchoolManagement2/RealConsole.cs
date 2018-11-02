using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{
    public class RealConsole : IOutPut, IInPut
    {
        //public MyRealConsole()
        //{

        //}
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string str)
        {
            Console.WriteLine(str);
        }
    }
}
