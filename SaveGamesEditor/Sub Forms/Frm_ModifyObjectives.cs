﻿using System.Windows.Forms;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_ModifyObjectives : Form
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_ModifyObjectives(uint currentCount)
        {
            InitializeComponent();
            Numeric_CurrentCount.Value = currentCount;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
