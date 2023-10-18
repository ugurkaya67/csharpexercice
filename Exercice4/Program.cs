using System;
using System.Collections.Generic;

namespace Exercice4 {
    class Program {

        static Tuple<int[], int[]> PairImpair(int[] tab) {
            List<int> pair = new List<int>();
            List<int> impair = new List<int>();

            for(int i = 0; i < tab.Length; i++) {
                if (tab[i] % 2 == 0) {
                    pair.Add(tab[i]);
                } else {
                    impair.Add(tab[i]);
                }
            }

            return Tuple.Create(pair.ToArray(), impair.ToArray());
        }

        static void Display(int[] tab) {
            foreach (int val in tab) {
                Console.Write(val + " ");
            }
        }

        static void Main(string[] args) {
            int[] tab = new int[20];
            for (int i = 0; i < 20; i++) {
                Random rand = new Random();
                int number = rand.Next(0, 100);
                tab[i] = number;
            }

            Console.WriteLine("Valeurs à séparer : ");
            Display(tab);
            Tuple<int[], int[]> tabs = PairImpair(tab);
            Console.WriteLine("\nPair : ");
            Display(tabs.Item1);
            Console.WriteLine("\nImpair : ");
            Display(tabs.Item2);
        }
    }
}
