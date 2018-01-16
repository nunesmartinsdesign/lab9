using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace lab9
{
    class MyMathTests
    {
        [TestCase]
        public void Add01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Add(5, 5), 10);
        }

        [TestCase]
        public void Add02()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Add(7, 7), 14);
        }

        [TestCase]
        public void Add03()
        {
            MyMath txt = new MyMath();
            Assert.IsTrue(txt.Add(7, 7) == 14);
        }

        [TestCase]
        public void Sub01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Sub(14, 7), 7);
        }

        [TestCase]
        public void Sub02()
        {
            MyMath txt = new MyMath();
            Assert.IsFalse(txt.Sub(14, 7) == 6);
        }

        [TestCase]
        public void Sub03()
        {
            MyMath txt = new MyMath();
            Assert.AreNotEqual(txt.Sub(14, 7), 6);
        }

        [TestCase]
        public void Mul01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Mul(5, 5), 25);
        }

        [TestCase]
        public void Mul02()
        {
            MyMath txt = new MyMath();
            Assert.IsNotNull(txt.Mul(5, 5) == 25);
        }

        [TestCase]
        public void IntDiv01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.IntDiv(15, 5), 3);
        }

        [TestCase]
        public void Div01()
        {
            MyMath txt = new MyMath();
            Assert.AreEqual(txt.Div(15, 5), 3);
        }
    }
}
