using SchoolManagement2;
using NUnit.Framework;


namespace SchoolUnitTest
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void CheckIfTheUserIsAdmin_AccessAdminMethodFromMenu()
        {
            //Setup
            var fakeMenu = new FakeMenu();
            var fakeConsole = new FakeConsole();
            var school = new School();
            var welcome = new Welcome(fakeMenu, fakeConsole, fakeConsole);
            fakeConsole.UserInput = "admin";

            //Act
            welcome.Hello(school);

            //Assert
            Assert.AreEqual("GotToAdminAccessMethod", fakeMenu.result);

        }
        //[Test]
        //public void CheckIfTheUserIsStudent_AccessStudentMethodFromMenu()
        //{
        //    //Setup
        //    var fakeMenu = new FakeMenu();
        //    var fakeConsole = new FakeConsole();
        //    var school = new School();

        //    var welcome = new Welcome(fakeMenu, fakeConsole, fakeConsole);
        //    fakeConsole.UserInput = "StuDent";

        //    //Act
        //    welcome.Hello(school);

        //    //Assert
        //    Assert.AreEqual("GotToStudentAccessMethod", fakeMenu.result);

        //}
        //[Test]
        //public void WrongInput_NotAdminNorStudent()
        //{
        //    var fakeMenu = new FakeMenu();
        //    var fakeConsole = new FakeConsole();
        //    var school = new School();
        //    var welcome = new Welcome(fakeMenu, fakeConsole, fakeConsole);
        //    var fakeWelcome = new FakeWelcome();
        //    fakeConsole.UserInput = "ghghyghg...";

        //    welcome.Hello(school);

        //    Assert.AreEqual("GotToHelloMethodAgain", fakeWelcome.Hello(school));
        //}

        [Test]
        public void AdminAccessOPtions_SwithCase1_ForAddingStudnet()
        {
            var fakeSchool = new FakeSchool();
            var fakeConsole = new FakeConsole();
            var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
            fakeConsole.UserInput = "1";
            menu.InputConsole = fakeConsole;

            menu.AdminAccess();

            Assert.AreEqual("GotToEnrollStudentMethod", fakeSchool.result);

        }

        [Test]
        public void AdminAccessOPtions_SwithCase2_ToShowAllStudent()
        {
            var fakeSchool = new FakeSchool();
            var fakeConsole = new FakeConsole();
            var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
            fakeConsole.UserInput = "2";
            menu.InputConsole = fakeConsole;

            menu.AdminAccess();

            Assert.AreEqual("GotToShowAllStudentsMethod", fakeSchool.result);

        }

        [Test]
        public void AdminAccessOPtions_SwithCase3_ToGenerateScheduleForStudent()
        {
            var fakeSchool = new FakeSchool();
            var fakeConsole = new FakeConsole();
            var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
            fakeConsole.UserInput = "3";
            menu.InputConsole = fakeConsole;

            menu.AdminAccess();

            Assert.AreEqual("GotToGenerateScheduleMethod", fakeSchool.result);

        }
        [Test]
        public void AdminAccessOPtions_SwithCase4_ToShowScheduleForStudent()
        {
            var fakeSchool = new FakeSchool();
            var fakeConsole = new FakeConsole();
            var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
            fakeConsole.UserInput = "4";
            menu.InputConsole = fakeConsole;

            menu.AdminAccess();

            Assert.AreEqual("GotToShowStudentScheduleMethod", fakeSchool.result);

        }

        //[Test]
        //public void AdminAccessOPtions_SwithCaseForDefault()
        //{
        //    var fakeSchool = new FakeSchool();
        //    var fakeConsole = new FakeConsole();
        //    var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
        //    fakeConsole.UserInput = "gfdgdfgfhs";
        //    menu.InputConsole = fakeConsole;

        //    menu.AdminAccess();

        //    Assert.AreEqual(null, fakeSchool.result);

        //}
        //[Test]
        //public void StudentAccessOPtions_SwithCase1_ForAddingDescription()
        //{
        //    var fakeSchool = new FakeSchool();
        //    var fakeStudent = new FakeStudent();
        //    var fakeConsole = new FakeConsole();
        //    var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
        //    fakeConsole.UserInput = "1";
        //    menu.InputConsole = fakeConsole;

        //    menu.StudentAccess(fakeStudent);

        //    Assert.AreEqual("GotToAddDescriptionMethod", fakeStudent.result);

        //}
        [Test]
        public void StudentAccessOPtions_SwithCase2_ToShowDescription()
        {
            var fakeSchool = new FakeSchool();
            var fakeStudent = new FakeStudent();
            var fakeConsole = new FakeConsole();
            var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
            fakeConsole.UserInput = "2";
            menu.InputConsole = fakeConsole;

            menu.StudentAccess(fakeStudent);

            Assert.AreEqual("GottoShowDescriptionMethod", fakeStudent.result);
        }
        [Test]
        public void StudentAccessOPtions_SwithCase3_ToShowSchedule()
        {
            var fakeSchool = new FakeSchool();
            var fakeStudent = new FakeStudent();
            var fakeConsole = new FakeConsole();
            var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
            fakeConsole.UserInput = "3";
            menu.InputConsole = fakeConsole;

            menu.StudentAccess(fakeStudent);

            Assert.AreEqual("GotToShowScheduleMethod", fakeStudent.result);

        }
        [Test]
        public void StudentAccessOPtions_SwithCase4_ToShowOverAllScore()
        {
            var fakeSchool = new FakeSchool();
            var fakeStudent = new FakeStudent();
            var fakeConsole = new FakeConsole();
            var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
            fakeConsole.UserInput = "4";
            menu.InputConsole = fakeConsole;

            menu.StudentAccess(fakeStudent);

            Assert.AreEqual("GotToShowOverAllScoreMethod", fakeStudent.result);

        }

        //[Test]
        //public void StudentAccessOPtions_SwithCaseForDefault()
        //{
        //    var fakeSchool = new FakeSchool();
        //    var fakeStudent = new FakeStudent();
        //    var fakeConsole = new FakeConsole();
        //    var menu = new Menu(fakeConsole, fakeConsole, fakeSchool);
        //    fakeConsole.UserInput = "gfdgdfgfhs";
        //    menu.InputConsole = fakeConsole;

        //    menu.StudentAccess(fakeStudent);

        //    Assert.AreEqual(null, fakeStudent.result);

        //}

        [Test]
        public void AddNewStudentToListOfStudent_SchoolClass()
        {
            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);

            fakeConsole.UserInput = "ali";
            school.InputConsole = fakeConsole;

            school.EnrollAStudent();
            Assert.IsNotEmpty(school.ListOfStudents);

        }

        [Test]
        public void AddNewStudentToListOfStudent_CheckForDuplicateNameofStudent()
        {

            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);
            school.ListOfStudents.Add(new Student("ali"));

            fakeConsole.UserInput = "ali";
            school.InputConsole = fakeConsole;
            school.EnrollAStudent();

            Assert.AreEqual(true, school.IsPresent);

        }

        [Test]
        public void AddNewStudentToListOfStudent_CheckIfNameofStudentIsUnique()
        {

            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);

            fakeConsole.UserInput = "ali";
            school.InputConsole = fakeConsole;
            school.EnrollAStudent();

            fakeConsole.UserInput = "zoya";

            school.EnrollAStudent();

            Assert.AreEqual(false, school.IsPresent);

        }

        [Test]
        public void ShowListOfAllStudent_GoThroughForEachLoop()
        {
            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);

            fakeConsole.UserInput = "ali";
            school.InputConsole = fakeConsole;
            school.EnrollAStudent();

            school.ShowAllStudents();

            Assert.AreEqual("ali", fakeConsole.OutputString);
        }

        [Test]
        public void GenerateListOfSubjects_CheckIfTheStudentExistInTheListOfStudents()
        {
            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);

            fakeConsole.UserInput = "ali";
            school.EnrollAStudent();

            fakeConsole.UserInput = "ali";

            school.GenerateSchedule();

            Assert.AreEqual(true, school.IsPresent);


        }
        [Test]
        public void GenerateListOfSubjects_CheckIfTheStudentDoesNotExistInTheListOfStudents()
        {
            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);
            school.ListOfStudents.Add(new Student("ali"));
            fakeConsole.UserInput = "zoya";
            school.GenerateSchedule();
            Assert.AreEqual(false, school.IsPresent);


        }
        [Test]
        public void ShowScheduleForStudent_CheckIfTheStudentExistInTheListOfStudents()
        {
            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);

            school.ListOfStudents.Add(new Student("zoya"));

            fakeConsole.UserInput = "zoya";

            school.ShowSchedule();

            Assert.AreEqual(true, school.IsPresent);


        }
        [Test]
        public void ShowScheduleForStudent_CheckIfTheStudentDoesNotExistInTheListOfStudents()
        {
            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);

            school.ListOfStudents.Add(new Student("ali"));

            fakeConsole.UserInput = "zoya";

            school.ShowSchedule();

            Assert.AreEqual(false, school.IsPresent);


        }
        [Test]
        public void ShowListOfAllSubjectsForAStudent_GoThroughForEachLoop()
        {
            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);
            var student = new Student();
            school.ListOfStudents.Add(student);
            student.listOfSubjects.Add(new Biology("bio"));

            school.ShowSchedule();

            Assert.AreEqual("bio", fakeConsole.OutputString);
        }
        [Test]
        public void AddSubjectToAllSubjectsList_SchoolClass()
        {
            var fakeConsole = new FakeConsole();
            var school = new School(fakeConsole, fakeConsole);

            Assert.AreEqual(9, school.AllSubjects.Count);

        }
    }
}
