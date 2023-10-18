using System;
using System.IO;

namespace Exercice3 {
    class Program {
        static void Main(string[] args) {
            string fileName = @"C:\Users\bruno.costa\CSharp\exercices_csharp\Serie1\Exercice3\Mesures.txt";            

            try {
                string numberChain = "";
                using (StreamReader reader = new StreamReader(fileName)) {
                    int n = 0;
                    string line;
                    while((line = reader.ReadLine()) != null) {
                        if (n < 9) {
                            numberChain += line + ", ";
                            n++;
                        } else {
                            numberChain += line + "\n";
                            n = 0;
                        }
                    }
                }
                Console.WriteLine(numberChain);
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
