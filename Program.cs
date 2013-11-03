using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardProbability
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3 million hands from 5 to 42 takes about 15 minutes on my laptop
            int iterationCount = 3000000;
            string outputFile = "c:\\temp\\probabilityOutput.txt";

            Console.WriteLine("Running " + iterationCount + " iterations per number...");

            // Could go to 56, but it stops being interesting after ~40
            for (int x = 5; x < 42; x++)
            {
                //Console.WriteLine("Starting with hands of " + x.ToString());

                int success = 0;
                int failure = 0;
                for (int i = 0; i < iterationCount; i++)
                {
                    Hand h = Deck.Instance.GetHand(x);
                    if (h.HasAll)
                    {
                        success++;
                    }
                    else
                    {
                        failure++;
                    }
                }

                float percentage = (100 * (float)success / ((float)failure + (float)success));

                string s = "For hands of " + x.ToString() + ", percentage is " + percentage.ToString();
                Console.WriteLine(s);
                File.AppendAllText(outputFile, s + Environment.NewLine);

                //Console.WriteLine("Success count: " + success.ToString());
                //Console.WriteLine("Failure count: " + failure.ToString());
                //Console.WriteLine("Percentage: " + (100 * (float)success / ((float)failure + (float)success)).ToString());
            }

            Console.WriteLine("... Done!");
            Console.Read();
        }
    }
}
