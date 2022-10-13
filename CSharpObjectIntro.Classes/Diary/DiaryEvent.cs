using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjectIntro.Classes.Diary
{
    public class DiaryEvent
    {
        // Fields 
        private readonly TimeOnly _lunchTime = new(12, 0);

        private DateOnly _date;

        // Properties

        // This property uses a backing field _date
        public DateOnly Date { 
            get
            {
                return _date;
            }
            private set
            {
                _date = value;
            }
        }

        // These properties are auto implemented.
        // The compiler creates fields for each auto-implemented property.
        // The fields aren't accessible directly from the source code.
        // Use auto-implemented properties where your get and set don't need to do anything
        // You can change them to have backing fields later if you need to
        public TimeOnly Time { get; private set; }
        public int Minutes { get; private set; }
        public string Description { get; private set; }
        public string Location { get; private set; }

        // This property doesn't have a direct backing field
        // It could also be written as a method
        // Choose a property over a method if
        // a) Logically speaking it is a property of the class
        // a) No parameters are needed
        // b) The calculation is trivial and not time consuming
        public bool IsMorning
        {
            get
            {
                return Time < _lunchTime;
            }
        }

        // Constructor
        public DiaryEvent(DateOnly date, TimeOnly time, int minutes, string description, string location)
        {
            Date = date;
            Time = time;
            Minutes = minutes;
            Description = description;
            Location = location;
        }
    }
}
