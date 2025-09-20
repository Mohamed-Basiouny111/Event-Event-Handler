namespace ConsoleApp1
{
    public class Student
    {
        public string Name { get; set; }

        public void AttendExam(object sender, EventArgs e)
        {
            Console.WriteLine($"{Name} : attend Exam - {(sender as Exam).Name}");
        }

        public void IgnoreExam(object sender, EventArgs e)
        {
            Console.WriteLine($"{Name} : Ignore Exam - {(sender as Exam).Name}");
        }

        public void Donothing(object sender, EventArgs e)
        {
            Console.WriteLine($"{Name} : DoNothing - {(sender as Exam).Name}");
        }

        public override string ToString()
        {
            return $"Student Data : {Name}"; 

        }
    }
}
