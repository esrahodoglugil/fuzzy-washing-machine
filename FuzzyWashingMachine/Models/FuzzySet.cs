namespace FuzzyWashingMachine.Models
{

    public class FuzzySet
    {
        public string Name { get; set; }
        public double A, B, C, D;
        public bool IsTriangular;

        public List<double> Points
        {
            get
            {
                if (IsTriangular)
                    return new List<double> { A, B, C };
                else
                    return new List<double> { A, B, C, D };
            }
        }

        public FuzzySet(string name, double a, double b, double c)
        {
            Name = name;
            A = a;
            B = b;
            C = c;
            IsTriangular = true;
        }

        public FuzzySet(string name, double a, double b, double c, double d)
        {
            Name = name;
            A = a;
            B = b;
            C = c;
            D = d;
            IsTriangular = false;
        }

        public double GetMembership(double x)
        {
            if (IsTriangular)
            {
                if (x <= A || x >= C) return 0;
                if (x == B) return 1;
                if (x < B) return (x - A) / (B - A);
                return (C - x) / (C - B);
            }
            else
            {
                if (x <= A || x >= D) return 0;
                if (x >= B && x <= C) return 1;
                if (x > A && x < B) return (x - A) / (B - A);
                return (D - x) / (D - C);
            }
        }
        public Point[] GetPoints(int width, int height)
        {
            List<Point> pts = new List<Point>();
            double step = 0.1;

            for (double x = Points.First(); x <= Points.Last(); x += step)
            {
                double uyelik = this.GetMembership(x);
                int px = (int)(x / 300.0 * width) + 30; // 0–300 için çizim alanı
                int py = height - (int)(uyelik * height);
                pts.Add(new Point(px, py));
            }

            return pts.ToArray();
        }

    }
}
