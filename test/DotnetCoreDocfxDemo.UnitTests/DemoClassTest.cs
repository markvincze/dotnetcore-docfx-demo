using System;
using Xunit;

namespace DotnetCoreDocfxDemo.UnitTests
{
    public class DemoClassTest
    {
        [Fact]
        public void DemoMethod_CalledWith3_ReturnsFoo3Times()
        {
            var sut = new DemoClass();

            // Act
            var result = sut.DemoMethod(3);

            Assert.Equal("FooFooFoo", result);
        }
    }
}