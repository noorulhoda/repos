using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDay.test
{
    [TestFixture]
    class SimpleParserTest
    {
        [Test]
        public void ParseAndSumTest1()
        {
            SimpleParser s = new SimpleParser();
            int res = s.ParseAndSum("");
            Assert.AreEqual(res, 0);

        }
        [Test]
        public void ParseAndSumTest2()
        {
            SimpleParser s = new SimpleParser();
            int res = s.ParseAndSum("25");
            Assert.AreEqual(res, 25);

        }
        [Test]
        public void ParseAndSumTest3()
        {
            SimpleParser s = new SimpleParser();

            Assert.Throws<InvalidOperationException>(() => { var res = s.ParseAndSum("2,5"); });

        }
        //////////////////////////////////////////
        ///delete char from string
        [Test]
        public void NoRepeatTest1()
        {
            SimpleParser s = new SimpleParser();
            string str = s.NoRepeat("noor", 'o');
            // Assert.That(str, Is.EqualTo("nr"));
            Assert.That(str, Does.Not.Contain('o'));
        }
        [Test]
        public void NoRepeatTest2()
        {
            SimpleParser s = new SimpleParser();
            string str = s.NoRepeat("noor", 'h');
            Assert.That(str, Is.EqualTo("noor"));
        }
        /////////////////////////////////////////
        [Test]
        public void IsPrimeTest1()
        {
            SimpleParser s = new SimpleParser();
            Assert.That(s.IsPrime("5"), Is.EqualTo(true));
        }
        [Test]
        public void IsPrimeTest2()
        {
            SimpleParser s = new SimpleParser();
            Assert.That(s.IsPrime("6"), Is.EqualTo(false));
        }
        [Test]
        public void IsPrimeTest3()
        {
            SimpleParser s = new SimpleParser();
            Assert.Throws<InvalidOperationException>(() => s.IsPrime("10000000"));
        }
        [Test]
        public void IsPrimeTest4()
        {
            SimpleParser s = new SimpleParser();
            Assert.Throws<InvalidOperationException>(() => s.IsPrime("-1"));
        }
        [Test]
        public void IsPrimeTest5()
        {
            SimpleParser s = new SimpleParser();
            Assert.Throws<InvalidOperationException>(() => s.IsPrime("10000"));
        }
        [Test]
        public void IsPrimeTest6()
        {
            SimpleParser s = new SimpleParser();
            Assert.Throws<InvalidOperationException>(() => s.IsPrime("1"));
        }
    }
}
