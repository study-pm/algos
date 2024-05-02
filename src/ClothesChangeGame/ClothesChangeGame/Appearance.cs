using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesChangeGame
{
    enum Bottom
    {
        blackPants,
        bluePants,
        blueShorts,
        brownPants,
        greenPants,
    }
    enum Shoes
    {
        none,
        crocs,
        gumshoes,
        slippers,
        sneakers,
    }
    enum Top
    {
        blueShirt,
        greenTShirt,
        leatherJacket,
        redShirt,
        redTShirt,
    }
    internal class Appearance
    {
        public bool HasGlassesOn {  get; set; }
        public bool HasGlovesOn { get; set; }
        public bool HasHatOn {  get; set; }
        public Bottom Bottom { get; set; }
        public Top Top { get; set; }
        public Shoes Shoes { get; set; }
        public Appearance()
        {
            HasHatOn = true;
            Bottom = Bottom.blackPants;
            Top = Top.redShirt;
            Shoes = ClothesChangeGame.Shoes.crocs;
        }
    }
}
