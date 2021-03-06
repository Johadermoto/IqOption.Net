using System;
using FluentAssertions;
using IqOptionApi.unit;
using IqOptionApi.Ws.Request;
using NUnit.Framework;

namespace IqOptionApi.Tests.ws {
    
    [TestFixture]

    public class GetExpirationTimeTest : TestFor<object> {


        [Test]
        public void Test_WhenSecondLessThan30s_ExpirationShouldBeNext2Mins() {

            var now = DateTimeOffset.FromUnixTimeSeconds(1578642890);
            
            
            // act
            var exp = ExpirationModel.GetExpirationTime(now.ToLocalTime());
            
            // assert
            var expected = now.AddSeconds(-now.Second).AddMilliseconds(-now.Millisecond).AddMinutes(2);
            exp.Should().Be(expected);

        }

    }

}