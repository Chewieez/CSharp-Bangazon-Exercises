using System;

namespace bangazon
{
    public class MarketingSeasonalEmployee : Employee, IDeptLocation, ISeasonalEmployee
    {
        private double _salary;
        private int _contractDuration;

        public string Location 
        { 
            get {return Location;}
            set {}
        }

        public double Salary 
        { 
            get { return _salary; }
            set {
                // We pay seasonal Marketing people between $20 /hr and $30 /hr
                if (value >= 20 && value <= 30)
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

        public int ContractDuration 
        { 
            get { return _contractDuration;} 
            set {
                // seasonal employees need to hire for longer than 1 month and no longer than 6 months
                if (value > 1 && value <= 6) {
                    _contractDuration = value;
                }
                else
                {
                    // If the value is not in the required range, throw
                    // an exception that the external code can catch
                    throw new ArgumentOutOfRangeException("Cannot set contract duration to value specified");
                }
            } 
        }

    
        public void ExtendContract(int duration)
        {
            ContractDuration += duration;
        }

        public MarketingSeasonalEmployee(string firstName, string lastName) : base(firstName, lastName)
        {
        }
    }
}