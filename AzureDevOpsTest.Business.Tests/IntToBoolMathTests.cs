using FluentAssertions;
using System;
using Xunit;

namespace AzureDevOpsTest.Business.Tests
{
    public class IntToBoolMathTests
    {
        [Fact]
        public void Add_GivenTwoZeroes_ShouldReturnFalse()
        {
            var sut = new IntToBoolMath();
            var actual = sut.Add(0, 0);
            actual.Should().BeFalse();
        }

        [Fact]
        public void Add_GivenTwoOnes_ShouldReturnTrue()
        {
            var sut = new IntToBoolMath();
            var actual = sut.Add(1, 1);
            actual.Should().BeTrue();
        }
    }
}
