using InfiniteAbyss.Core.Enums;
using InfiniteAbyss.Core.Models;
using System.Collections.Generic;

namespace InfiniteAbyss.Core.Resources
{
    public static class Data
    {
        /// <summary>
        /// Read Data
        /// </summary>
        public static Dictionary<RaceEnum, AbilitiesModifiersInfo> RaceData { get; set; } = new Dictionary<RaceEnum, AbilitiesModifiersInfo>
            {
                { RaceEnum.Human, new AbilitiesModifiersInfo("身为人类", 1, 1, 1, 1, 1, 1) },
                { RaceEnum.Elf, new AbilitiesModifiersInfo("身为精灵", -2, 2, 1, 0, 2, 3) },
                { RaceEnum.Reptile, new AbilitiesModifiersInfo("身为蜥蜴人", 3, 2, 2, 0, 1, -2) }
            };

        public static Dictionary<TraitEnum, AbilitiesModifiersInfo> TraitData{ get; set; } = new Dictionary<TraitEnum, AbilitiesModifiersInfo>
            {
                { TraitEnum.Charming, new AbilitiesModifiersInfo("极具魅力", 0, 0, 0, 0, 0, 3) }
            };
    }

    public class AbilitiesModifiersInfo
    {
        public AbilitiesModifiersInfo(string name, int str, int con, int dex, int _int, int wis, int cha)
        {
            Name = name;
            AbilitiesModifiers = new Dictionary<AbalityEnum, Modifier>
            {
                {AbalityEnum.STR,new Modifier(name,str,ModifierType.FLAT) },
                {AbalityEnum.CON,new Modifier(name,con,ModifierType.FLAT) },
                {AbalityEnum.DEX,new Modifier(name,dex,ModifierType.FLAT) },
                {AbalityEnum.INT,new Modifier(name,_int,ModifierType.FLAT) },
                {AbalityEnum.WIS,new Modifier(name,wis,ModifierType.FLAT) },
                {AbalityEnum.CHA,new Modifier(name,cha,ModifierType.FLAT) }
            };
        }
        public string Name { get; set; }
        public Dictionary<AbalityEnum, Modifier> AbilitiesModifiers { get; set; }
    }
}
