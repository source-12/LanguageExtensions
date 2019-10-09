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
    }
}