using InfiniteAbyss.Core.Managers;
using InfiniteAbyss.Core.Models;
using InfiniteAbyss.Core.Resources;
using NUnit.Framework;
using System;
namespace InfiniteAbyss.Test
{
    public class CharacterTest
    {
        Character c;
        CharacterManager cm;
        [SetUp]
        public void Setup()
        {
            c = new Character();
            cm = new CharacterManager();
        }

        [Test]
        public void Print()
        {
            c.PrintInfo();
            Assert.Pass();
        }
        [Test]
        public void SwitchRace()
        {
            c.Race = Core.Enums.RaceEnum.ELF;
            c.PrintInfo();
            Assert.Pass();
        }
    }
}