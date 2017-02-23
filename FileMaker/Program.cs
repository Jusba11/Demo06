using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"D:\test.txt");
            outputFile.WriteLine("Here is a sample text to file.");
            outputFile.Close();

            /*
            

            Tähän do-while jolla kysytään asioita käyttäjältä ja silloin kun syote = "" niin lopetetaan.
             

            
            using (StreamWriter w = File.AppendText(@"D:\test.txt"))
            {
                w.WriteLine("helloasd");
            }


            
             */


            //luetaan tiedostosta kaikki rivit.

            string[] lines = System.IO.File.ReadAllLines(@"D:\test.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
    }
}
