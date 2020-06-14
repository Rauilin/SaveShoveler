using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Shovel_Knight_Save_Editor
{
    public class Save
    {
        public Save() { }
        public Save(string filePath) 
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                int line = 0;
                while (line < 74)
                {
                    string[] temp = sr.ReadLine().Split('=');
                    globals.Add(temp[0], temp[1]);
                    line++;
                }
                for (int i = 0; i < 20; i++)
                {
                    readSaves(sr, i);
                }
                sr.Close();
            }
        }
        public void Write(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var str in globals)
                {
                    sw.WriteLine($"{str.Key}={str.Value}");
                }
                for (int id = 0; id < 20; id++)
                {
                    foreach (var val in saveSlots[id].data)
                    {
                        sw.WriteLine($"{val.Key}_{id + 1}={val.Value}");
                    }
                }
                sw.Close();
            }
        }
        void readSaves(StreamReader sr, int save)
        {
            for (int i = 0; i < 95; i++)
            {
                string[] line = sr.ReadLine().Split('=');
                if (saveSlots[save] == null)
                    saveSlots[save] = new SaveSlot();

                saveSlots[save].data.Add(line[0].Remove(line[0].LastIndexOf('_')), line[1]);
                Console.WriteLine(line[0].Remove(line[0].LastIndexOf('_')));
            }


        }

        Dictionary<string, string> globals = new Dictionary<string, string>();
        public enum PLAYER_TYPE { Shovel_Knight, Plague_Knight, Specter_Knight, King_Knight }
        public enum SPECTER_WEAPONS { Throwing_Sickle, Spider_Scythe, Dread_Talon, Will_Skull, Barrier_Lantern, Shadow_Mirror, Bounding_Soul, Hover_Plume, Judgement_Rush, Chronos_Coin, Skeletal_Sentry, Caltrops }
        public SaveSlot[] saveSlots = new SaveSlot[20];
        public class SaveSlot
        {
            public Dictionary<string, string> data = new Dictionary<string, string>();

            public PLAYER_TYPE player
            {
                get { return (PLAYER_TYPE)Convert.ToInt32(data["uPlayerType"]); }
                set { data["uPlayerType"] = ((int)value).ToString(); }
            }
            public string playerName
            {
                get{ return data["m_rPlayerName"]; }
                set { data["m_rPlayerName"] = value; }
            }
            public string cheatName
            {
                get { return data["m_rCheatName"]; }
                set { data["m_rCheatName"] = value; }
            }
            public int money
            {
                get { return Convert.ToInt32(data["uPlayerMoney"]); }
                set { data["uPlayerMoney"] = value.ToString(); }
            }

            public int playerArmor
            {
                get { return Convert.ToInt32(data["uPlayerArmor"]); }
                set { data["uPlayerArmor"] = value.ToString(); }
            }
            public int gameCompleteCount
            {
                get { return Convert.ToInt32(data["uGameCompleteCount"]);  }
                set { data["uGameCompleteCount"] = value.ToString(); }
            }
            public int healthUpgrades
            {
                get { return Convert.ToInt32(data["uPlayerHealthUpgrade"]); }
                set { data["uPlayerHealthUpgrade"] = value.ToString(); }
            }
            public int magicUpgrades
            {
                get { return Convert.ToInt32(data["uPlayerMagicUpgrade"]); }
                set { data["uPlayerMagicUpgrade"] = value.ToString();  }
            }

            public long subWeaponsCollected
            {
                get { return Convert.ToInt32(data["uSubWeaponCollected"]); }
                set { data["uSubWeaponCollected"] = value.ToString(); }
            }

            public long subWeaponsTurnedIn
            {
                get { return Convert.ToInt32(data["uSubWeaponTurnedIn"]); }
                set { data["uSubWeaponTurnedIn"] = value.ToString(); }
            }
            public string subWeaponsUpgradeLevel
            {
                get { return data["rSubWeaponUpgradeLevel"]; }
                set { data["rSubWeaponUpgradeLevel"] = value; }
            }

        }

    }
}
