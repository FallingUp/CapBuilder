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
        public string Name;
        public int TritaniumValue;
        public int PyeriteValue;
        public int MexallonValue;
        public int IsogenValue;
        public int NocxiumValue;
        public int ZydrineValue;
        public int MegacyteValue;
        public int ISKCost;
    }

    class Capital
    {
        public string CapitalName;
        public int TritaniumCost;
        public int PyeriteCost;
        public int MexallonCost;
        public int IsogenCost;
        public int NocxiumCost;
        public int ZydrineCost;
        public int MegacyteCost;
        public int ISKCost;

        public Capital(string CapitalName, int Tritanium, int Pyerite, int Mexallon, int Isogen, int Nocxium, int Zydrine, int Megacyte):this(CapitalName,Tritanium,Pyerite,Mexallon,Isogen,Nocxium,Zydrine,Megacyte,0)
        {
            this.CapitalName = CapitalName;
            TritaniumCost = Tritanium;
            PyeriteCost = Pyerite;
            MexallonCost = Mexallon;
            IsogenCost = Isogen;
            NocxiumCost = Nocxium;
            ZydrineCost = Zydrine;
            MegacyteCost = Megacyte;
        }
        public Capital(string CapitalName, int Tritanium, int Pyerite, int Mexallon, int Isogen, int Nocxium, int Zydrine, int Megacyte, int ISKCost)
        {
            this.CapitalName = CapitalName;
            TritaniumCost = Tritanium;
            PyeriteCost = Pyerite;
            MexallonCost = Mexallon;
            IsogenCost = Isogen;
            NocxiumCost = Nocxium;
            ZydrineCost = Zydrine;
            MegacyteCost = Megacyte;
            this.ISKCost = ISKCost;
        }
    }

    class Component
    {
        public string ComponentName;
        public int TritaniumCost;
        public int PyeriteCost;
        public int MexallonCost;
        public int IsogenCost;
        public int NocxiumCost;
        public int ZydrineCost;
        public int MegacyteCost;
        public int ISKCost;

        public Component(string ComponentName, int Tritanium, int Pyerite, int Mexallon, int Isogen, int Nocxium, int Zydrine, int Megacyte):this(ComponentName,Tritanium,Pyerite,Mexallon,Isogen,Nocxium,Zydrine,Megacyte,0)
        {
            this.ComponentName = ComponentName;
            TritaniumCost = Tritanium;
            PyeriteCost = Pyerite;
            MexallonCost = Mexallon;
            IsogenCost = Isogen;
            NocxiumCost = Nocxium;
            ZydrineCost = Zydrine;
            MegacyteCost = Megacyte;
        }
        public Component(string ComponentName, int Tritanium, int Pyerite, int Mexallon, int Isogen, int Nocxium, int Zydrine, int Megacyte, int ISKCost)
        {
            this.ComponentName = ComponentName;
            TritaniumCost = Tritanium;
            PyeriteCost = Pyerite;
            MexallonCost = Mexallon;
            IsogenCost = Isogen;
            NocxiumCost = Nocxium;
            ZydrineCost = Zydrine;
            MegacyteCost = Megacyte;
            this.ISKCost = ISKCost;
        }
    }

    class Program
    {
        public void LoadOreValues(ref Ore[] OreOrder, string OreNames)
        {
            string[] OreValues = File.ReadAllLines("CompressedOres");
            OreOrder = new Ore[OreValues.Length];

            for (int i = 0; i < OreValues.Length; i++)
            {
                string[] Val = OreValues[i].Split(' ');
                OreOrder[i] = string.;
                
            }
        }
        public void AddComponents(string[] args)
        {
            Component CapitalSensorCluster = new Component("Capital Sensor Cluster", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalPowerGenerator = new Component("Capital Power Generator", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalPropulsionEngine = new Component("Capital Propulsion Engine", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalCapacitorBattery = new Component("Capital Capacitor Battery", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalCorporateHangarBay = new Component("Capital Corporate Hangar Bay", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalJumpDrive = new Component("Capital Jump Drive", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalArmorPlates = new Component("Capital Armor Plates", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalComputerSystem = new Component("Capital Computer System", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalConstructionParts = new Component("Capital Construction Parts", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalShipMaintenanceBay = new Component("Capital Ship Maintenance Bay", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalShieldEmitter = new Component("Capital Shield Emitter", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalSiegeArray = new Component("Capital Siege Array", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalTurretHardpoint = new Component("Capital Turret Hardpoint", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalLauncherHardpoint = new Component("Capital Launcher Hardpoint", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalDroneBay = new Component("Capital Drone Bay", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalCloneVatBay = new Component("Capital Clone Vat Bay", 1, 2, 3, 4, 5, 6, 7);
            Component CapitalCargoBay = new Component("Capital Cargo Bay", 1, 2, 3, 4, 5, 6, 7);
        }
        public void AddCapitals(string[] args)
        {
            Capital Naglfar = new Capital("Naglfar", 1, 2, 3, 4, 5, 6, 7);
            Capital Phoenix = new Capital("Phoenix", 1, 2, 3, 4, 5, 6, 7);
            Capital Revelation = new Capital("Revelation", 1, 2, 3, 4, 5, 6, 7);
            Capital Moros = new Capital("Moros", 1, 2, 3, 4, 5, 6, 7);
            Capital Apostle = new Capital("Apostle", 1, 2, 3, 4, 5, 6, 7);
            Capital Ninazu = new Capital("Ninazu", 1, 2, 3, 4, 5, 6, 7);
            Capital Lif = new Capital("Lif", 1, 2, 3, 4, 5, 6, 7);
            Capital Minokawa = new Capital("Minokawa", 1, 2, 3, 4, 5, 6, 7);
            Capital Archon = new Capital("Archon", 1, 2, 3, 4, 5, 6, 7);
            Capital Thanatos = new Capital("Thanatos", 1, 2, 3, 4, 5, 6, 7);
            Capital Chimera = new Capital("Chimera", 1, 2, 3, 4, 5, 6, 7);
            Capital Nidhoggur = new Capital("Nidhoggur", 1, 2, 3, 4, 5, 6, 7);
            Capital Rorqual = new Capital("Rorqual", 1, 2, 3, 4, 5, 6, 7);
        }


        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}