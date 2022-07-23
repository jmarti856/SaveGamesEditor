using System;
using System.Windows.Forms;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_ModifyInventoryItem : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_ModifyInventoryItem(int currentCount, int maxCount, uint flags)
        {
            InitializeComponent();
            Numeric_CurrentCount.Value = currentCount;
            Numeric_MaxCount.Value = maxCount;
            Textbox_Flags.Text = flags.ToString();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Textbox_Flags_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(Textbox_Flags.Text, out uint n))
            {
                Frm_BehaviourFlags flagsForm = new Frm_BehaviourFlags(n);
                if (flagsForm.ShowDialog() == DialogResult.OK)
                {
                    Textbox_Flags.Text = flagsForm.CheckedFlagsResult.ToString();
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
