namespace ConsoleApp1
{
    public class ExamBonus:EventArgs
    {
        public virtual float Bonus
        {
            get
            {
                float _bonus = 0.0f;

                switch (DateTime.Now.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                    case DayOfWeek.Monday:
                    case DayOfWeek.Tuesday:
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Thursday:
                        _bonus = 1000;
                        break;
                    case DayOfWeek.Friday:
                    case DayOfWeek.Saturday:
                        _bonus = 2000;
                        break;
                }
                return _bonus;
            }
        }
    }
}
