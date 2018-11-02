using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement2
{
    public interface IMenu
    {
        
        void AdminAccess();
        void StudentAccess(IStudent student);
        
    }
}