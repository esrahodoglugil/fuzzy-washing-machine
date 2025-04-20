using System.Collections.Generic;

namespace FuzzyWashingMachine.Models
{
    public class FuzzyVariable
    {
        public string Name { get; set; }
        private List<FuzzySet> _sets = new List<FuzzySet>();
        public List<FuzzySet> Sets => _sets;

        public FuzzyVariable(string name)
        {
            Name = name;
        }

        public void AddSet(FuzzySet set)
        {
            _sets.Add(set);
        }

        public Dictionary<string, double> GetMemberships(double x)
        {
            var result = new Dictionary<string, double>();
            foreach (var set in _sets)
            {
                double mu = set.GetMembership(x);
                if (mu > 0)
                    result[set.Name] = mu;
            }
            return result;
        }

        // 🔵 Grafik için Mamdani max-min birleşik alanı
        public double GetClippedValue(double x)
        {
            double max = 0;
            foreach (var set in _sets)
            {
                double uyelik = set.GetMembership(x);
                if (uyelik > max)
                    max = uyelik;
            }
            return max;
        }
    }
}
