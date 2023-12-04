using System;
using System.Drawing;
using Helpers;

namespace _07_IEquatable_IComparable
{
    public class csNecklace : IEquatable<csNecklace>
    {
        public List<csPearl> ListOfPearls { get; set; } = new List<csPearl>();
        public string Name { get; set; }

        public override string ToString()
        {
            string sRet = $"\n{Name}:";
            foreach (var item in ListOfPearls)
            {
                sRet += $"\n{item.ToString()}";
            }
            return sRet;
        }

        public bool Equals(csNecklace other)
        {
            if (this.Name != other.Name)
                return false;
            if (this.ListOfPearls.Count != other.ListOfPearls.Count)
                return false;

            for (int i = 0; i < this.ListOfPearls.Count; i++)
            {
                if (this.ListOfPearls[i] != other.ListOfPearls[i])
                    return false;
            }
            return true;
        }

        public csNecklace(string name)
        {
            Name = name;
        }
        public csNecklace(int nrPearls, string name)
        {
            Name = name;
            var rnd = new csSeedGenerator();
            for (int i = 0; i < nrPearls; i++)
            {
                ListOfPearls.Add(new csPearl(rnd));
            }
        }
        public csNecklace(string name, csPearl _p1, csPearl _p2)
        {
            Name = name;
            ListOfPearls.Add(_p1);
            ListOfPearls.Add(_p2);
        }
        public csNecklace(csNecklace org)
        {
            Name = org.Name;
            //Referrence copy
            //ListOfPearls = org.ListOfPearls;

            ListOfPearls = new List<csPearl>();
            for (int i = 0; i < org.ListOfPearls.Count; i++)
            {
                this.ListOfPearls.Add(new csPearl(org.ListOfPearls[i]));
            }
         
        }
    }
}

