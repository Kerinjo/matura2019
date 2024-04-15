namespace Dzialki
{
    internal class Plot
    {
        private List<string> plot = new List<string>();

        public Plot(List<string> plot)
        {
            this.plot = new List<string>(plot);
        }

        public void Display()
        {
            foreach (string line in plot)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine();
        }

        public bool isCoveredInGrass()
        {
            int grassCount = 0;
            foreach (string str in plot)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '*')
                    {
                        grassCount += 1;
                    }
                }
            }

            double entireField = 30 * 30f;

            if (grassCount / entireField > 0.7)
                return true;
            else
                return false;
        }

        public bool isMirrored()
        {
            // TODO
            return true;
        }

        public int biggestRectangleSize()
        {
            // TODO
            return 0;
        }
    }
}
