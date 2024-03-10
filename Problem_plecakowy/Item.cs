using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_plecakowy
{
    public class Item
    {
        public int weight { get; }
        public int value { get; }
        public double value_index { get; }

        public Item(int weight, int value)
        {
            this.weight = weight;
            this.value = value;
            value_index = (double) value / weight;
        }
    }
}
