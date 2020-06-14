namespace Shovel_Knight_Save_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.plyskRBTN = new System.Windows.Forms.RadioButton();
            this.playertypeGB = new System.Windows.Forms.GroupBox();
            this.plypkRBTN = new System.Windows.Forms.RadioButton();
            this.plysrRBTN = new System.Windows.Forms.RadioButton();
            this.plykkRBTN = new System.Windows.Forms.RadioButton();
            this.saveslotGB = new System.Windows.Forms.GroupBox();
            this.plynameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plymoneyNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.subwCLB = new System.Windows.Forms.CheckedListBox();
            this.subwGB = new System.Windows.Forms.GroupBox();
            this.subwallCB = new System.Windows.Forms.CheckBox();
            this.subwupgradeCLB = new System.Windows.Forms.CheckedListBox();
            this.subwupgradeallCB = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.infoGB = new System.Windows.Forms.GroupBox();
            this.tssavefiletypeBNT = new System.Windows.Forms.ToolStripDropDownButton();
            this.steamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nintendoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiiUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playstationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsfileBTN = new System.Windows.Forms.ToolStripDropDownButton();
            this.localFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.overwriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.healthLabel = new System.Windows.Forms.Label();
            this.plyhealthNUD = new System.Windows.Forms.NumericUpDown();
            this.plymagicNUD = new System.Windows.Forms.NumericUpDown();
            this.magicLabel = new System.Windows.Forms.Label();
            this.ngpCB = new System.Windows.Forms.CheckBox();
            this.upgradesGB = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.savefileLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.armorCB = new System.Windows.Forms.ListBox();
            this.tshelpaboutBTN = new System.Windows.Forms.ToolStripButton();
            this.playertypeGB.SuspendLayout();
            this.saveslotGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plymoneyNUD)).BeginInit();
            this.subwGB.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.infoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plyhealthNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plymagicNUD)).BeginInit();
            this.upgradesGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // plyskRBTN
            // 
            this.plyskRBTN.AutoSize = true;
            this.plyskRBTN.Checked = true;
            this.plyskRBTN.Location = new System.Drawing.Point(8, 16);
            this.plyskRBTN.Name = "plyskRBTN";
            this.plyskRBTN.Size = new System.Drawing.Size(91, 17);
            this.plyskRBTN.TabIndex = 1;
            this.plyskRBTN.TabStop = true;
            this.plyskRBTN.Text = "Shovel Knight";
            this.plyskRBTN.UseVisualStyleBackColor = true;
            this.plyskRBTN.CheckedChanged += new System.EventHandler(this.plyskRBTN_CheckedChanged);
            // 
            // playertypeGB
            // 
            this.playertypeGB.Controls.Add(this.plykkRBTN);
            this.playertypeGB.Controls.Add(this.plysrRBTN);
            this.playertypeGB.Controls.Add(this.plypkRBTN);
            this.playertypeGB.Controls.Add(this.plyskRBTN);
            this.playertypeGB.Enabled = false;
            this.playertypeGB.Location = new System.Drawing.Point(12, 27);
            this.playertypeGB.Name = "playertypeGB";
            this.playertypeGB.Size = new System.Drawing.Size(140, 110);
            this.playertypeGB.TabIndex = 2;
            this.playertypeGB.TabStop = false;
            this.playertypeGB.Text = "Player Type:";
            // 
            // plypkRBTN
            // 
            this.plypkRBTN.AutoSize = true;
            this.plypkRBTN.Location = new System.Drawing.Point(8, 39);
            this.plypkRBTN.Name = "plypkRBTN";
            this.plypkRBTN.Size = new System.Drawing.Size(91, 17);
            this.plypkRBTN.TabIndex = 3;
            this.plypkRBTN.Text = "Plague Knight";
            this.plypkRBTN.UseVisualStyleBackColor = true;
            this.plypkRBTN.CheckedChanged += new System.EventHandler(this.plypkRBTN_CheckedChanged);
            // 
            // plysrRBTN
            // 
            this.plysrRBTN.AutoSize = true;
            this.plysrRBTN.Location = new System.Drawing.Point(8, 62);
            this.plysrRBTN.Name = "plysrRBTN";
            this.plysrRBTN.Size = new System.Drawing.Size(95, 17);
            this.plysrRBTN.TabIndex = 4;
            this.plysrRBTN.Text = "Specter Knight";
            this.plysrRBTN.UseVisualStyleBackColor = true;
            this.plysrRBTN.CheckedChanged += new System.EventHandler(this.plysrRBTN_CheckedChanged);
            // 
            // plykkRBTN
            // 
            this.plykkRBTN.AutoSize = true;
            this.plykkRBTN.Location = new System.Drawing.Point(8, 85);
            this.plykkRBTN.Name = "plykkRBTN";
            this.plykkRBTN.Size = new System.Drawing.Size(79, 17);
            this.plykkRBTN.TabIndex = 5;
            this.plykkRBTN.Text = "King Knight";
            this.plykkRBTN.UseVisualStyleBackColor = true;
            this.plykkRBTN.CheckedChanged += new System.EventHandler(this.plykkRBTN_CheckedChanged);
            // 
            // saveslotGB
            // 
            this.saveslotGB.Controls.Add(this.savefileLB);
            this.saveslotGB.Enabled = false;
            this.saveslotGB.Location = new System.Drawing.Point(12, 143);
            this.saveslotGB.Name = "saveslotGB";
            this.saveslotGB.Size = new System.Drawing.Size(140, 299);
            this.saveslotGB.TabIndex = 3;
            this.saveslotGB.TabStop = false;
            this.saveslotGB.Text = "Save Slots:";
            // 
            // plynameTB
            // 
            this.plynameTB.Location = new System.Drawing.Point(9, 32);
            this.plynameTB.Name = "plynameTB";
            this.plynameTB.Size = new System.Drawing.Size(125, 20);
            this.plynameTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player Name:";
            // 
            // plymoneyNUD
            // 
            this.plymoneyNUD.Location = new System.Drawing.Point(8, 71);
            this.plymoneyNUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.plymoneyNUD.Name = "plymoneyNUD";
            this.plymoneyNUD.Size = new System.Drawing.Size(126, 20);
            this.plymoneyNUD.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Money:";
            // 
            // subwCLB
            // 
            this.subwCLB.FormattingEnabled = true;
            this.subwCLB.Items.AddRange(new object[] {
            "Sub Weapon 1",
            "Sub Weapon 2",
            "Sub Weapon 3",
            "Sub Weapon 4",
            "Sub Weapon 5",
            "Sub Weapon 6",
            "Sub Weapon 7",
            "Sub Weapon 8",
            "Sub Weapon 9",
            "Sub Weapon 10",
            "Sub Weapon 11",
            "Sub Weapon 12"});
            this.subwCLB.Location = new System.Drawing.Point(6, 39);
            this.subwCLB.Name = "subwCLB";
            this.subwCLB.Size = new System.Drawing.Size(120, 184);
            this.subwCLB.TabIndex = 11;
            this.subwCLB.SelectedIndexChanged += new System.EventHandler(this.subwCLB_SelectedIndexChanged);
            // 
            // subwGB
            // 
            this.subwGB.Controls.Add(this.subwallCB);
            this.subwGB.Controls.Add(this.subwCLB);
            this.subwGB.Enabled = false;
            this.subwGB.Location = new System.Drawing.Point(304, 27);
            this.subwGB.Name = "subwGB";
            this.subwGB.Size = new System.Drawing.Size(133, 230);
            this.subwGB.TabIndex = 4;
            this.subwGB.TabStop = false;
            this.subwGB.Text = "Sub Weapons:";
            // 
            // subwallCB
            // 
            this.subwallCB.AutoSize = true;
            this.subwallCB.Location = new System.Drawing.Point(6, 16);
            this.subwallCB.Name = "subwallCB";
            this.subwallCB.Size = new System.Drawing.Size(37, 17);
            this.subwallCB.TabIndex = 11;
            this.subwallCB.Text = "All";
            this.subwallCB.UseVisualStyleBackColor = true;
            this.subwallCB.CheckedChanged += new System.EventHandler(this.subwallCB_CheckedChanged);
            // 
            // subwupgradeCLB
            // 
            this.subwupgradeCLB.FormattingEnabled = true;
            this.subwupgradeCLB.Items.AddRange(new object[] {
            "Sub Weapon 1",
            "Sub Weapon 2",
            "Sub Weapon 3",
            "Sub Weapon 4",
            "Sub Weapon 5",
            "Sub Weapon 6",
            "Sub Weapon 7",
            "Sub Weapon 8",
            "Sub Weapon 9",
            "Sub Weapon 10",
            "Sub Weapon 11",
            "Sub Weapon 12"});
            this.subwupgradeCLB.Location = new System.Drawing.Point(6, 39);
            this.subwupgradeCLB.Name = "subwupgradeCLB";
            this.subwupgradeCLB.Size = new System.Drawing.Size(120, 184);
            this.subwupgradeCLB.TabIndex = 12;
            // 
            // subwupgradeallCB
            // 
            this.subwupgradeallCB.AutoSize = true;
            this.subwupgradeallCB.Location = new System.Drawing.Point(6, 16);
            this.subwupgradeallCB.Name = "subwupgradeallCB";
            this.subwupgradeallCB.Size = new System.Drawing.Size(37, 17);
            this.subwupgradeallCB.TabIndex = 12;
            this.subwupgradeallCB.Text = "All";
            this.subwupgradeallCB.UseVisualStyleBackColor = true;
            this.subwupgradeallCB.CheckedChanged += new System.EventHandler(this.subwupgradeallCB_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsfileBTN,
            this.toolStripSeparator1,
            this.tssavefiletypeBNT,
            this.tshelpaboutBTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // infoGB
            // 
            this.infoGB.Controls.Add(this.armorCB);
            this.infoGB.Controls.Add(this.label3);
            this.infoGB.Controls.Add(this.ngpCB);
            this.infoGB.Controls.Add(this.plymagicNUD);
            this.infoGB.Controls.Add(this.magicLabel);
            this.infoGB.Controls.Add(this.plyhealthNUD);
            this.infoGB.Controls.Add(this.healthLabel);
            this.infoGB.Controls.Add(this.label1);
            this.infoGB.Controls.Add(this.label2);
            this.infoGB.Controls.Add(this.plynameTB);
            this.infoGB.Controls.Add(this.plymoneyNUD);
            this.infoGB.Enabled = false;
            this.infoGB.Location = new System.Drawing.Point(158, 27);
            this.infoGB.Name = "infoGB";
            this.infoGB.Size = new System.Drawing.Size(140, 411);
            this.infoGB.TabIndex = 6;
            this.infoGB.TabStop = false;
            this.infoGB.Text = "Info:";
            // 
            // tssavefiletypeBNT
            // 
            this.tssavefiletypeBNT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssavefiletypeBNT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steamToolStripMenuItem,
            this.nintendoToolStripMenuItem,
            this.xboxToolStripMenuItem,
            this.playstationToolStripMenuItem});
            this.tssavefiletypeBNT.Image = ((System.Drawing.Image)(resources.GetObject("tssavefiletypeBNT.Image")));
            this.tssavefiletypeBNT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssavefiletypeBNT.Name = "tssavefiletypeBNT";
            this.tssavefiletypeBNT.Size = new System.Drawing.Size(92, 22);
            this.tssavefiletypeBNT.Text = "Save File Type";
            // 
            // steamToolStripMenuItem
            // 
            this.steamToolStripMenuItem.Checked = true;
            this.steamToolStripMenuItem.CheckOnClick = true;
            this.steamToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.steamToolStripMenuItem.Name = "steamToolStripMenuItem";
            this.steamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.steamToolStripMenuItem.Text = "Steam";
            // 
            // nintendoToolStripMenuItem
            // 
            this.nintendoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dSToolStripMenuItem,
            this.wiiUToolStripMenuItem,
            this.switchToolStripMenuItem});
            this.nintendoToolStripMenuItem.Enabled = false;
            this.nintendoToolStripMenuItem.Name = "nintendoToolStripMenuItem";
            this.nintendoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nintendoToolStripMenuItem.Text = "Nintendo";
            // 
            // dSToolStripMenuItem
            // 
            this.dSToolStripMenuItem.Name = "dSToolStripMenuItem";
            this.dSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dSToolStripMenuItem.Text = "3DS";
            // 
            // wiiUToolStripMenuItem
            // 
            this.wiiUToolStripMenuItem.Name = "wiiUToolStripMenuItem";
            this.wiiUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wiiUToolStripMenuItem.Text = "Wii U";
            // 
            // switchToolStripMenuItem
            // 
            this.switchToolStripMenuItem.Name = "switchToolStripMenuItem";
            this.switchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.switchToolStripMenuItem.Text = "Switch";
            // 
            // xboxToolStripMenuItem
            // 
            this.xboxToolStripMenuItem.Enabled = false;
            this.xboxToolStripMenuItem.Name = "xboxToolStripMenuItem";
            this.xboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xboxToolStripMenuItem.Text = "Xbox";
            // 
            // playstationToolStripMenuItem
            // 
            this.playstationToolStripMenuItem.Enabled = false;
            this.playstationToolStripMenuItem.Name = "playstationToolStripMenuItem";
            this.playstationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playstationToolStripMenuItem.Text = "Playstation";
            // 
            // tsfileBTN
            // 
            this.tsfileBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsfileBTN.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localFilesToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.toolStripSeparator2,
            this.overwriteToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.tsfileBTN.Image = ((System.Drawing.Image)(resources.GetObject("tsfileBTN.Image")));
            this.tsfileBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsfileBTN.Name = "tsfileBTN";
            this.tsfileBTN.Size = new System.Drawing.Size(38, 22);
            this.tsfileBTN.Text = "File";
            // 
            // localFilesToolStripMenuItem
            // 
            this.localFilesToolStripMenuItem.Name = "localFilesToolStripMenuItem";
            this.localFilesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.localFilesToolStripMenuItem.Text = "Open from Local Files";
            this.localFilesToolStripMenuItem.ToolTipText = "Opens from Roaming/Yacht Club Games/";
            this.localFilesToolStripMenuItem.Click += new System.EventHandler(this.localFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // overwriteToolStripMenuItem
            // 
            this.overwriteToolStripMenuItem.Enabled = false;
            this.overwriteToolStripMenuItem.Name = "overwriteToolStripMenuItem";
            this.overwriteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.overwriteToolStripMenuItem.Text = "Overwrite";
            this.overwriteToolStripMenuItem.Click += new System.EventHandler(this.overwriteToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.otherToolStripMenuItem.Text = "Other...";
            this.otherToolStripMenuItem.ToolTipText = "Opens a Dialogue Box";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(6, 94);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(90, 13);
            this.healthLabel.TabIndex = 6;
            this.healthLabel.Text = "Health Upgrades:";
            // 
            // plyhealthNUD
            // 
            this.plyhealthNUD.Location = new System.Drawing.Point(8, 110);
            this.plyhealthNUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.plyhealthNUD.Name = "plyhealthNUD";
            this.plyhealthNUD.Size = new System.Drawing.Size(126, 20);
            this.plyhealthNUD.TabIndex = 7;
            // 
            // plymagicNUD
            // 
            this.plymagicNUD.Location = new System.Drawing.Point(8, 149);
            this.plymagicNUD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.plymagicNUD.Name = "plymagicNUD";
            this.plymagicNUD.Size = new System.Drawing.Size(126, 20);
            this.plymagicNUD.TabIndex = 9;
            // 
            // magicLabel
            // 
            this.magicLabel.AutoSize = true;
            this.magicLabel.Location = new System.Drawing.Point(6, 133);
            this.magicLabel.Name = "magicLabel";
            this.magicLabel.Size = new System.Drawing.Size(88, 13);
            this.magicLabel.TabIndex = 8;
            this.magicLabel.Text = "Magic Upgrades:";
            // 
            // ngpCB
            // 
            this.ngpCB.AutoSize = true;
            this.ngpCB.Location = new System.Drawing.Point(9, 182);
            this.ngpCB.Name = "ngpCB";
            this.ngpCB.Size = new System.Drawing.Size(96, 17);
            this.ngpCB.TabIndex = 8;
            this.ngpCB.Text = "Is New Game+";
            this.ngpCB.UseVisualStyleBackColor = true;
            // 
            // upgradesGB
            // 
            this.upgradesGB.Controls.Add(this.subwupgradeCLB);
            this.upgradesGB.Controls.Add(this.subwupgradeallCB);
            this.upgradesGB.Enabled = false;
            this.upgradesGB.Location = new System.Drawing.Point(443, 27);
            this.upgradesGB.Name = "upgradesGB";
            this.upgradesGB.Size = new System.Drawing.Size(133, 230);
            this.upgradesGB.TabIndex = 13;
            this.upgradesGB.TabStop = false;
            this.upgradesGB.Text = "Upgrades";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(672, 428);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Created by: Beta Angel";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // savefileLB
            // 
            this.savefileLB.FormattingEnabled = true;
            this.savefileLB.Items.AddRange(new object[] {
            "1: No Save Loaded",
            "2: No Save Loaded",
            "3: No Save Loaded",
            "4: No Save Loaded",
            "5: No Save Loaded",
            "6: No Save Loaded",
            "7: No Save Loaded",
            "8: No Save Loaded",
            "9: No Save Loaded",
            "10: No Save Loaded",
            "11: No Save Loaded",
            "12: No Save Loaded",
            "13: No Save Loaded",
            "14: No Save Loaded",
            "15: No Save Loaded",
            "16: No Save Loaded",
            "17: No Save Loaded",
            "18: No Save Loaded",
            "19: No Save Loaded",
            "20: No Save Loaded"});
            this.savefileLB.Location = new System.Drawing.Point(6, 17);
            this.savefileLB.Name = "savefileLB";
            this.savefileLB.Size = new System.Drawing.Size(128, 264);
            this.savefileLB.TabIndex = 17;
            this.savefileLB.SelectedIndexChanged += new System.EventHandler(this.savefileLB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Current Armor:";
            // 
            // armorCB
            // 
            this.armorCB.FormattingEnabled = true;
            this.armorCB.Items.AddRange(new object[] {
            "Armor Set 1",
            "Armor Set 2",
            "Armor Set 3",
            "Armor Set 4",
            "Armor Set 5",
            "Armor Set 6",
            "Armor Set 7"});
            this.armorCB.Location = new System.Drawing.Point(9, 218);
            this.armorCB.Name = "armorCB";
            this.armorCB.Size = new System.Drawing.Size(120, 95);
            this.armorCB.TabIndex = 16;
            // 
            // tshelpaboutBTN
            // 
            this.tshelpaboutBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tshelpaboutBTN.Image = ((System.Drawing.Image)(resources.GetObject("tshelpaboutBTN.Image")));
            this.tshelpaboutBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tshelpaboutBTN.Name = "tshelpaboutBTN";
            this.tshelpaboutBTN.Size = new System.Drawing.Size(74, 22);
            this.tshelpaboutBTN.Text = "Help/About";
            this.tshelpaboutBTN.Click += new System.EventHandler(this.tshelpaboutBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.upgradesGB);
            this.Controls.Add(this.infoGB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.subwGB);
            this.Controls.Add(this.saveslotGB);
            this.Controls.Add(this.playertypeGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Save Shoveler 0.6.84 - 4.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.playertypeGB.ResumeLayout(false);
            this.playertypeGB.PerformLayout();
            this.saveslotGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plymoneyNUD)).EndInit();
            this.subwGB.ResumeLayout(false);
            this.subwGB.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.infoGB.ResumeLayout(false);
            this.infoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plyhealthNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plymagicNUD)).EndInit();
            this.upgradesGB.ResumeLayout(false);
            this.upgradesGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton plyskRBTN;
        private System.Windows.Forms.GroupBox playertypeGB;
        private System.Windows.Forms.RadioButton plykkRBTN;
        private System.Windows.Forms.RadioButton plysrRBTN;
        private System.Windows.Forms.RadioButton plypkRBTN;
        private System.Windows.Forms.GroupBox saveslotGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown plymoneyNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plynameTB;
        private System.Windows.Forms.CheckedListBox subwCLB;
        private System.Windows.Forms.GroupBox subwGB;
        private System.Windows.Forms.CheckBox subwallCB;
        private System.Windows.Forms.CheckBox subwupgradeallCB;
        private System.Windows.Forms.CheckedListBox subwupgradeCLB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox infoGB;
        private System.Windows.Forms.ToolStripDropDownButton tssavefiletypeBNT;
        private System.Windows.Forms.ToolStripMenuItem steamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nintendoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wiiUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem switchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playstationToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton tsfileBTN;
        private System.Windows.Forms.ToolStripMenuItem localFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem overwriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown plymagicNUD;
        private System.Windows.Forms.Label magicLabel;
        private System.Windows.Forms.NumericUpDown plyhealthNUD;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.CheckBox ngpCB;
        private System.Windows.Forms.GroupBox upgradesGB;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox savefileLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox armorCB;
        private System.Windows.Forms.ToolStripButton tshelpaboutBTN;
    }
}

