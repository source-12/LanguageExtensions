using Xunit;
using Fathom.ObjectExtensions;
using FluentAssertions;

namespace Fathom.Tests.Objects
{
    public class IsNotNullTests
    {
        [Fact]
        public void NullObject_IsNotNull_False()
        {
            object sut = null;

            var result = sut.IsNotNull();
            result.Should().BeFalse();
        }
        
        [Fact]
        public void NotNullObject_IsNotNull_True()
        {
            object sut = "foo";

            var result = sut.IsNotNull();
            result.Should().BeTrue();
        }
    }
}