using System;

namespace Exercice2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Insérez la valeur souhaitée : ");
            string input = Console.ReadLine();

            // Vérification de la saisie
            if (!double.TryParse(input, out double value)) {
                Console.WriteLine("Erreur : la saisie n'est pas un nombre.");
            }
            else if(value == 0){
                Console.WriteLine("La racine carrée de 0 est 0.");

            }
            else if(value == 1){
                Console.WriteLine("La racine carrée de 1 est 1.");

            }
            else if(value <0){
                Console.WriteLine($"la saisie {value} est inférieur à 0.");

            } else {
                Console.WriteLine($"La saisie est valide. Valeur : {value}");
                
                // Mesure du temps de calcul
                DateTime startTime = DateTime.Now;
                int iterations = Approx(value, value);
                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Nombre d'itérations : {iterations}");
                Console.WriteLine($"Temps total : {(endTime - startTime).TotalSeconds} secondes");
            }
        }

        // Méthode d'approximation
        public static int Approx(double A, double X) {
            double Xj = (X + A / X) / 2;
            Console.WriteLine($"Approximation actuelle : {Math.Round(Xj, 3)}");

            // Vérification de la convergence
            if (Math.Abs(Xj - Math.Sqrt(A)) < A * 1e-9) {
                Console.WriteLine($"Erreur résiduelle : {Math.Round(Xj - Math.Sqrt(A), 9)}");
                return 1;
            }

            return Approx(A, Xj) + 1;
        }
    }
}