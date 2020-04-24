using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NCTest
{
    [TestFixture(TypeArgs = new[] { typeof(string) })]
    internal class NUnitTest<TOne>
    {
        [Test]
        public void SomeTest()
        {
        }
    }
}
