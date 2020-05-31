using System;
using System.Collections.Generic;
using System.Text;

namespace InfiniteAbyss.Core.Models
{
    public enum ModifierType
    {
        FLAT, PRECENT
    }

    public class Modifier
    {
        public Modifier(string name, int value, ModifierType type)
        {
            Name = name;
            Value = value;
            Type = type;
        }

        public string Name { get; set; }
        public int Value { get; set; }
        public ModifierType Type { get; set; }
    }
}
