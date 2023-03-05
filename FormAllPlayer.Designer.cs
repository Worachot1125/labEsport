namespace CISESPORT
{
    partial class FormAllPlayer
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
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            newPlayerToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnLastname = new DataGridViewTextBoxColumn();
            ColumnMajor = new DataGridViewTextBoxColumn();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnDisplay = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnPhone = new DataGridViewTextBoxColumn();
            ColumnAge = new DataGridViewTextBoxColumn();
            label4 = new Label();
            tbMajor = new TextBox();
            label2 = new Label();
            tbLastName = new TextBox();
            label1 = new Label();
            tbName = new TextBox();
            label3 = new Label();
            tbID = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1305, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveFileToolStripMenuItem, openFileToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(155, 26);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(155, 26);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(155, 26);
            closeToolStripMenuItem.Text = "Close";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newPlayerToolStripMenuItem });
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(79, 24);
            playerToolStripMenuItem.Text = "Member";
            // 
            // newPlayerToolStripMenuItem
            // 
            newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            newPlayerToolStripMenuItem.Size = new Size(224, 26);
            newPlayerToolStripMenuItem.Text = "New Player";
            newPlayerToolStripMenuItem.Click += newPlayerToolStripMenuItem_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnLastname, ColumnMajor, ColumnID, ColumnDisplay, ColumnEmail, ColumnPhone, ColumnAge });
            dataGridView1.Location = new Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1023, 439);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "Name";
            ColumnName.HeaderText = "Name";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 125;
            // 
            // ColumnLastname
            // 
            ColumnLastname.DataPropertyName = "Lastname";
            ColumnLastname.HeaderText = "Lastname";
            ColumnLastname.MinimumWidth = 6;
            ColumnLastname.Name = "ColumnLastname";
            ColumnLastname.ReadOnly = true;
            ColumnLastname.Width = 125;
            // 
            // ColumnMajor
            // 
            ColumnMajor.DataPropertyName = "Major";
            ColumnMajor.HeaderText = "Major";
            ColumnMajor.MinimumWidth = 6;
            ColumnMajor.Name = "ColumnMajor";
            ColumnMajor.ReadOnly = true;
            ColumnMajor.Width = 125;
            // 
            // ColumnID
            // 
            ColumnID.DataPropertyName = "ID";
            ColumnID.HeaderText = "ID";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Width = 125;
            // 
            // ColumnDisplay
            // 
            ColumnDisplay.DataPropertyName = "Displayname";
            ColumnDisplay.HeaderText = "Displayname";
            ColumnDisplay.MinimumWidth = 6;
            ColumnDisplay.Name = "ColumnDisplay";
            ColumnDisplay.ReadOnly = true;
            ColumnDisplay.Width = 125;
            // 
            // ColumnEmail
            // 
            ColumnEmail.DataPropertyName = "Email";
            ColumnEmail.HeaderText = "Email";
            ColumnEmail.MinimumWidth = 6;
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.ReadOnly = true;
            ColumnEmail.Width = 125;
            // 
            // ColumnPhone
            // 
            ColumnPhone.DataPropertyName = "Phone";
            ColumnPhone.HeaderText = "Phone";
            ColumnPhone.MinimumWidth = 6;
            ColumnPhone.Name = "ColumnPhone";
            ColumnPhone.ReadOnly = true;
            ColumnPhone.Width = 125;
            // 
            // ColumnAge
            // 
            ColumnAge.DataPropertyName = "Age";
            ColumnAge.HeaderText = "Age";
            ColumnAge.MinimumWidth = 6;
            ColumnAge.Name = "ColumnAge";
            ColumnAge.ReadOnly = true;
            ColumnAge.Width = 125;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(1080, 153);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 23;
            label4.Text = "สาขา";
            // 
            // tbMajor
            // 
            tbMajor.Location = new Point(1136, 150);
            tbMajor.Name = "tbMajor";
            tbMajor.Size = new Size(125, 27);
            tbMajor.TabIndex = 19;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1065, 86);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 22;
            label2.Text = "นามสกุล";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(1136, 83);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(125, 27);
            tbLastName.TabIndex = 17;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1092, 53);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 21;
            label1.Text = "ชื่อ";
            // 
            // tbName
            // 
            tbName.Location = new Point(1136, 50);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 16;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(1040, 121);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 20;
            label3.Text = "รหัสนักศึกษา";
            // 
            // tbID
            // 
            tbID.Location = new Point(1136, 117);
            tbID.Name = "tbID";
            tbID.Size = new Size(125, 27);
            tbID.TabIndex = 18;
            // 
            // FormAllPlayer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 482);
            Controls.Add(label4);
            Controls.Add(tbMajor);
            Controls.Add(label2);
            Controls.Add(tbLastName);
            Controls.Add(label1);
            Controls.Add(tbName);
            Controls.Add(label3);
            Controls.Add(tbID);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormAllPlayer";
            Text = "FormAllPlayer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnLastname;
        private DataGridViewTextBoxColumn ColumnMajor;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnDisplay;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnPhone;
        private DataGridViewTextBoxColumn ColumnAge;
        private Label label4;
        private TextBox tbMajor;
        private Label label2;
        private TextBox tbLastName;
        private Label label1;
        private TextBox tbName;
        private Label label3;
        private TextBox tbID;
    }
}