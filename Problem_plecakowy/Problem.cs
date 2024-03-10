using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_plecakowy
{
    public class Problem
    {
        public int seed { get; }
        public int n { get; }
        public List<Item> Items { get; }

        private Random rand;

        public Problem(int n, int seed)
        {
            this.n = n;
            this.seed = seed;
            rand = new Random(seed);
            Items = ItemGenerator();
        }

        private List<Item> ItemGenerator() 
        {
            List<Item> Items = new List<Item>();
            for (int i = 0; i < n; i++) 
            {
                int weight = rand.Next(1, 10);
                int value = rand.Next(1, 10);
                Items.Add(new Item(weight, value));
            }
            return Items; 
        }

        public override string ToString()
        {
            string ItemsString = "Avaliable items: \n";
            foreach (var item in Items)
            {
                ItemsString += $"Weight: {item.weight} | Value: {item.value} \n";
            }
            return ItemsString;
        }

        public Result Solve(int Capacity)
        {
            Items.Sort((x, y) => y.value_index.CompareTo(x.value_index));

            int totalWeight = 0;
            int totalValue = 0;
            List<Item> Items_packed = new List<Item>();

            foreach (var Item in Items) 
            {
                if (totalWeight + Item.weight <= Capacity)
                {
                    Items_packed.Add(Item);
                    totalWeight += Item.weight;
                    totalValue += Item.value;
                } 
            }
            return new Result(totalWeight, totalValue, Items_packed);
        }
    }
}
