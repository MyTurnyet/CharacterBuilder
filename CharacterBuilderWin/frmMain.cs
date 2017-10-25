using System;
using System.Windows.Forms;
using Characters;
using Characters.Classes;
using Characters.Races;

namespace CharacterBuilderWin
{
    public partial class FrmMain : Form
    {
        private readonly ICharacterBuilderFacilitator _facilitator;

        public FrmMain(ICharacterBuilderFacilitator facilitator)
        {
            _facilitator = facilitator;
        }

        public FrmMain():this(new CharacterBuilderFacilitator(new CharacterSheet(new Fighter(), new WoodElf())))
        {
            InitializeComponent();
        }

        public void UpdateOutputText()
        {
            
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
