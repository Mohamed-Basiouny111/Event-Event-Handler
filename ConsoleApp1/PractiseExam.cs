namespace ConsoleApp1
{
    public class PractiseExam : Exam
    {
        protected override void OnExamstarted(object sender, ExamBonus e)
        {
            base.OnExamstarted(sender, new PractiseBonus());
        }
    }


}
