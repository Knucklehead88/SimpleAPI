using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(11);
            Assert.Equal("les Jackson", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
