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
            RollButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // RollButton
            // 
            RollButton.Location = new Point(478, 387);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(75, 23);
            RollButton.TabIndex = 0;
            RollButton.Text = "Roll Dice";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(661, 387);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(RollButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dice Roller";
            ResumeLayout(false);
        }

        #endregion

        private Button RollButton;
        private Button ExitButton;
    }
}