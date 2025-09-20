namespace ConsoleApp1
{
    public class Exam
    {
        public string Name { get; set; }

        private ExamStatus status;

        //Before Event
        // public Action onexamstarted;

        //After Event
        //public event Action onexamstarted;

        //Useing Event Handeler Method
       // public event EventHandler examstarted;
        
        public event EventHandler<ExamBonus> examstarted;

        public ExamStatus Status
        {
            get { return status; }
            set
            {
                status = value;
                if (status == ExamStatus.Started)
                {
                    //ivokation
                    //notify subscribers : firing for event

                    //Before Event Handeler Method
                    // onexamstarted?.Invoke();

                    //Useing Event Handeler Method
                    OnExamstarted(this, new ExamBonus());

                }
            }
        }

        protected virtual void OnExamstarted(object sender, ExamBonus e)
        {
            //Fire
            examstarted?.Invoke(sender, e);
        }

        public override string ToString()
        {
            return $"Exam : {Name} , Status : {Status}";
        }
    }

 
}
