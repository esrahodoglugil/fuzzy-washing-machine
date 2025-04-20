using System.Collections.Generic;

namespace FuzzyWashingMachine.Models
{
    public class FuzzyRule
    {
        public string Hassaslik { get; set; }
        public string Miktar { get; set; }
        public string Kirlilik { get; set; }

        public string Deterjan { get; set; }
        public string Sure { get; set; }
        public string DonusHizi { get; set; }

        public FuzzyRule(string hassaslik, string miktar, string kirlilik, string deterjan, string sure, string donusHizi)
        {
            Hassaslik = hassaslik;
            Miktar = miktar;
            Kirlilik = kirlilik;
            Deterjan = deterjan;
            Sure = sure;
            DonusHizi = donusHizi;
        }

        public double GetActivation(Dictionary<string, Dictionary<string, double>> memberships)
        {
            var mu1 = memberships["Hassaslik"].ContainsKey(Hassaslik) ? memberships["Hassaslik"][Hassaslik] : 0;
            var mu2 = memberships["Miktar"].ContainsKey(Miktar) ? memberships["Miktar"][Miktar] : 0;
            var mu3 = memberships["Kirlilik"].ContainsKey(Kirlilik) ? memberships["Kirlilik"][Kirlilik] : 0;
            return System.Math.Min(mu1, System.Math.Min(mu2, mu3)); // AND işlemi (min)
        }
    }
}
