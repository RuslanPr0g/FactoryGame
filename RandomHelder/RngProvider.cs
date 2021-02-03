using System;
using System.Collections.Generic;
using System.Text;

namespace RandomHelper
{
    public static class RngProvider
    {
        public static Random Random { get; }

        static RngProvider()
        {
            Random = new Random();
        }
    }
}
