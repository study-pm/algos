using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    internal class Appearance : INotifyPropertyChanged
    {
        private Bottom _bottom;
        private Top _top;
        private Shoes _shoes;
        public bool HasGlassesOn {  get; set; }
        public bool HasGlovesOn { get; set; }
        public bool HasHatOn {  get; set; }
        public Bottom Bottom
        {
            get => _bottom;
            set
            {
                if (_bottom != value)
                {
                    _bottom = value;
                    OnPropertyChanged();
                }
            }
        }
        public Top Top
        {
            get => _top;
            set
            {
                if (_top != value)
                {
                    _top = value;
                    OnPropertyChanged();
                }
            }
        }
        public Shoes Shoes
        {
            get => _shoes;
            set
            {
                if (_shoes != value)
                {
                    _shoes = value;
                    OnPropertyChanged();
                }
            }
        }

        public Appearance()
        {
            HasHatOn = true;
            Bottom = Bottom.blackPants;
            Top = Top.redShirt;
            Shoes = ClothesChangeGame.Shoes.crocs;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
