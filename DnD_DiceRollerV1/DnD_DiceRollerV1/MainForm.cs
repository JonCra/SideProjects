namespace DnD_DiceRollerV1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        // Program Logic -----------------
        private void SetDefaults()
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open "About" form
        }

        private void DiceRollButton_Click(object sender, EventArgs e)
        {
            // Roll dice based on modifiers and inputs
            // Only allow roll when character skills are populated; Redundantly display in text boxes

        }

        // Event Handlers ----------------
    }
}