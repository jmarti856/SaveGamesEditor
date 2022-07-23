using System;
using System.Windows.Forms;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_BehaviourFlags : Form
    {
        private readonly uint checkedFlags;
        public uint CheckedFlagsResult { get; set; } = 0;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_BehaviourFlags(uint flags)
        {
            InitializeComponent();
            checkedFlags = flags;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_BehaviourFlags_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 32; i++)
            {
                if (Convert.ToBoolean((checkedFlags >> i) & 1))
                {
                    CheckListbox_Flags.SetItemChecked(i, true);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Button_OK_Click(object sender, EventArgs e)
        {
            CheckedFlagsResult = 0;
            for (int i = 0; i < 32; i++)
            {
                if (CheckListbox_Flags.GetItemChecked(i))
                {
#pragma warning disable CS0675 // Operador OR bit a bit utilizado en un operando de extensión de signo
                    CheckedFlagsResult = (uint)(CheckedFlagsResult | (1 << i));
#pragma warning restore CS0675 // Operador OR bit a bit utilizado en un operando de extensión de signo
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
