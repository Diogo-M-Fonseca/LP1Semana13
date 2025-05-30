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

        public void GetMinMax2()
        {
            new MinMaxStruct(this.Min(), this.Max());
        }

        public void GetMinMax3()
        {
            Tuple.Create(this.Min(), this.Max());
        }
    }
}