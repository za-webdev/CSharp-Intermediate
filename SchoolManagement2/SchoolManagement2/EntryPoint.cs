using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SchoolManagement2
{

   
    public class EntryPoint
    {
        static void Main(string[] args)

        {
            var realConsole = new RealConsole();
            School school;

            try
            {
                school = Repository.Deserialize<School>(@"C:\Users\zali\Desktop\test.xml");

                // Initialize the ignored properties:
                school.OutputConsole = new RealConsole();
                school.InputConsole = new RealConsole();
            }
            catch
            {
                school = new School(realConsole, realConsole);
            }

            var welcome = new Welcome(new Menu(realConsole, realConsole, school), realConsole, realConsole);


            string Wish;
            do
            {
                Wish = welcome.Hello(school);
                if (Wish.ToLower() == "no" || Wish.ToLower() == "n")
                {
                    Repository.Serialize<School>(school, @"C:\Users\zali\Desktop\test.xml");

                    break;
                }
            }
            while (Wish.ToLower() == "yes" || Wish.ToLower() == "y");

        }
    }
}