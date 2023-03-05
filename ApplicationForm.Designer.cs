namespace CISESPORT
{
    partial class ApplicationForm
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
            menuStrip1 = new MenuStrip();
            playerToolStripMenuItem = new ToolStripMenuItem();
            allPlayerToolStripMenuItem = new ToolStripMenuItem();
            teamToolStripMenuItem = new ToolStripMenuItem();
            listPlayerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { playerToolStripMenuItem, teamToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allPlayerToolStripMenuItem });
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(63, 24);
            playerToolStripMenuItem.Text = "Player";
            // 
            // allPlayerToolStripMenuItem
            // 
            allPlayerToolStripMenuItem.Name = "allPlayerToolStripMenuItem";
            allPlayerToolStripMenuItem.Size = new Size(154, 26);
            allPlayerToolStripMenuItem.Text = "All Player";
            allPlayerToolStripMenuItem.Click += allPlayerToolStripMenuItem_Click;
            // 
            // teamToolStripMenuItem
            // 
            teamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listPlayerToolStripMenuItem });
            teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            teamToolStripMenuItem.Size = new Size(59, 24);
            teamToolStripMenuItem.Text = "Team";
            // 
            // listPlayerToolStripMenuItem
            // 
            listPlayerToolStripMenuItem.Name = "listPlayerToolStripMenuItem";
            listPlayerToolStripMenuItem.Size = new Size(224, 26);
            listPlayerToolStripMenuItem.Text = "List Player";
            listPlayerToolStripMenuItem.Click += listPlayerToolStripMenuItem_Click;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ApplicationForm";
            Text = "ApplicationForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem allPlayerToolStripMenuItem;
        private ToolStripMenuItem teamToolStripMenuItem;
        private ToolStripMenuItem listPlayerToolStripMenuItem;
    }
}