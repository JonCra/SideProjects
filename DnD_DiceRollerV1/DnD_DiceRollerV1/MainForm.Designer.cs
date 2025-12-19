namespace DnD_DiceRollerV1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            diceRollerToolStripMenuItem = new ToolStripMenuItem();
            characterStatsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            CharacterButton = new Button();
            DiceRollButton = new Button();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { diceRollerToolStripMenuItem, characterStatsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // diceRollerToolStripMenuItem
            // 
            diceRollerToolStripMenuItem.Name = "diceRollerToolStripMenuItem";
            diceRollerToolStripMenuItem.Size = new Size(180, 22);
            diceRollerToolStripMenuItem.Text = "&Roll Dice";
            // 
            // characterStatsToolStripMenuItem
            // 
            characterStatsToolStripMenuItem.Name = "characterStatsToolStripMenuItem";
            characterStatsToolStripMenuItem.Size = new Size(180, 22);
            characterStatsToolStripMenuItem.Text = "&Character Sheet";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // CharacterButton
            // 
            CharacterButton.Location = new Point(501, 415);
            CharacterButton.Name = "CharacterButton";
            CharacterButton.Size = new Size(99, 23);
            CharacterButton.TabIndex = 3;
            CharacterButton.Text = "&Character Sheet";
            toolTip1.SetToolTip(CharacterButton, "Open Character Sheet menu");
            CharacterButton.UseVisualStyleBackColor = true;
            // 
            // DiceRollButton
            // 
            DiceRollButton.Location = new Point(639, 415);
            DiceRollButton.Name = "DiceRollButton";
            DiceRollButton.Size = new Size(75, 23);
            DiceRollButton.TabIndex = 4;
            DiceRollButton.Text = "&Roll Dice";
            toolTip1.SetToolTip(DiceRollButton, "Roll dice");
            DiceRollButton.UseVisualStyleBackColor = true;
            DiceRollButton.Click += DiceRollButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DiceRollButton);
            Controls.Add(CharacterButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dice Roller";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem diceRollerToolStripMenuItem;
        private ToolStripMenuItem characterStatsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button CharacterButton;
        private Button DiceRollButton;
        private ToolTip toolTip1;
    }
}