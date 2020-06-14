using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shovel_Knight_Save_Editor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region Definitons
        public Save saveFile;
        string path;

        string[] shovelarmor = new string[]
        {
            "Stalwart Plate",
            "Conjurer's Coat",
            "Dynamo Mail",
            "Mail of Momentum",
            "Oranate Plate",
            "Fail Guard",
            "Armor of Chaos"
        };
        string[] specterarmor = new string[]
        {
            "Crimson Cloak",
            "Striker's Shawl",
            "Rail Mail",
            "Railment of Risk",
            "Clock of Clemency",
            "Ghostly Garb",
            "Donovan Set"
        };
        string[] kingarmor = new string[]
        {
            "King Costume",
            "Lightweight Plate",
            "Vestments of Vigor",
            "Rodent Regalia",
            "Resplendent Cape"
        };

        string[] shovelSubs = new string[]
        {
            "Flare Wind",
            "Phase Locket",
            "Dust Knuckles",
            "Throwing Anchor",
            "Alchemy Coin",
            "Mobile Gear",
            "War Horn",
            "Propeller Dagger",
            "Fishing Rod",
            "Chaos Sphere",
            "Troupple Chalice",
            "Troupple Chalice"
        };

        string[] specterSubs = new string[]
        {
            "Throwing Sickle",
            "Spider Scythe",
            "Dread Talon",
            "Will Skull",
            "Barrier Lantern",
            "Shadow Mirror",
            "Bounding Soul",
            "Hover Plume",
            "Judgement Rush",
            "Chronos Coin",
            "Skeletal Sentry",
            "Caltrops"
        };

        private void MainForm_Load(object sender, EventArgs e)
        {
#if !DEBUG
            bool showDisclaimer = true;
            if (File.Exists("Config.Knight"))
            {
                using (StreamReader sr = new StreamReader("Config.Knight"))
                {
                    string[] line = sr.ReadLine().Split('=');
                    if (line[0] == "showDisclaimer")
                        showDisclaimer = Convert.ToBoolean(line[1]);
                }

                using (StreamWriter sw = new StreamWriter("Config.Knight"))
                {
                    sw.WriteLine("showDisclaimer=false");
                }
            }

            if (showDisclaimer)
                MessageBox.Show("I am not affiliated with Yacht Club Games, This editor was made out of love and fun for their game and programming. \n" +
                    "This message will not appear again.","Disclaimer");
#endif
        }

#endregion
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


#region Subweapons
        private void subwallCB_CheckedChanged(object sender, EventArgs e)
        {
            subwCLB.Enabled = !subwallCB.Checked;

        }

        private void subwCLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subwupgradeallCB_CheckedChanged(object sender, EventArgs e)
        {
            subwupgradeCLB.Enabled = !subwupgradeallCB.Checked;
        }

#endregion

#region Functions
        void load(string fileName)
        {
            
            saveFile = new Save(fileName);
            path = fileName;
            for (int i = 0; i < 20; i++)
            {
                if (saveFile.saveSlots[i].playerName == "")
                {
                    savefileLB.Items[i] = $"{i}: No Save";
                }
                else
                {
                    savefileLB.Items[i] = $"{i}: {saveFile.saveSlots[i].playerName}";
                }
            }
            savefileLB.SelectedIndex = 0;

        }
        void loadSK()
        {
            upgradesGB.Enabled = false;
            subwupgradeallCB.Enabled = false;
            subwupgradeCLB.Enabled = false;
            healthLabel.Text = "Life Upgrades:";
            magicLabel.Text = "Items Upgrades:";

            armorCB.Items.Clear();
            for (int i = 0; i < 7; i++)
            {
                armorCB.Items.Add(shovelarmor[i]);
            }
            armorCB.Items.Add("Toad Gear");
            if (saveFile.saveSlots[savefileLB.SelectedIndex].playerArmor > 8)
            {
                MessageBox.Show("Unknown value using \"playerArmor\", setting to \'0\'", "Shovel Knight - Error!");
                armorCB.SelectedIndex = 0;
            }
            else
            {
                armorCB.SelectedIndex = saveFile.saveSlots[savefileLB.SelectedIndex].playerArmor - 1;
            }

            for (int i = 0; i < specterSubs.Length; i++)
            {
                subwCLB.Items[i] = shovelSubs[i];
            }

            subwGB.Text = "Relics:";
            for (int i = 0; i < 12; i++)
            {
                subwCLB.SetItemChecked(i, (saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsCollected & (1 << (i + 1))) != 0);
                //var bit = (saveFile.saveSlots[savefileCMB.SelectedIndex].subWeaponsCollected & (1 << (i + 12))) != 0;
            }
        }
        void loadPK()
        {

        }
        void loadSR()
        {

            upgradesGB.Enabled = true;
            subwupgradeallCB.Enabled = true;
            subwupgradeCLB.Enabled = true;
            for (int i = 0; i < specterSubs.Length; i++)
            {
                subwCLB.Items[i] = specterSubs[i];
                subwupgradeCLB.Items[i] = specterSubs[i];
            }

            //if (plyhealthNUD.Value > 6)
            //    plyhealthNUD.Value = 6;
            //if (plymagicNUD.Value > 3)
            //    plymagicNUD.Value = 3;

            //plyhealthNUD.Maximum = 6;
            //plymagicNUD.Maximum = 3;

            healthLabel.Text = "Will Upgrades:";
            magicLabel.Text = "Darkness Upgrades:";

            subwGB.Text = "Curios:";
            for (int i = 0; i < 12; i++)
            {
                subwCLB.SetItemChecked(i, (saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsCollected & (1 << (i + 13))) != 0);
                //var bit = (saveFile.saveSlots[savefileCMB.SelectedIndex].subWeaponsCollected & (1 << (i + 12))) != 0;
            }
            string[] weaponupgradelevelarr = saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsUpgradeLevel.Substring(26, 23).Split(' ');
            for (int i = 0; i < weaponupgradelevelarr.Length; i++)
            {
                subwupgradeCLB.SetItemChecked(i, (weaponupgradelevelarr[i] == "1" ? true : false));
            }

            armorCB.Items.Clear();
            for (int i = 0; i < 7; i++)
            {
                armorCB.Items.Add(specterarmor[i]);
            }
            if ((saveFile.saveSlots[savefileLB.SelectedIndex].playerArmor) > 7)
            {
                MessageBox.Show("Unknown value using \"playerArmor\", setting to \'0\'", "Specter Knight - Error!");
                armorCB.SelectedIndex = 0;
            }
            else
            {
                armorCB.SelectedIndex = saveFile.saveSlots[savefileLB.SelectedIndex].playerArmor - 1;
            }

        }
        void loadKK()
        {

        }


        void unlock()
        {
            playertypeGB.Enabled = true;
            infoGB.Enabled = true;
            subwGB.Enabled = true;
            upgradesGB.Enabled = true;
            overwriteToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            saveslotGB.Enabled = true;
        }
#endregion
#region Radio Buttons
        private void plyskRBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (plyskRBTN.Checked)
                loadSK();
        }

        private void plypkRBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (plypkRBTN.Checked)
                loadPK();
        }

        private void plysrRBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (plysrRBTN.Checked)
                loadSR();
        }

        private void plykkRBTN_CheckedChanged(object sender, EventArgs e)
        {
            if (plykkRBTN.Checked)
                loadKK();
        }
#endregion

#region Toolstrip
        private void localFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\Yacht Club Games\\Shovel Knight\\saveData.bin";
            if (!File.Exists(path))
            {
                MessageBox.Show($"No file found in {path}", "Could not find file!");
                return;
            }
            load(path);
        }
        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Please Select Shovel Knight: Treasure trove save file";
                dlg.Filter = "Save Data|saveData.bin";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    load(dlg.FileName);
                }
            }
        }

        private void tshelpaboutBTN_Click(object sender, EventArgs e)
        {
            about form = new about();
            form.Show();
        }
        private void savefileLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            plynameTB.Text = saveFile.saveSlots[savefileLB.SelectedIndex].playerName;
            plymoneyNUD.Value = saveFile.saveSlots[savefileLB.SelectedIndex].money;
            ngpCB.Checked = saveFile.saveSlots[savefileLB.SelectedIndex].gameCompleteCount == 1 ? true : false;
            plyhealthNUD.Value = saveFile.saveSlots[savefileLB.SelectedIndex].healthUpgrades;
            plymagicNUD.Value = saveFile.saveSlots[savefileLB.SelectedIndex].magicUpgrades;

            switch (saveFile.saveSlots[savefileLB.SelectedIndex].player)
            {
                case Save.PLAYER_TYPE.Shovel_Knight:
                    plyskRBTN.Checked = true;
                    loadSK();
                    break;
                case Save.PLAYER_TYPE.Plague_Knight:
                    plypkRBTN.Checked = true;
                    loadPK();
                    break;
                case Save.PLAYER_TYPE.Specter_Knight:
                    plysrRBTN.Checked = true;
                    loadSR();
                    break;
                case Save.PLAYER_TYPE.King_Knight:
                    plykkRBTN.Checked = true;
                    loadKK();
                    break;
            }
            unlock();
        }

        private void overwriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
            saveFile.Write(path);
        }
#endregion
        void save()
        {
            saveFile.saveSlots[savefileLB.SelectedIndex].playerName = plynameTB.Text;
            saveFile.saveSlots[savefileLB.SelectedIndex].money = (int)plymoneyNUD.Value;
            if (plyskRBTN.Checked)
            { 
                saveFile.saveSlots[savefileLB.SelectedIndex].player = Save.PLAYER_TYPE.Shovel_Knight;

                if (subwallCB.Checked)
                {
                    saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsCollected = 0b0001111111111111;
                }
                else
                {
                    long value = 0x0;
                    for (int i = 0; i < subwCLB.Items.Count; i++)
                    {
                        if (subwCLB.GetItemChecked(i))
                        {
                            value |= 1 << (i + 1);
                        }
                    }
                    saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsCollected = value;
                    saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsTurnedIn = value;
                }

                //string subwupgrade = "0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 ";
                //if (subwupgradeallCB.Checked)
                //{
                //    subwupgrade += "1 1 1 1 1 1 1 1 1 1 1 1 ";
                //}
                //else
                //{
                //    for (int i = 0; i < subwupgradeCLB.Items.Count; i++)
                //    {
                //        if (subwupgradeCLB.GetItemChecked(i))
                //        {
                //            subwupgrade += "1 ";
                //        }
                //        else
                //        {
                //            subwupgrade += "0 ";
                //        }
                //    }
                //}
                //saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsUpgradeLevel = subwupgrade;
            }
            else if (plypkRBTN.Checked)
            { saveFile.saveSlots[savefileLB.SelectedIndex].player = Save.PLAYER_TYPE.Plague_Knight; }
            else if (plysrRBTN.Checked)
            {
                saveFile.saveSlots[savefileLB.SelectedIndex].player = Save.PLAYER_TYPE.Specter_Knight;

                if (subwallCB.Checked)
                {
                    saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsCollected = 33546240;
                }
                else
                {
                    long value = 0x0;
                    for (int i = 0; i < subwCLB.Items.Count; i++)
                    {
                        if (subwCLB.GetItemChecked(i))
                        {
                            value |= 1 << (i + 13);
                        }
                    }
                    saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsCollected = value;
                    saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsTurnedIn = value;
                }

                string subwupgrade = "0 0 0 0 0 0 0 0 0 0 0 0 0 ";
                if (subwupgradeallCB.Checked)
                {
                    subwupgrade += "1 1 1 1 1 1 1 1 1 1 1 1 ";
                }
                else
                {
                    for (int i = 0; i < subwupgradeCLB.Items.Count; i++)
                    {
                        if (subwupgradeCLB.GetItemChecked(i))
                        {
                            subwupgrade += "1 ";
                        }
                        else
                        {
                            subwupgrade += "0 ";
                        }
                    }
                }
                subwupgrade += "0 0 0 0 0 0 0 0 0 0 0 0";
                saveFile.saveSlots[savefileLB.SelectedIndex].subWeaponsUpgradeLevel = subwupgrade;

            }
            else if (plykkRBTN.Checked)
            { saveFile.saveSlots[savefileLB.SelectedIndex].player = Save.PLAYER_TYPE.King_Knight; }
            saveFile.saveSlots[savefileLB.SelectedIndex].healthUpgrades = (int)plyhealthNUD.Value;
            saveFile.saveSlots[savefileLB.SelectedIndex].magicUpgrades = (int)plymagicNUD.Value;


            saveFile.saveSlots[savefileLB.SelectedIndex].gameCompleteCount = ngpCB.Checked ? 1 : 0;
            saveFile.saveSlots[savefileLB.SelectedIndex].playerArmor = armorCB.SelectedIndex + 1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitter.com/BetaAngel01");
        }

    }
}
