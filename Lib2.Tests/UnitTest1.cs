using System;
using Xunit;

namespace Lib2.Tests
{
    public class UnitTestm
    {
        [Fact]
        public void Test1()
        {
            var cls = new Class1();
            Assert.Equal(5, cls.Add(1, 4));
        }
    }
}