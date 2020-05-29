﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivModTool.Resources
{
    public static class Dictionaries
    {
        public static readonly Dictionary<Civs, Tuple<int, string, ArtStyles>> CivDictionary =
            new Dictionary<Civs, Tuple<int, string, ArtStyles>>
            {
                {Civs.America, new Tuple<int, string, ArtStyles>(1, "American", ArtStyles.American)},
                {Civs.Arabia, new Tuple<int, string, ArtStyles>(2, "Arabian", ArtStyles.African)},
                {Civs.Assyria, new Tuple<int, string, ArtStyles>(3, "Assyrian", ArtStyles.Mediterranean)},
                {Civs.Austria, new Tuple<int, string, ArtStyles>(4, "Austrian", ArtStyles.European)},
                {Civs.Aztec, new Tuple<int, string, ArtStyles>(5, "Aztec", ArtStyles.American)},
                {Civs.Babylon, new Tuple<int, string, ArtStyles>(6, "Babylonian", ArtStyles.Mediterranean)},
                {Civs.Brazil, new Tuple<int, string, ArtStyles>(7, "Brazilian", ArtStyles.American)},
                {Civs.Byzantium, new Tuple<int, string, ArtStyles>(8, "Byzantine", ArtStyles.Mediterranean)},
                {Civs.Carthage, new Tuple<int, string, ArtStyles>(9, "Carthaginian", ArtStyles.Mediterranean)},
                {Civs.Celts, new Tuple<int, string, ArtStyles>(10, "Celts", ArtStyles.European)},
                {Civs.China, new Tuple<int, string, ArtStyles>(11, "Chinese", ArtStyles.Asian)},
                {Civs.Denmark, new Tuple<int, string, ArtStyles>(12, "Dutch", ArtStyles.European)},
                {Civs.Egypt, new Tuple<int, string, ArtStyles>(13, "Egyptian", ArtStyles.African)},
                {Civs.England, new Tuple<int, string, ArtStyles>(14, "English", ArtStyles.European)},
                {Civs.Ethiopia, new Tuple<int, string, ArtStyles>(15, "Ethiopian", ArtStyles.African)},
                {Civs.France, new Tuple<int, string, ArtStyles>(16, "French", ArtStyles.American)},
                {Civs.Germany, new Tuple<int, string, ArtStyles>(17, "German", ArtStyles.European)},
                {Civs.Greece, new Tuple<int, string, ArtStyles>(18, "Greek", ArtStyles.Mediterranean)},
                {Civs.Huns, new Tuple<int, string, ArtStyles>(19, "Hunnic", ArtStyles.Asian)},
                {Civs.Inca, new Tuple<int, string, ArtStyles>(20, "Incan", ArtStyles.American)},
                {Civs.India, new Tuple<int, string, ArtStyles>(21, "Indian", ArtStyles.Asian)},
                {Civs.Indonesia, new Tuple<int, string, ArtStyles>(22, "Indonesian", ArtStyles.Asian)},
                {Civs.Iroquois, new Tuple<int, string, ArtStyles>(23, "Iroquois", ArtStyles.American)},
                {Civs.Japan, new Tuple<int, string, ArtStyles>(24, "Japanese", ArtStyles.Asian)},
                {Civs.Korea, new Tuple<int, string, ArtStyles>(25, "Korean", ArtStyles.Asian)},
                {Civs.Maya, new Tuple<int, string, ArtStyles>(26, "Mayan", ArtStyles.American)},
                {Civs.Mongol, new Tuple<int, string, ArtStyles>(27, "Mongolian", ArtStyles.Asian)},
                {Civs.Morocco, new Tuple<int, string, ArtStyles>(28, "Moroccan", ArtStyles.African)},
                {Civs.Netherlands, new Tuple<int, string, ArtStyles>(29, "Dutch", ArtStyles.European)},
                {Civs.Ottoman, new Tuple<int, string, ArtStyles>(30, "Ottoman", ArtStyles.African)},
                {Civs.Persia, new Tuple<int, string, ArtStyles>(31, "Persian", ArtStyles.African)},
                {Civs.Poland, new Tuple<int, string, ArtStyles>(32, "Polish", ArtStyles.European)},
                {Civs.Polynesia, new Tuple<int, string, ArtStyles>(33, "Polynesian", ArtStyles.Asian)},
                {Civs.Portugal, new Tuple<int, string, ArtStyles>(34, "Portuguese", ArtStyles.European)},
                {Civs.Rome, new Tuple<int, string, ArtStyles>(35, "Roman", ArtStyles.Mediterranean)},
                {Civs.Russia, new Tuple<int, string, ArtStyles>(36, "Russian", ArtStyles.European)},
                {Civs.Shoshone, new Tuple<int, string, ArtStyles>(37, "Shoshone", ArtStyles.American)},
                {Civs.Siam, new Tuple<int, string, ArtStyles>(38, "Siamese", ArtStyles.Asian)},
                {Civs.Songhai, new Tuple<int, string, ArtStyles>(39, "Songhai", ArtStyles.African)},
                {Civs.Spain, new Tuple<int, string, ArtStyles>(40, "Spanish", ArtStyles.European)},
                {Civs.Sweden, new Tuple<int, string, ArtStyles>(41, "Swedish", ArtStyles.European)},
                {Civs.Venice, new Tuple<int, string, ArtStyles>(42, "Venetian", ArtStyles.Mediterranean)},
                {Civs.Zulu, new Tuple<int, string, ArtStyles>(43, "Zulu", ArtStyles.African)}
            };

        public static readonly Dictionary<Units, Tuple<int, UnitAI>> UnitDictionary = new Dictionary<Units, Tuple<int, UnitAI>>
            {
                {Units.AntiAircraftGun, new Tuple<int, UnitAI>(1, UnitAI.Unknown)},
                {Units.AntiTankGun, new Tuple<int, UnitAI>(2, UnitAI.Unknown)},
                {Units.Archer, new Tuple<int, UnitAI>(3, UnitAI.Unknown)},
                {Units.Artillery, new Tuple<int, UnitAI>(4, UnitAI.Unknown)},
                {Units.Artist, new Tuple<int, UnitAI>(5, UnitAI.Unknown)},
                {Units.AtomicBomb, new Tuple<int, UnitAI>(6, UnitAI.Unknown)},
                {Units.Barbarian_Archer, new Tuple<int, UnitAI>(7, UnitAI.Unknown)},
                {Units.Barbarian_Spearman, new Tuple<int, UnitAI>(8, UnitAI.Unknown)},
                {Units.Barbarian_Swordman, new Tuple<int, UnitAI>(9, UnitAI.Unknown)},
                {Units.Barbarian_Warrior, new Tuple<int, UnitAI>(10, UnitAI.Unknown)},
                {Units.Battleship, new Tuple<int, UnitAI>(11, UnitAI.Unknown)},
                {Units.Bomber, new Tuple<int, UnitAI>(12, UnitAI.Unknown)},
                {Units.Bomber_B17, new Tuple<int, UnitAI>(13, UnitAI.Unknown)},
                {Units.Cannon, new Tuple<int, UnitAI>(14, UnitAI.Unknown)},
                {Units.Caravel, new Tuple<int, UnitAI>(15, UnitAI.Unknown)},
                {Units.Carrier, new Tuple<int, UnitAI>(16, UnitAI.Unknown)},
                {Units.Catapult, new Tuple<int, UnitAI>(17, UnitAI.Unknown)},
                {Units.Catapult_Ballista, new Tuple<int, UnitAI>(18, UnitAI.Unknown)},
                {Units.Cavalry, new Tuple<int, UnitAI>(19, UnitAI.Unknown)},
                {Units.Cavalry_Cossack, new Tuple<int, UnitAI>(20, UnitAI.Unknown)},
                {Units.ChariotArcher, new Tuple<int, UnitAI>(21, UnitAI.Unknown)},
                {Units.ChariotArcher_WarChariot, new Tuple<int, UnitAI>(22, UnitAI.Unknown)},
                {Units.ChariotArcher_Warelephant, new Tuple<int, UnitAI>(23, UnitAI.Unknown)},
                {Units.Crossbowman, new Tuple<int, UnitAI>(24, UnitAI.Unknown)},
                {Units.Crossbowman_Chukonu, new Tuple<int, UnitAI>(25, UnitAI.Unknown)},
                {Units.Crossbowman_Longbowman, new Tuple<int, UnitAI>(26, UnitAI.Unknown)},
                {Units.Destroyer, new Tuple<int, UnitAI>(27, UnitAI.Unknown)},
                {Units.Engineer, new Tuple<int, UnitAI>(28, UnitAI.Unknown)},
                {Units.Fighter, new Tuple<int, UnitAI>(29, UnitAI.Unknown)},
                {Units.Fighter_JapaneseZero, new Tuple<int, UnitAI>(30, UnitAI.Unknown)},
                {Units.Frigate, new Tuple<int, UnitAI>(31, UnitAI.Unknown)},
                {Units.Frigate_ShipOfTheLine, new Tuple<int, UnitAI>(32, UnitAI.Unknown)},
                {Units.Galley, new Tuple<int, UnitAI>(33, UnitAI.Unknown)},
                {Units.General, new Tuple<int, UnitAI>(34, UnitAI.Unknown)},
                {Units.GuidedMissle, new Tuple<int, UnitAI>(35, UnitAI.Unknown)},
                {Units.HelicopterGunship, new Tuple<int, UnitAI>(36, UnitAI.Unknown)},
                {Units.Horseman, new Tuple<int, UnitAI>(37, UnitAI.Unknown)},
                {Units.Horseman_CompanionCavalry, new Tuple<int, UnitAI>(38, UnitAI.Unknown)},
                {Units.Infantry, new Tuple<int, UnitAI>(39, UnitAI.Unknown)},
                {Units.Infantry_ForeignLegion, new Tuple<int, UnitAI>(40, UnitAI.Unknown)},
                {Units.Ironclad, new Tuple<int, UnitAI>(41, UnitAI.Unknown)},
                {Units.JetFighter, new Tuple<int, UnitAI>(42, UnitAI.Unknown)},
                {Units.Knight, new Tuple<int, UnitAI>(43, UnitAI.Unknown)},
                {Units.Knight_Camelarcher, new Tuple<int, UnitAI>(44, UnitAI.Unknown)},
                {Units.Knight_MuslimCavalry, new Tuple<int, UnitAI>(45, UnitAI.Unknown)},
                {Units.Knight_Warelephant, new Tuple<int, UnitAI>(46, UnitAI.Unknown)},
                {Units.Lancer, new Tuple<int, UnitAI>(47, UnitAI.Unknown)},
                {Units.Lancer_Sipahi, new Tuple<int, UnitAI>(48, UnitAI.Unknown)},
                {Units.Longswordman, new Tuple<int, UnitAI>(49, UnitAI.Unknown)},
                {Units.Longswordman_Samurai, new Tuple<int, UnitAI>(50, UnitAI.Unknown)},
                {Units.Mech, new Tuple<int, UnitAI>(51, UnitAI.Unknown)},
                {Units.MechanizedInfantry, new Tuple<int, UnitAI>(52, UnitAI.Unknown)},
                {Units.Merchant, new Tuple<int, UnitAI>(53, UnitAI.Unknown)},
                {Units.MissleCruiser, new Tuple<int, UnitAI>(54, UnitAI.Unknown)},
                {Units.MobileSAM, new Tuple<int, UnitAI>(55, UnitAI.Unknown)},
                {Units.ModernArmor, new Tuple<int, UnitAI>(56, UnitAI.Unknown)},
                {Units.Musketman, new Tuple<int, UnitAI>(57, UnitAI.Unknown)},
                {Units.Musketman_Janissary, new Tuple<int, UnitAI>(58, UnitAI.Unknown)},
                {Units.Musketman_Minuteman, new Tuple<int, UnitAI>(59, UnitAI.Unknown)},
                {Units.Musketman_Musketeer, new Tuple<int, UnitAI>(60, UnitAI.Unknown)},
                {Units.NuclearMissle, new Tuple<int, UnitAI>(61, UnitAI.Unknown)},
                {Units.NuclearSubmarine, new Tuple<int, UnitAI>(62, UnitAI.Unknown)},
                {Units.Paratrooper, new Tuple<int, UnitAI>(63, UnitAI.Unknown)},
                {Units.Pikeman, new Tuple<int, UnitAI>(64, UnitAI.Unknown)},
                {Units.Pikeman_Landsknecht, new Tuple<int, UnitAI>(65, UnitAI.Unknown)},
                {Units.Rifleman, new Tuple<int, UnitAI>(66, UnitAI.Unknown)},
                {Units.RocketArtillery, new Tuple<int, UnitAI>(67, UnitAI.Unknown)},
                {Units.Scientist, new Tuple<int, UnitAI>(68, UnitAI.Unknown)},
                {Units.Scout, new Tuple<int, UnitAI>(69, UnitAI.Unknown)},
                {Units.Settler, new Tuple<int, UnitAI>(70, UnitAI.Settle)},
                {Units.SpaceShip_Booster, new Tuple<int, UnitAI>(71, UnitAI.Unknown)},
                {Units.SpaceShip_Cockpit, new Tuple<int, UnitAI>(72, UnitAI.Unknown)},
                {Units.SpaceShip_Engine, new Tuple<int, UnitAI>(73, UnitAI.Unknown)},
                {Units.SpaceShip_StasisChamber, new Tuple<int, UnitAI>(74, UnitAI.Unknown)},
                {Units.Spearman, new Tuple<int, UnitAI>(75, UnitAI.Unknown)},
                {Units.Spearman_Hoplite, new Tuple<int, UnitAI>(76, UnitAI.Unknown)},
                {Units.Spearman_Immortal, new Tuple<int, UnitAI>(77, UnitAI.Unknown)},
                {Units.StealthBomber, new Tuple<int, UnitAI>(78, UnitAI.Unknown)},
                {Units.Submarine, new Tuple<int, UnitAI>(79, UnitAI.Unknown)},
                {Units.Swordman, new Tuple<int, UnitAI>(80, UnitAI.Unknown)},
                {Units.Swordman_Legion, new Tuple<int, UnitAI>(81, UnitAI.Unknown)},
                {Units.Swordman_MohawkWarrior, new Tuple<int, UnitAI>(82, UnitAI.Unknown)},
                {Units.Tank, new Tuple<int, UnitAI>(83, UnitAI.Unknown)},
                {Units.Tank_Panzer, new Tuple<int, UnitAI>(84, UnitAI.Unknown)},
                {Units.Trebuchet, new Tuple<int, UnitAI>(85, UnitAI.Unknown)},
                {Units.Trireme, new Tuple<int, UnitAI>(86, UnitAI.Unknown)},
                {Units.Warrior, new Tuple<int, UnitAI>(87, UnitAI.Unknown)},
                {Units.Warrior_Jaguar, new Tuple<int, UnitAI>(88, UnitAI.Unknown)},
                {Units.Workboat, new Tuple<int, UnitAI>(89, UnitAI.Unknown)},
                {Units.Worker, new Tuple<int, UnitAI>(90, UnitAI.Unknown)}
            };
    }
}