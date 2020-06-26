using InfiniteAbyss.Core.Enums;
using System;
using System.Collections.Generic;

namespace InfiniteAbyss.Core.Models
{
    public class Attribute
    {
        private int flat = 0;
        private int precent = 100;
        public Attribute(int baseValue)
        {
            BaseValue = baseValue;
            Modifiers = new List<Modifier>();
        }
        public int BaseValue { get; set; }
        public int FinalValue => (BaseValue + flat) * (precent / 100);
        public List<Modifier> Modifiers { get; }

        public void AddModifier(Modifier modifier)
        {
            if(modifier.Type == ModifierType.FLAT && modifier.Value == 0 || modifier.Type == ModifierType.PRECENT && modifier.Value == 100)
            {
                return;
            }
            Modifiers.Add(modifier);
            switch (modifier.Type)
            {
                case ModifierType.FLAT:
                    flat += modifier.Value;
                    return;
                case ModifierType.PRECENT:
                    precent += modifier.Value;
                    return;
                default:
                    return;
            }
        }

        public bool RemoveModifier(Modifier modifier)
        {
            if (!Modifiers.Remove(modifier))
            {
                return false;
            }
            switch (modifier.Type)
            {
                case ModifierType.FLAT:
                    flat -= modifier.Value;
                    break;
                case ModifierType.PRECENT:
                    precent -= modifier.Value;
                    break;
                default:
                    return false;
            }
            return true;
        }

        public void RemoveModifierByName(string name)
        {
            for (int i = Modifiers.Count - 1; i >= 0; i--)
            {
                if(Modifiers[i].Name == name)
                {
                    RemoveModifier(Modifiers[i]);
                }
            }
        }
    }
}