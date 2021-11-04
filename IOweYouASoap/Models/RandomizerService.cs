using System;
using System.Collections.Generic;

namespace IOweYouASoap.Models
{
    public class RandomizerService : IRandomizerService
        {
        public IList<string> elements { get; set; }
        public int number { get; set; }

        public IList<string> getRandomElement(IList<string> elements, int number)
            {
                if (number > elements.Count)
                    return new List<string>();
                Random random = new ((int)DateTime.Now.Ticks);
                var returnedElements = new List<string>();
                int selectedIndex = random.Next(0, elements.Count);
                returnedElements.Add(elements[selectedIndex]);
                elements.RemoveAt(selectedIndex);
                return returnedElements;
            }
    }
}
