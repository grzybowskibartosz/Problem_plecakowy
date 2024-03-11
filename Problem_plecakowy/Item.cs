using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("WinFormsApp1"), InternalsVisibleTo("GUI")]
namespace Problem_plecakowy
{
    public class Item
    {
        public int weight { get; set; }
        public int value { get; set; }
        public double value_index { get; }

        public Item(int weight, int value)
        {
            this.weight = weight;
            this.value = value;
            value_index = (double) value / weight;
        }
    }
}
