using InfiniteAbyss.Core.Enums;
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
        }
        [Test]
        public void SwitchRace()
        {
            c.Race = Core.Enums.RaceEnum.Elf;
            c.Race = Core.Enums.RaceEnum.Human;
            c.PrintInfo();
            Assert.IsTrue(c.Abalities[AbalityEnum.CON].FinalValue == 11);
        }
    }
}