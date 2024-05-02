using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesChangeGame
{
    enum HairColor
    {
        white,
        dark,
        pink
    }
    enum Mood
    {
        happy,
        sad,
        smile,
    }
    internal class Person
    {
        // height in meters
        public double Height { get; set; }
        // weight in kilograms
        public double Weight { get; set; }
        public int Power { get; set; }
        public int IQ { get; set; }
        public string Name { get; set; }
        public string Story { get; set; }
        public string Motto { get; set; }
        public HairColor HairColor { get; set; }
        public Mood Mood { get; set; }
        public Person()
        {
            Mood = Mood.happy;
            HairColor = HairColor.white;
        }
    }
}
