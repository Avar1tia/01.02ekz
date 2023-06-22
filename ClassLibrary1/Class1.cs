using System;
using System.Linq;

namespace Arifmetica
{
    public class Calculator
    {
        public static double MinAVG(string[] marks)
        {
            double sum = 0;
            foreach (string mark in marks)
            {
                if (double.TryParse(mark, out double value))
                {
                    sum += value;
                }
            }

            double avg = sum / marks.Length;
            double roundedAvg = Math.Floor(avg * 10) / 10;

            return roundedAvg;
        }
    }
}
