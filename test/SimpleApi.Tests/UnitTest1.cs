using SimpleApi.Controllers;
using Xunit;
namespace SimpleApi.Tests;
public class UnitTest1
{
 WeatherForecastController wc = new WeatherForecastController();
    [Fact]
    public void GetNameReturns()
    {
       
        var returnedVal = wc.Get(1);
        Assert.Equal("Mumin Farooq", returnedVal.Value);
    }
}