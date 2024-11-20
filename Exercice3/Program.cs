using System;
using System.IO;
using System.Reflection.Metadata;
using System.Text;

namespace Exercice3 {
    class Program {
        static void Main(string[] args) {
            string fileName = "Mesures.txt";         
            
            try {
                // string numberChain = "";
                // using (StreamReader reader = new StreamReader(fileName)) {
                //     int n = 0;
                //     string line;
                //     while((line = reader.ReadLine()) != null) {
                //         if (n < 9) {
                //             numberChain += line + ", ";
                //             n++;
                //         } else {
                //             numberChain += line + "\n";
                //             n = 0;
                //         }
                //     }
                // }
                StringBuilder numberChain = new StringBuilder();
                using (StreamReader reader = new StreamReader(fileName)) {
                    int n = 0;
                    string line;
                    while((line = reader.ReadLine()) != null) {
                        if (n < 9) {
                            numberChain.Append(line + ", ");
                            n++;
                        } else {
                            numberChain.AppendLine(line);
                            n = 0;
                        }
                    }
                }
                // Console.WriteLine(numberChain.ToString());
                Console.WriteLine(numberChain);
            } catch (Exception exp) {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
