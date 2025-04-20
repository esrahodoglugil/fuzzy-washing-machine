using System;
using System.Windows.Forms;
using FuzzyWashingMachine.Models;
using FuzzyWashingMachine.Controllers;
using FuzzyWashingMachine.Models;

namespace FuzzyWashingMachine
{
    public partial class Form1 : Form
    {
        FuzzyEngine engine;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine = new FuzzyEngine();

            // Giriþ üyelikleri
            engine.Inputs["Hassaslik"].AddSet(new FuzzySet("Saðlam", -4, -1.5, 2, 4));
            engine.Inputs["Hassaslik"].AddSet(new FuzzySet("Orta", 3, 5, 7));
            engine.Inputs["Hassaslik"].AddSet(new FuzzySet("Hassas", 5.5, 8, 12.5, 14));

            engine.Inputs["Miktar"].AddSet(new FuzzySet("Küçük", -4, -1.5, 2, 4));
            engine.Inputs["Miktar"].AddSet(new FuzzySet("Orta", 3, 5, 7));
            engine.Inputs["Miktar"].AddSet(new FuzzySet("Büyük", 5.5, 8, 12.5, 14));

            engine.Inputs["Kirlilik"].AddSet(new FuzzySet("Küçük", -4.5, -2.5, 2, 4.5));
            engine.Inputs["Kirlilik"].AddSet(new FuzzySet("Orta", 3, 5, 7));
            engine.Inputs["Kirlilik"].AddSet(new FuzzySet("Büyük", 5.5, 8, 12.5, 15));

            // Çýkýþlar - Deterjan
            engine.Outputs["Deterjan"].AddSet(new FuzzySet("Çok Az", 0, 0, 20, 85));
            engine.Outputs["Deterjan"].AddSet(new FuzzySet("Az", 20, 85, 150));
            engine.Outputs["Deterjan"].AddSet(new FuzzySet("Orta", 85, 150, 215));
            engine.Outputs["Deterjan"].AddSet(new FuzzySet("Fazla", 150, 215, 280));
            engine.Outputs["Deterjan"].AddSet(new FuzzySet("Çok Fazla", 215, 280, 300, 300));

            // Çýkýþlar - Süre
            engine.Outputs["Sure"].AddSet(new FuzzySet("Kýsa", -46.5, -25.28, 22.3, 39.9));
            engine.Outputs["Sure"].AddSet(new FuzzySet("Normal-Kýsa", 22.3, 39.9, 57.5));
            engine.Outputs["Sure"].AddSet(new FuzzySet("Orta", 39.9, 57.5, 75.1));
            engine.Outputs["Sure"].AddSet(new FuzzySet("Normal-Uzun", 57.5, 75.1, 92.7));
            engine.Outputs["Sure"].AddSet(new FuzzySet("Uzun", 75, 92.7, 111.6, 130));

            // Çýkýþlar - Dönüþ Hýzý
            engine.Outputs["DonusHizi"].AddSet(new FuzzySet("Hassas", -5.8, -2.8, 0.5, 1.5));
            engine.Outputs["DonusHizi"].AddSet(new FuzzySet("Normal-Hassas", 0.5, 2.75, 5));
            engine.Outputs["DonusHizi"].AddSet(new FuzzySet("Orta", 2.75, 5, 7.25));
            engine.Outputs["DonusHizi"].AddSet(new FuzzySet("Normal-Güçlü", 5, 7.25, 9.5));
            engine.Outputs["DonusHizi"].AddSet(new FuzzySet("Güçlü", 8.5, 9.5, 12.8, 15.2));

            // Örnek kurallar (Ýlk test için 3 adet yeterli)
            // 27 kuralýn tamamý
            engine.Rules.Add(new FuzzyRule("Hassas", "Küçük", "Küçük", "Çok Az", "Kýsa", "Hassas"));
            engine.Rules.Add(new FuzzyRule("Hassas", "Küçük", "Orta", "Az", "Kýsa", "Normal-Hassas"));
            engine.Rules.Add(new FuzzyRule("Hassas", "Küçük", "Büyük", "Orta", "Normal-Kýsa", "Orta"));
            engine.Rules.Add(new FuzzyRule("Hassas", "Orta", "Küçük", "Orta", "Kýsa", "Hassas"));
            engine.Rules.Add(new FuzzyRule("Hassas", "Orta", "Orta", "Orta", "Normal-Kýsa", "Normal-Hassas"));
            engine.Rules.Add(new FuzzyRule("Hassas", "Orta", "Büyük", "Fazla", "Orta", "Orta"));
            engine.Rules.Add(new FuzzyRule("Hassas", "Büyük", "Küçük", "Orta", "Normal-Kýsa", "Normal-Hassas"));
            engine.Rules.Add(new FuzzyRule("Hassas", "Büyük", "Orta", "Fazla", "Orta", "Normal-Hassas"));
            engine.Rules.Add(new FuzzyRule("Hassas", "Büyük", "Büyük", "Fazla", "Normal-Uzun", "Orta"));
            engine.Rules.Add(new FuzzyRule("Orta", "Küçük", "Küçük", "Az", "Normal-Kýsa", "Normal-Hassas"));
            engine.Rules.Add(new FuzzyRule("Orta", "Küçük", "Orta", "Orta", "Kýsa", "Orta"));
            engine.Rules.Add(new FuzzyRule("Orta", "Küçük", "Büyük", "Fazla", "Orta", "Normal-Güçlü"));
            engine.Rules.Add(new FuzzyRule("Orta", "Orta", "Küçük", "Orta", "Normal-Kýsa", "Normal-Hassas"));
            engine.Rules.Add(new FuzzyRule("Orta", "Orta", "Orta", "Orta", "Orta", "Orta"));
            engine.Rules.Add(new FuzzyRule("Orta", "Orta", "Büyük", "Fazla", "Uzun", "Hassas"));
            engine.Rules.Add(new FuzzyRule("Orta", "Büyük", "Küçük", "Orta", "Orta", "Hassas"));
            engine.Rules.Add(new FuzzyRule("Orta", "Büyük", "Orta", "Fazla", "Normal-Uzun", "Hassas"));
            engine.Rules.Add(new FuzzyRule("Orta", "Büyük", "Büyük", "Çok Fazla", "Uzun", "Hassas"));
            engine.Rules.Add(new FuzzyRule("Saðlam", "Küçük", "Küçük", "Az", "Orta", "Orta"));
            engine.Rules.Add(new FuzzyRule("Saðlam", "Küçük", "Orta", "Orta", "Orta", "Normal-Güçlü"));
            engine.Rules.Add(new FuzzyRule("Saðlam", "Küçük", "Büyük", "Fazla", "Normal-Uzun", "Güçlü"));
            engine.Rules.Add(new FuzzyRule("Saðlam", "Orta", "Küçük", "Orta", "Orta", "Orta"));
            engine.Rules.Add(new FuzzyRule("Saðlam", "Orta", "Orta", "Orta", "Normal-Uzun", "Normal-Güçlü"));
            engine.Rules.Add(new FuzzyRule("Saðlam", "Orta", "Büyük", "Çok Fazla", "Orta", "Güçlü"));
            engine.Rules.Add(new FuzzyRule("Saðlam", "Büyük", "Küçük", "Fazla", "Normal-Uzun", "Normal-Güçlü"));
            engine.Rules.Add(new FuzzyRule("Saðlam", "Büyük", "Orta", "Fazla", "Uzun", "Normal-Güçlü"));
            engine.Rules.Add(new FuzzyRule("Saðlam", "Büyük", "Büyük", "Çok Fazla", "Uzun", "Güçlü"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hassaslik = (double)nudHassaslik.Value;
            double miktar = (double)nudMiktar.Value;
            double kirlilik = (double)nudKirlilik.Value;

            var results = engine.Infer(hassaslik, miktar, kirlilik);

            txtDeterjan_1.Text = results["Deterjan"].ToString("F2") + " g";
            txtSure.Text = results["Sure"].ToString("F2") + " dk";
            txtDonusHizi.Text = results["DonusHizi"].ToString("F2");

            picDeterjan.Image = new Bitmap(picDeterjan.Width, picDeterjan.Height);
            using (Graphics g = Graphics.FromImage(picDeterjan.Image))
            {
                CizCikisCikis(g, engine.Outputs["Deterjan"], results["Deterjan"]);
            }

        }

        private void CizCikisCikis(Graphics g, FuzzyVariable output, double sonuc)
        {
            int w = 400; int h = 130;
            Pen eksen = new Pen(Color.Black, 2);
            g.DrawLine(eksen, 30, h - 20, w - 10, h - 20); // X ekseni
            g.DrawLine(eksen, 30, h - 20, 30, 30);         // Y ekseni

            foreach (var set in output.Sets)
            {
                Point[] noktalar = set.GetPoints(w - 40, h - 30);
                g.DrawLines(Pens.Gray, noktalar);
                g.DrawString(set.Name, new Font("Segoe UI", 8), Brushes.DarkRed, noktalar[noktalar.Length / 2]);
            }

            // Mamdani birleþik alanýný çiz
            double[] x = Enumerable.Range(0, w - 40).Select(i => i * 300.0 / (w - 40)).ToArray();
            Point[] alan = x.Select(val =>
            {
                double y = output.GetClippedValue(val); // max-min birleþik üyelik derecesi
                int px = (int)(val / 300 * (w - 40)) + 30;
                int py = h - 20 - (int)(y * (h - 30));
                return new Point(px, py);
            }).ToArray();

            g.DrawLines(Pens.Blue, alan);

            // Centroid iþaretle
            int centroidX = (int)(sonuc / 300 * (w - 40)) + 30;
            g.FillEllipse(Brushes.Red, centroidX - 3, h - 23, 6, 6);
            g.DrawString("Centroid", new Font("Segoe UI", 8), Brushes.Red, centroidX + 5, h - 35);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Kullanýlmýyor, silinebilir veya boþ kalabilir.
        }
    }
}
