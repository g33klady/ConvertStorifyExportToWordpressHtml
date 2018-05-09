using StorifyPageConverter;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [ClassData(typeof(ObjectsForTesting))]
        public void GetStringForElement_ReturnsCorrectString(Element element, string expected)
        {
            var actual = ConvertStorifyJsonToHtml.GetStringForElement(element);
            Assert.Equal(expected, actual);

        }
    }
}
