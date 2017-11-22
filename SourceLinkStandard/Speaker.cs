using System;

namespace SourceLinkStandard
{
    public class Speaker
    {
        private readonly Random _random = new Random();

        public string MakeNoise()
        {
            if (_random.Next(0, 10) > 8)
                return "Random";

            return "Hello World";
        }
    }
}
