using System;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using Helpers;

namespace _07_IEquatable_IComparable
{
    public enum enPearlColor { Black, White, Pink }
    public enum enPearlShape { Round, DropShaped }
    public enum enPearlType { FreshWater, SaltWater }

    #region Pearl as a class
    public class csPearl : IEquatable<csPearl>, IComparable<csPearl>
    {
        public int Size { get; set; }
        public enPearlColor Color { get; init; }
        public enPearlShape Shape { get; init; }
        public enPearlType Type { get; init; }

        public override string ToString() => $"{Size}mm {Color} {Shape} {Type} pearl.";

        public bool Equals(csPearl other) => (this.Size, this.Color, this.Shape, this.Type) ==
            (other.Size, other.Color, other.Shape, other.Type);

        //Needed to implement as part of IEquatable
        public override bool Equals(object obj) => Equals(obj as csPearl);
        public override int GetHashCode() => (this.Size, this.Color, this.Shape, this.Type).GetHashCode();

        
        public int CompareTo(csPearl other)
        {
                 return other.Size.CompareTo(this.Size);

        }


        #region operator overloading
        public static bool operator ==(csPearl o1, csPearl o2) => o1.Equals(o2);
        public static bool operator !=(csPearl o1, csPearl o2) => !o1.Equals(o2);
        #endregion

        public csPearl() { }
        public csPearl(csSeedGenerator _seeder)
        {
            Size = _seeder.Next(5, 25);
            Color = _seeder.FromEnum<enPearlColor>();
            Shape = _seeder.FromEnum<enPearlShape>();
            Type = _seeder.FromEnum<enPearlType>();
        }
        public csPearl(int _size, enPearlColor _color, enPearlShape _shape, enPearlType _type)
        {
            Size = _size;
            Color = _color;
            Shape = _shape;
            Type = _type;
        }
        public csPearl(csPearl org)
        {
            Size = org.Size;
            Color = org.Color;
            Shape = org.Shape;
            Type = org.Type;
        }
    }
    #endregion
}

