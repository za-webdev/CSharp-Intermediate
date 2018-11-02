using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement2
{ 
        public interface IInPut
        {
            string ReadLine();
        }

        public interface IOutPut
        {
            void WriteLine(string str);
        }
    
}
