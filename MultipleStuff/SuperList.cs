using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public struct MinMaxStruct
        {
            public double Min { get; set; }
            public double Max { get; set; }

            public MinMaxStruct(double min, double max)
            {
                Min = min;
                Max = max;
            }

            public override string ToString()
            {
                return $"Min: {Min}, Max: {Max}";
            }
        }
        public void GetMinMax1(out double min, out double max)
        {
            min = this.Min();
            max = this.Max();
        }

        public MinMaxStruct GetMinMax2()
        {
            return new MinMaxStruct(this.Min(), this.Max());
        }

        public Tuple<double, double> GetMinMax3()
        {
            return Tuple.Create(this.Min(), this.Max());
        }

        public (double Min, double Max) GetMinMax4()
        {
            return (this.Min(), this.Max());
        }
    }
}