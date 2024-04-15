namespace Dzialki
{
    internal class Plot : IEquatable<Plot>
    {
        private List<string> plot = new List<string>();
        private int width = 30;
        private int height = 30;

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

        public Plot flipPlot()
        // Method to flip plot by 180deg
        {
            var lines = new List<string>();
            for (int i = height - 1; i >= 0; i--)
            {
                string line = "";
                for (int j = width - 1; j >= 0; j--)
                {
                    line += plot[i][j];
                }
                lines.Add(line);
            }
            return new Plot(lines);
        }

        public int biggestRectangleSize()
        {
            throw new NotImplementedException();
        }

        public bool Equals(Plot? other)
        {

            if (other == null)
                return false;
            else
            {
                bool equal = true;
                for (int i = 0; i < height; i++)
                {
                    if (plot[i] != other.plot[i])
                    {
                        equal = false;
                    }
                }

                return equal;
            }
        }
    }
}
