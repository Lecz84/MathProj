using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    // Clever class
    public class Statistics
    {
        public IStatisticsData statisticsData { get; }

        public Statistics(IStatisticsData statisticsData)
        {
            this.statisticsData = statisticsData;
        }

        public double Result { get { return statisticsData.Result; } }
    }
}
