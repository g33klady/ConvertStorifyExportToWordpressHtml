using StorifyPageConverter;
using System;
using Xunit;

namespace UnitTests
{
    public class PageConverterUnitTests
    {
        [Theory]
        [ClassData(typeof(ObjectsForTesting))]
        public void GetStringForElement_ReturnsCorrectString(Element element, string expected)
        {
            var actual = ConvertStorifyJsonToHtml.GetStringForElement(element);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetStringForElement_GivenInvalidData_ThrowsException()
        {
            var element = new Element("testing", "this is a test");
            Assert.Throws<NotImplementedException>(() => ConvertStorifyJsonToHtml.GetStringForElement(element));
        }
    }
}
