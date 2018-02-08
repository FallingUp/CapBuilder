using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace CapBuilder
{
    struct Ore
    {
        public string[] Name;
        public int[] TritaniumValue;
        public int[] PyeriteValue;
        public int[] MexallonValue;
        public int[] IsogenValue;
        public int[] NocxiumValue;
        public int[] ZydrineValue;
        public int[] MegacyteValue;
        public int[] ISKCost;
    }

    class Program
    {
        public void LoadOreValues(ref Ore[] OreOrder, string[] OreNames)
        {
            string[] OreValues = File.ReadAllLines("CompressedOres");
            OreOrder = new Ore[OreValues.Length];

            for (int i = 0; i < OreValues.Length; i++)
            {
                string[] Val = OreValues[i].Split(' ');
                OreOrder[i].Name = ;
            }
        }

        static void Main(string[] args)
        {

        }
    }
}