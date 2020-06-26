using System;
using System.Collections.Generic;
using System.Linq;
using InfiniteAbyss.Core.Enums;
using InfiniteAbyss.Core.Interfaces;
using InfiniteAbyss.Core.Resources;

namespace InfiniteAbyss.Core.Models
{
    public class Character : ICombatable
    {

        public Character()
        {
            InitAbality();

            Race = RaceEnum.Human;

            Name = GetRandomName();
        }

        private void InitAbality()
        {
            Abalities = new Dictionary<AbalityEnum, Attribute>();
            int baseValue = 10;
            foreach (AbalityEnum abality in Enum.GetValues(typeof(AbalityEnum)))
            {
                Abalities[abality] = new Attribute(baseValue);
            }
        }

        private string GetRandomName()
        {
            return "Œﬁ√˚ œ";
        }

        public string Name { get; set; }
        public string Desc { get; set; }

        private RaceEnum race;
        public RaceEnum Race
        {
            get
            {
                return race;
            }
            set
            {
                var preRaceName = Data.RaceData[race].Name;
                race = value;
                var raceInfo = Data.RaceData[race];
                foreach (KeyValuePair<AbalityEnum, Modifier> kvp in raceInfo.AbilitiesModifiers)
                {
                    Abalities[kvp.Key].RemoveModifierByName(preRaceName);
                    Abalities[kvp.Key].AddModifier(kvp.Value);
                }
            }
        }
        public Dictionary<AbalityEnum, Attribute> Abalities { get; set; }
        public CombatAttributes CombatAttributes { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            foreach (AbalityEnum abality in Enum.GetValues(typeof(AbalityEnum)))
            {
                Console.WriteLine($"{abality}: {Abalities[abality].FinalValue}");
                string modifierText = "";
                Abalities[abality].Modifiers.ForEach(modify =>
                {
                    modifierText += $"[{modify.Name}: {modify.Value}] ";
                });
                Console.WriteLine(modifierText);
            }
        }
    }
}