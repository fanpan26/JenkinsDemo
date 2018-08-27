using System;
using Xunit;

namespace JenkinsDemoTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 10;
            int b = 10;
            Assert.True(a == b);
        }
    }
}
