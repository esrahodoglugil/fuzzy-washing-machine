using System;
using System.Collections.Generic;
using FuzzyWashingMachine.Models;

namespace FuzzyWashingMachine.Controllers
{
    public class FuzzyEngine
    {
        public List<FuzzyRule> Rules { get; set; } = new();
        public Dictionary<string, FuzzyVariable> Inputs { get; set; } = new();
        public Dictionary<string, FuzzyVariable> Outputs { get; set; } = new();

        public FuzzyEngine()
        {
            Inputs["Hassaslik"] = new FuzzyVariable("Hassaslik");
            Inputs["Miktar"] = new FuzzyVariable("Miktar");
            Inputs["Kirlilik"] = new FuzzyVariable("Kirlilik");

            Outputs["Deterjan"] = new FuzzyVariable("Deterjan");
            Outputs["Sure"] = new FuzzyVariable("Sure");
            Outputs["DonusHizi"] = new FuzzyVariable("DonusHizi");
        }

        public Dictionary<string, double> Infer(double hassaslik, double miktar, double kirlilik)
        {
            var result = new Dictionary<string, List<(string, double)>>();

            var memberships = new Dictionary<string, Dictionary<string, double>>
            {
                ["Hassaslik"] = Inputs["Hassaslik"].GetMemberships(hassaslik),
                ["Miktar"] = Inputs["Miktar"].GetMemberships(miktar),
                ["Kirlilik"] = Inputs["Kirlilik"].GetMemberships(kirlilik)
            };

            foreach (var rule in Rules)
            {
                double activation = rule.GetActivation(memberships);

                if (!result.ContainsKey("Deterjan")) result["Deterjan"] = new();
                result["Deterjan"].Add((rule.Deterjan, activation));

                if (!result.ContainsKey("Sure")) result["Sure"] = new();
                result["Sure"].Add((rule.Sure, activation));

                if (!result.ContainsKey("DonusHizi")) result["DonusHizi"] = new();
                result["DonusHizi"].Add((rule.DonusHizi, activation));
            }

            var outputValues = new Dictionary<string, double>();
            foreach (var output in result)
            {
                double weightedSum = 0;
                double totalWeight = 0;

                foreach (var (setName, activation) in output.Value)
                {
                    var fuzzySet = Outputs[output.Key].Sets.Find(s => s.Name == setName);
                    double center = (fuzzySet.IsTriangular)
                        ? fuzzySet.B
                        : (fuzzySet.B + fuzzySet.C) / 2;

                    weightedSum += activation * center;
                    totalWeight += activation;
                }

                outputValues[output.Key] = totalWeight == 0 ? 0 : weightedSum / totalWeight;
            }

            return outputValues;
        }
    }
}
