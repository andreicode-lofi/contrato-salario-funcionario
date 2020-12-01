using System;
using System.Collections.Generic;
using System.Text;
using Corse.Entities.Enums;

namespace Corse.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValeuPerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valeuPerHour, int hours)
        {
            Date = date;
            ValeuPerHour = valeuPerHour;
            Hours = hours;
        }

        public double TotalValeu()
        {
            return ValeuPerHour * Hours;
        }
    }
}
