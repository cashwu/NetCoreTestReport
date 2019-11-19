using System;
using Xunit;

namespace Lib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var cls = new Class1();
            Assert.Equal(5, cls.Add(1, 4));
        }
    }
}