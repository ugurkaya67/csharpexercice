using System;

namespace Exercice5 {
    class Program {
        static void Main(string[] args) {
            string s1 = "Hello World";
            string s2 = "Hello World";
            string s3 = s1;

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
            
            Console.WriteLine("Modification");
            s3 += '!';

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

            // C# fait automatiquement une copie profonde lors de l'opération : string s3 = s1
            // Ainsi, lorsque l'on modifie s3, s1 n'est pas modifiée
        }
    }
}
