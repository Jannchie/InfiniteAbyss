using NUnit.Framework;
using System;
namespace InfiniteAbyss.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Hello()
        {
            Console.WriteLine("hello, world");
            Assert.Pass();
        }
    }
}