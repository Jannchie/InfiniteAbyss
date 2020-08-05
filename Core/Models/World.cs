using InfiniteAbyss.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace InfiniteAbyss.Core.Models
{
    public enum Season
    {
        SPRING = 1,
        SUMMER = 2,
        AUTUMN = 3,
        WINTER = 4
    }
    public class WorldDate
    {
        public int Year { get => Day / 360 + 1; }
        public int Month { get => (Day / 30) % 12 + 1; }
        public int SeasonIndex { get => (Day / 90) % 4 + 1; }
        public string Season { get => Enum.GetName(typeof(Season), SeasonIndex); }
        public int Day { get; set; }
        public int Date { get => Day % 30 + 1; }
    }

    public class World
    {
        public WorldDate Date { get; set; }
        public World()
        {
            Date = new WorldDate()
            {
                Day = 0
            };
        }
        public void NextDay()
        {
            UpdateDate();
        }

        private void UpdateDate()
        {
            Date.Day += 1;
            Logger.Info("World", $"A New Day...Year: {Date.Year}, Month: {Date.Month}, Day {Date.Date}, Season: {Date.Season}");
        }
    }

}
