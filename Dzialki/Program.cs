using System.Net.NetworkInformation;
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

            int grassCoveredFields = 0;
            
            var flippedPlots = new Dictionary<int, Plot>();

            for(int i = 0; i < plotList.Count; i++)
            {
                Plot currentPlot = plotList[i];

                // 4.1
                // . - empty space
                // * - grass
                // X - terrain
                if (currentPlot.isCoveredInGrass())
                    grassCoveredFields += 1;

                // 4.2
                // see if there's already this plot in our Dictionary
                // if not, flip it
                // store it in a Dictionary
                if (flippedPlots.ContainsValue(currentPlot))
                {
                    Console.WriteLine($"Mirror image is present!");

                    foreach(var pair in flippedPlots)
                    {
                        if (pair.Value.Equals(currentPlot))
                        {
                            Console.WriteLine($"indices: {pair.Key}, {i}");
                        }
                    }
                }
                else
                {
                    // not in dict? flip it and add.
                    flippedPlots.Add(i, currentPlot.flipPlot());
                }
            }
            Console.WriteLine($"grass covered fields: {grassCoveredFields}");
        }
    }
}
