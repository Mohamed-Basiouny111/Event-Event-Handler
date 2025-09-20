namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region Dealing with event

            #region Before using event keyword
            //Exam Csharp = new Exam() { Name = "CSharp Exam", Status = ExamStatus.Pending};

            ////Subscribers
            //Student Ali = new Student() { Name = "Ali" };
            //Student Mohamed = new Student() { Name = "Mohamed" };
            //Student Ibraheem = new Student() { Name = "Ibraheem" };

            ////subscription : registeration
            //Csharp.onexamstarted += Ali.AttendExam;
            //Csharp.onexamstarted = Ibraheem.IgnoreExam;

            ////firing
            //Csharp.Status = ExamStatus.Started;
            #endregion

            #region After using event keyword

            ////Subscribers
            //Student Ali = new Student() { Name = "Ali" };
            //Student Mohamed = new Student() { Name = "Mohamed" };
            //Student Ibraheem = new Student() { Name = "Ibraheem" };

            ////-----Instructor------
            //Instructor Kareem = new Instructor() { Name = "Kareem" };
            //Instructor Omar = new Instructor() { Name = "Omar" };

            ////-----Manager------
            //Manager Mona = new Manager() { Name = "Mona" };
            //Manager Eman = new Manager() { Name = "Eman" };

            ////After using event
            ////1-Can't use (=) to add Function to invocatin List but can use (+=) OR (-=)
            ////2-Icon Differ from Delegate
            ////3-Can't assign Value to (onexamstarted) in Constructor this special by Subscribers if Before event when use delgate can assign value in constructor

            //Exam Csharp = new Exam() { Name = "CSharp Exam", Status = ExamStatus.Pending };
            ////subscription : registeration
            //Csharp.onexamstarted += Ali.AttendExam;
            //Csharp.onexamstarted += Ibraheem.IgnoreExam;
            //Csharp.onexamstarted += Kareem.ControlExam;
            //Csharp.onexamstarted += Mona.ManageExam;

            ////firing
            //Csharp.Status = ExamStatus.Started;

            //Console.WriteLine("-------------------------------------");

            ////subscription : registeration
            //Exam Js = new Exam() { Name = "JavavScript Exam", Status = ExamStatus.Pending };
            //Js.onexamstarted += Mohamed.AttendExam;
            //Js.onexamstarted += Ibraheem.AttendExam;
            //Js.onexamstarted += Omar.ControlExam;
            //Js.onexamstarted += Eman.ManageExam;

            ////firing
            //Js.Status = ExamStatus.Started;

            #endregion

            #region Useing Event Handeler Method

            //Subscribers
            Student Ali = new Student() { Name = "Ali" };
            Student Mohamed = new Student() { Name = "Mohamed" };
            Student Ibraheem = new Student() { Name = "Ibraheem" };

            //-----Instructor------
            Instructor Kareem = new Instructor() { Name = "Kareem" };
            Instructor Omar = new Instructor() { Name = "Omar" };

            //-----Manager------
            Manager Mona = new Manager() { Name = "Mona" };
            Manager Eman = new Manager() { Name = "Eman" };

            //After using event
            //1-Can't use (=) to add Function to invocatin List but can use (+=) OR (-=)
            //2-Icon Differ from Delegate
            //3-Can't assign Value to (onexamstarted) in Constructor this special by Subscribers if Before event when use delgate can assign value in constructor

            Exam Csharp = new Exam() { Name = "CSharp", Status = ExamStatus.Pending };
            //subscription : registeration
            Csharp.examstarted += Ali.AttendExam;
            Csharp.examstarted += Ibraheem.IgnoreExam;
            Csharp.examstarted += Kareem.ControlExam;
            Csharp.examstarted += Mona.ManageExam;

            //firing
            Csharp.Status = ExamStatus.Started;

            Console.WriteLine("-------------------------------------");

            //subscription : registeration
            Exam Js = new PractiseExam() { Name = "JavavScript", Status = ExamStatus.Pending };
            Js.examstarted += Mohamed.AttendExam;
            Js.examstarted += Ibraheem.AttendExam;
            Js.examstarted += Omar.ControlExam;
            Js.examstarted += Eman.ManageExam;

            //firing
            Js.Status = ExamStatus.Started;

            #endregion

            #endregion
        }

    }
}
