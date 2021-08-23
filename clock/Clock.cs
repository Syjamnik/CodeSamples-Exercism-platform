using System;

public class Clock
{
    protected readonly Time _time;
    public const int MinutesInDay = 24 * 60;

    public Clock(int hours, int minutes)
    {
        int totalMinutes = (hours * 60) + minutes;
        //_time = new Time((totalMinutes/60)%24, totalMinutes % 60);
        _time = GetTimeFromMinutes(totalMinutes);
    }
  
    
    protected Time GetTimeFromMinutes(int minutesToAdd)
    {
        int  totalTime = minutesToAdd + _time.TotalMinutes;
        if (totalTime >= 0)
            return new Time((totalTime / 60)%24, (totalTime % 60));
        else
        {
            int timeInDayLeft = MinutesInDay + (totalTime % MinutesInDay);
            return new Time((timeInDayLeft / 60)%24 , (timeInDayLeft % 60));

        }
    }
  
    
    public Clock Add(int minutesToAdd)
    {
        Time time = GetTimeFromMinutes(minutesToAdd);
        return new Clock(time.Hours,time.Minutes);
    }

    
    
    public Clock Subtract(int minutesToSubtract)
    {
        Time time = GetTimeFromMinutes(minutesToSubtract*(-1));
        return new Clock(time.Hours, time.Minutes);
    }





    protected struct Time
    {
        public Time(int hours, int minutes)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.TotalMinutes = (this.Hours*60) + this.Minutes;
        }
        public readonly int Hours { get; }
        public readonly int Minutes { get; }
        public readonly int TotalMinutes { get; }

    }
    public override string ToString() => $"{Convert.ToString(_time.Hours).PadLeft(2,'0')}:{Convert.ToString(_time.Minutes).PadLeft(2, '0')}";
    public override int GetHashCode() => _time.TotalMinutes * (_time.Minutes ^ 2)<<3  * _time.Hours<<2;
    public override bool Equals(object obj) => (obj is Clock)? this.GetHashCode() == obj.GetHashCode(): throw new ArgumentException("You can not use equals on different classes");
}
