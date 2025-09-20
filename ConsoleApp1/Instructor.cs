namespace ConsoleApp1
{
    class Instructor
    {
        public string Name { get; set; }

        public void ControlExam(object sender, ExamBonus e)
        {
            Console.WriteLine($"Instructor : {Name} - Control Exam - {(sender as Exam).Name}- Bonus : {e.Bonus}");
        }
    }
}
