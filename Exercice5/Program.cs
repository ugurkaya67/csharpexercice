using System;
using System.Text;

namespace Exercice5 {
    class Program {
        // Méthode pour factoriser les comparaisons
        static void CompareStrings(string s1, string s2, string s3) {
            Console.WriteLine("Equals : ");
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine(s2.Equals(s3));
            
            Console.WriteLine("CompareTo : ");
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s1.CompareTo(s3));
            Console.WriteLine(s2.CompareTo(s3));
            
            Console.WriteLine("System.ReferenceEquals : ");
            Console.WriteLine(Object.ReferenceEquals(s1, s2));
            Console.WriteLine(Object.ReferenceEquals(s1, s3));
            Console.WriteLine(Object.ReferenceEquals(s2, s3));
        }

        static void Main(string[] args) {
            // Chaînes initiales
            string s1 = "Hello World";
            string s2 = "Hello World";
            string s3 = s1;

            // Comparaisons initiales
            Console.WriteLine("Comparaisons initiales :");
            CompareStrings(s1, s2, s3);

            // Modification de s3
            Console.WriteLine("\nModification de s3 avec '+= '!'");
            s3 += '!';

            // Comparaisons après modification
            Console.WriteLine("Comparaisons après modification :");
            CompareStrings(s1, s2, s3);

            // Démonstration avec StringBuilder
            Console.WriteLine("\nUtilisation de StringBuilder :");
            StringBuilder sb = new StringBuilder("Hello World");
            sb.Append('!');
            Console.WriteLine($"Chaîne modifiée avec StringBuilder : {sb.ToString()}");

            // Explication supplémentaire
            Console.WriteLine("\nExplication :");
            Console.WriteLine("Les objets string sont immuables. Lorsqu'une modification est effectuée (+=), une nouvelle instance est créée.");
            Console.WriteLine("Pour des modifications répétées ou des constructions complexes, StringBuilder est plus efficace.");
        }
    }
}
