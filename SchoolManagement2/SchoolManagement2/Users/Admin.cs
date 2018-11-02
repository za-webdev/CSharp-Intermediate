using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement2
{
    public class Admin
    {
        public ISchool MySchool { get; set; }

        public Admin(ISchool school)
        {
            MySchool = school;
        }

        public Admin()
        {

        }
        
    }
}