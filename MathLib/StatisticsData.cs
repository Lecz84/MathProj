using System;
using System.Collections.Generic;
using System.Linq;

namespace MathLib
{
    class AverageData : IStatisticsData
    {
        private IEnumerable<int> elements;

        public AverageData(IEnumerable<int> elements)
        {
            this.elements = elements;
        }

        public double Result
        {
            get
            {
                return elements.Average(x => x);
            }
        }
    }
}
