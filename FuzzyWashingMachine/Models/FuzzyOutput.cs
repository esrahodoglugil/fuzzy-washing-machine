using System.Collections.Generic;

namespace FuzzyWashingMachine.Models
{
    public class FuzzyOutput
    {
        public string Name { get; set; }
        public List<FuzzySet> Sets { get; set; } = new List<FuzzySet>();

        public void AddSet(FuzzySet set)
        {
            Sets.Add(set);
        }

        public double GetClippedValue(double x)
        {
            double max = 0;
            foreach (var set in Sets)
            {
                double uyelik = set.GetMembership(x);
                if (uyelik > max)
                    max = uyelik;
            }
            return max;
        }
    }
}
