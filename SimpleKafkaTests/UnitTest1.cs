using Microsoft.Extensions.Configuration;
using SimpleKafka.Configuration;
using Xunit;
using FluentAssertions;

namespace SimpleKafkaTests
{
    public class UnitTest1
    {

        public UnitTest1()
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
        }
  

        [Fact]
        public void Test1()
        {
            int i = 0;
            i.Should().Be(1);
            //ConfigurationRegistration.RegisterConfiguration()
        }
    }
}