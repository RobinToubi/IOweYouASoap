using System;
using System.Collections.Generic;

namespace BottomUp.Services
{
    public class RandomizerService : IRandomizerService
    {
        public RandomizerService()
        {
        }

        public IList<string> GetRandomElement(IList<string> list, int number = 1)
        {
            if (number > list.Count)
                return new List<string>();
            Random random = new((int)DateTime.Now.Ticks);
            var returnedlist = new List<string>();
            int selectedIndex = random.Next(0, list.Count);
            returnedlist.Add(list[selectedIndex]);
            list.RemoveAt(selectedIndex);
            return returnedlist;
        }
    }
}
