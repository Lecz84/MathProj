using NSubstitute;
using MathLib;
using Xunit;

namespace MathTest
{
    public class StatisticsTest
    {
        IStatisticsData statisticsData;
        Statistics statistics;

        public StatisticsTest()
        {
            statisticsData = Substitute.For<IStatisticsData>();
            statisticsData.Result.Returns(2.5);
            statistics = new Statistics(statisticsData);
        }

        [Fact]
        public void TestResult()
        {
            Assert.Equal(2.5, statisticsData.Result);
        }
    }
}

