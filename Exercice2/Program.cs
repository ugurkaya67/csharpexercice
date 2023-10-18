using System;

namespace Exercice2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insérez la valeur souhaitée : ");
            string A = Console.ReadLine();
            DateTime startTime = DateTime.Now;
            Console.WriteLine("Nombre d'itérations : " + Approx(Double.Parse(A), Double.Parse(A)));
            DateTime endTime = DateTime.Now;
            Console.WriteLine((endTime - startTime).TotalSeconds + " secondes");
        }

        public static int Approx(double A, double X) {
            double Xj = (X + A / X) / 2;
            Console.WriteLine(Math.Round(Xj, 3));
            if (Xj - Math.Sqrt(A) < A * 10e-9) {
                Console.WriteLine("Erreur résiduelle (Xj - A) : " + (Xj - Math.Sqrt(A)));
                return 1;
            }
            return Approx(A, Xj) + 1;
        }
    }
}
