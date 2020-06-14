namespace Shovel_Knight_Save_Editor
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.aboutTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aboutTB
            // 
            this.aboutTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutTB.Location = new System.Drawing.Point(0, 0);
            this.aboutTB.Multiline = true;
            this.aboutTB.Name = "aboutTB";
            this.aboutTB.ReadOnly = true;
            this.aboutTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.aboutTB.Size = new System.Drawing.Size(315, 242);
            this.aboutTB.TabIndex = 0;
            this.aboutTB.Text = resources.GetString("aboutTB.Text");
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 242);
            this.Controls.Add(this.aboutTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "about";
            this.Text = "Save Shoveler - About";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aboutTB;
    }
}