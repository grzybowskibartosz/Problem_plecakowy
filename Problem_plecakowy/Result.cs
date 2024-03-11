using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProject1")]
[assembly: InternalsVisibleTo("WinFormsApp1"), InternalsVisibleTo ("GUI")]
namespace Problem_plecakowy
{
    public class Result
    {
        public int total_weight { get; }
        public int total_value { get; }
        public List<Item> Items_packed { get; }
        
        public Result(int total_weight, int total_value, List<Item> Items_packed)
        {
            this.total_weight = total_weight;
            this.total_value = total_value;
            this.Items_packed = Items_packed;
        }

        public override string ToString()
        {
            string packed_items = "Items in the backpack: \n";
            foreach (var item in Items_packed) 
            {
                packed_items += $"Weight: {item.weight} | Value: {item.value}\n";
            }
            return $"Total weight: {total_weight} | Total value: {total_value}\n{packed_items}";
        }
    }
}
