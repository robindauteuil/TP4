using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP03;
using Xunit;

namespace TestProject_D1_Dauteuil
{
    
    public class TestRational
    {
        [Fact]
        public void TestToString()
        {
            Assert.Equal("3/5",new Rational(3, 5).ToString());
            Assert.Equal("3/5", new Rational(30, 50).ToString());
            Assert.Equal("5/1", new Rational(5).ToString());
        }

        [Fact]
        public void TestAdd()
        {
            var a = new Rational(1, 2);
            var b = new Rational(2, 2);
            var c = new Rational(5, 3);
            a.Add(b);
            b.Add(c);
            Assert.Equal("3/2", a.ToString());
            Assert.Equal("8/3", b.ToString());
        }


        [Fact]
        public void TestToDouble()
        {
            Assert.Equal(0.66, new Rational(2, 3).ToDouble(), 1);
            Assert.Equal(0.5, new Rational(1,2).ToDouble(), 1);
        }

        [Fact]
        public void testMulitiplies()
        {
            var a = new Rational(8, 3);
            var b = new Rational(2, 2);
            var c = new Rational(5, 3);
            b.Multiplies(c);
            a.Multiplies(c);
            Assert.Equal("5/3",b.ToString());
            Assert.Equal("40/9",a.ToString());
        }

        [Fact]
        public void TestIsLess()
        {

            var b = new Rational(2, 2);
            var c = new Rational(5, 3);
            Assert.True( b.IsLessThan(c));
            Assert.False(c.IsLessThan(b));

        }

        [Fact]
        public void TestGetHashCode()
        {

            var a = new Rational(1, 2);
            var b = new Rational(1, 2);
            var c = new Rational(5, 3);
            var d = new Rational(4, 3);

            Assert.NotEqual(a.GetHashCode(), c.GetHashCode());
            Assert.Equal(a.GetHashCode(), b.GetHashCode());
            Assert.NotEqual(c.GetHashCode(), d.GetHashCode());

        }

        [Fact]
        public void testEquals()
        {
            var a = new Rational(5, 3);
            var b = new Rational(1, 2);
            var c = new Rational(1, 2);
            Assert.Equal(b,b);
            Assert.True(b.Equals(c));
            Assert.False(a.Equals(c));
            Assert.False(b.Equals(0.5));

        } 
    }


}
