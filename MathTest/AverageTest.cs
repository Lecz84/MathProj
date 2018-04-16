using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;
using Xunit;

namespace MathTest
{
    public class AverageTest
    {
        IStatisticsData statisticsData;

        public AverageTest()
        {
            statisticsData = Substitute.For<IStatisticsData>();
            statisticsData.Result.Returns(2.5);
        }

        [Fact]
        public void TestResult()
        {
            Assert.Equal(2.5, statisticsData.Result);
        }
    }
}

