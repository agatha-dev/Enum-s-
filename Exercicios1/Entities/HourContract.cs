using EllipticCurve.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios1.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public double Hours { get; set; }

        public HourContract (DateTime date, double valuePerHour, double hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Total trabalhado em horas
        public  Double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
