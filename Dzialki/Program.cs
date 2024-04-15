using System.Runtime.InteropServices;

namespace Dzialki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("dzialki.txt");


            List<string> inputList = new List<string>();
            List<Plot> plotList = new List<Plot>();

            foreach (string line in lines)
            {
                if (line != "")
                {
                    inputList.Add(line);
                }
                else
                {
                    plotList.Add(new Plot(inputList));
                    inputList.Clear();
                }
            }

            // 4.1
            // . - empty space
            // * - grass
            // X - terrain
            int grassCoveredFields = 0;
            foreach (Plot entry in plotList)
            {
                if (entry.isCoveredInGrass())
                    grassCoveredFields += 1;
            }
            Console.WriteLine(grassCoveredFields);
        }
    }
}
