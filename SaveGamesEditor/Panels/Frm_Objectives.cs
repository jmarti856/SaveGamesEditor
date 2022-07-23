using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Objectives : DockContent
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_Objectives()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ListView_Objectives_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListView_Objectives.SelectedItems.Count > 0)
            {
                EditSelectedItems();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  CONTEXT MENU
        //-------------------------------------------------------------------------------------------
        private void MenuItem_CopyLabel_Click(object sender, EventArgs e)
        {
            if (ListView_Objectives.SelectedItems.Count == 1)
            {
                Clipboard.SetText(ListView_Objectives.SelectedItems[0].Text);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_CopyHashCode_Click(object sender, EventArgs e)
        {
            if (ListView_Objectives.SelectedItems.Count == 1)
            {
                Clipboard.SetText(ListView_Objectives.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_CopyValue_Click(object sender, EventArgs e)
        {
            if (ListView_Objectives.SelectedItems.Count == 1)
            {
                Clipboard.SetText(ListView_Objectives.SelectedItems[0].SubItems[2].Text);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_EditValue_Click(object sender, EventArgs e)
        {
            if (ListView_Objectives.SelectedItems.Count > 0)
            {
                EditSelectedItems();
            }
        }

        //-------------------------------------------------------------------------------------------
        //  METHODS
        //-------------------------------------------------------------------------------------------
        public void ShowData(SphinxSaveGame fileLoadedData)
        {
            //Ensure that we have readed a save file
            if (fileLoadedData != null)
            {
                //Clear control if required
                if (ListView_Objectives.Items.Count > 0)
                {
                    ListView_Objectives.Items.Clear();
                }

                //Get objectives
                Dictionary<uint, string> hashcodesLabels = HashTables.ReadSectionKeyHexAndLabel(@"S:\Sphinx\Project\hashcodes.h", "HT_Objective");

                //Display Objectives
                ListView_Objectives.BeginUpdate();
                for (int i = 0; i < fileLoadedData.Objectives.Length; i++)
                {
                    Objective currentObjective = fileLoadedData.Objectives[i];
                    if (currentObjective != null)
                    {
                        //Get label
                        string hashcodeLabel = "Hashcode Not Found";
                        if (hashcodesLabels.ContainsKey(currentObjective.HashCode))
                        {
                            hashcodeLabel = hashcodesLabels[currentObjective.HashCode];
                        }

                        //Add item
                        ListViewItem item = new ListViewItem(new[] { hashcodeLabel, "0x" + currentObjective.HashCode.ToString("X8"), currentObjective.Value.ToString() });
                        ListView_Objectives.Items.Add(item);
                    }
                }
                ListView_Objectives.EndUpdate();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void EditSelectedItems()
        {
            using (Frm_ModifyObjectives itemsEditor = new Frm_ModifyObjectives(uint.Parse(ListView_Objectives.SelectedItems[0].SubItems[2].Text)))
            {
                //Update texts
                itemsEditor.Textbox_HashCode.Text = ListView_Objectives.SelectedItems[0].Text;
                if (ListView_Objectives.SelectedItems.Count > 1)
                {
                    itemsEditor.Textbox_HashCode.Text = "<Multiple Objective Properties>";
                }

                //Update items
                if (itemsEditor.ShowDialog() == DialogResult.OK)
                {
                    foreach (ListViewItem currentItem in ListView_Objectives.SelectedItems)
                    {
                        currentItem.SubItems[2].Text = itemsEditor.Numeric_CurrentCount.Value.ToString();
                    }
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
