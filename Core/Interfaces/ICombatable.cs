using System.Collections.Generic;
using InfiniteAbyss.Core.Enums;
using InfiniteAbyss.Core.Models;
namespace InfiniteAbyss.Core.Interfaces
{
    public interface ICombatable
    {
        public Dictionary<AbalityEnum, Attribute> Abalities { get; set; }
    }
}