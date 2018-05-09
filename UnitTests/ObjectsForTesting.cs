using StorifyPageConverter;
using System.Collections;
using System.Collections.Generic;

namespace UnitTests
{
    public class ObjectsForTesting : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { new Element("text", new Data("this is a test")), "<p>this is a test</p>" };
            yield return new object[] { new Element("image", "http://example.com/testimage"), "http://example.com/testimage" };
            yield return new object[] { new Element("video", "http://example.com/testvideo"), "http://example.com/testvideo" };
            yield return new object[] { new Element("link", "http://example.com/testlink"), "http://example.com/testlink" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
