namespace ConsoleApp1
{
    class Manager
    {
        public string Name { get; set; }

        public void ManageExam(object sender, ExamBonus e)
        {
            Console.WriteLine($"Manager : {Name} - Manage Exam - {(sender as Exam).Name} - Bonus : {e.Bonus}");
        }
    }

}
