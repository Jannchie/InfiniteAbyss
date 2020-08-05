using InfiniteAbyss.Core.Enums;
using InfiniteAbyss.Core.Managers;
using InfiniteAbyss.Core.Models;
using InfiniteAbyss.Core.Resources;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace InfiniteAbyss.Test
{
    public class WorldTest
    {
        private World world;
        [SetUp]
        public void Setup()
        {
            world = new World();
        }

        [Test]
        public void PrintDate()
        {
            int days = 400;
            while (days-- != 0)
            {
                world.NextDay();
            }
        }
    }
}