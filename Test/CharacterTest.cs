using InfiniteAbyss.Core.Enums;
using InfiniteAbyss.Core.Managers;
using InfiniteAbyss.Core.Models;
using InfiniteAbyss.Core.Resources;
using InfiniteAbyss.Core.Utils;
using NUnit.Framework;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InfiniteAbyss.Test
{
    public class CharacterTest
    {
        Character c;
        CharacterManager cm;
        NameData nd;
        [SetUp]
        public void Setup()
        {
            c = new Character();
            cm = new CharacterManager();
            // JsonSerializerOptions options = new JsonSerializerOptions();
            // options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            nd = JsonSerializer.Deserialize<NameData>(File.ReadAllText("C:/Users/Pan Jianqi/source/repos/InfiniteAbyss/Core/Data/Name.json"));
        }

        [Test]
        public void Print()
        {
            c.PrintInfo();
        }

        [Test]
        public void Name()
        {
            Logger.Info("First Name", nd.China.FirstName[0]);
            Logger.Info("Last Name", nd.China.LastName[0]);
        }

        [Test]
        public void SwitchRace()
        {
            c.Race = Core.Enums.RaceEnum.Elf;
            c.PrintInfo();

            c.Race = Core.Enums.RaceEnum.Human;
            c.PrintInfo();

            Assert.IsTrue(c.Abalities[AbalityEnum.CON].FinalValue == 11);
        }
    }
}