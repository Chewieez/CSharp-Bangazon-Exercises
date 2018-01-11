using System;

namespace bangazon
{
    public class HRDayShiftEmployee : Employee, IFullTime, IDeptLocation, IDayShift
    {
        private double _salary;
        private string _shiftHours;
        private int _breakFrequency;

        public string Location 
        { 
            get {return Location;}
            set {}
        }

        public double Salary 
        { 
            get { return _salary; }
            set {
                // We pay HR people between $10 /hr and $35 /hr
                if (value >= 10 && value <= 35)
                {
                    _salary = value;
                }
                else
                {
                    // If the value is not in the required range, throw
                    // an exception that the external code can catch
                    throw new ArgumentOutOfRangeException("Cannot set salary to value specified");
                }
            } 
        }
    
        public string ShiftHours 
        { 
            get => _shiftHours;
            set => _shiftHours = value; 
        }
        public int BreakFrequency 
        { 
            get => _breakFrequency; 
            set => _breakFrequency = value;
        }

        public HRDayShiftEmployee(string firstName, string lastName, string shiftHours, int breakFrequency) : base(firstName, lastName)
        {
            _shiftHours = shiftHours;
            _breakFrequency = breakFrequency;
        }

        // override the default ToString method differently than on the base Employee class to include the additional properties that are on this class due to using the INightShift interface.
        public override string ToString()
        {
            return $"{Name}, Shift: {ShiftHours}, Frequency of Breaks: {BreakFrequency}";
        }
    }
}