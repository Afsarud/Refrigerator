using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {

        private double MaxWeight;
        List<int> noItems = new List<int>();
        List<double> unitWeights = new List<double>();

        public Refrigerator(double maxWeight)
        {
            this.MaxWeight = maxWeight;
        }
        
        public int NoItem { set; get; }
        public double UnitWeight { set; get; }

        public void Add(int noItem, double unitWeight)
        {

            noItems.Add(this.NoItem);
            unitWeights.Add(this.UnitWeight);
        }
        
        public double GetCurrentWeight()
        {
            double CurrentWeight = 0.0;
            for (int i = 0; i < noItems.Count(); i++)
            {
                CurrentWeight += noItems[i] * unitWeights[i];

            }
            return CurrentWeight;
        }
        
        public double GetRemainingWeight()
        {
            double RemainingWeight = this.MaxWeight - GetCurrentWeight();

            return RemainingWeight;
        }
        
    }
}
