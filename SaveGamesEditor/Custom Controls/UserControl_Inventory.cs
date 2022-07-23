using System;
using System.Media;
using System.Windows.Forms;

namespace SaveGamesEditor.Custom_Controls
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class UserControl_Inventory : UserControl
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        public UserControl_Inventory()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_CopyLabel_Click(object sender, EventArgs e)
        {
            if (ListView_Inventory.SelectedItems.Count == 1)
            {
                Clipboard.SetText(ListView_Inventory.SelectedItems[0].Text);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_CopyHashCode_Click(object sender, EventArgs e)
        {
            if (ListView_Inventory.SelectedItems.Count == 1)
            {
                Clipboard.SetText(ListView_Inventory.SelectedItems[0].SubItems[1].Text);
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_EditValues_Click(object sender, EventArgs e)
        {
            EditSelectedItems();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ListView_Inventory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ListView_Inventory.SelectedItems.Count == 1)
            {
                EditSelectedItems();
            }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void EditSelectedItems()
        {
            if (ListView_Inventory.Items.Count > 0)
            {
                using (Frm_ModifyInventoryItem itemsEditor = new Frm_ModifyInventoryItem(int.Parse(ListView_Inventory.SelectedItems[0].SubItems[2].Text), int.Parse(ListView_Inventory.SelectedItems[0].SubItems[3].Text), uint.Parse(ListView_Inventory.SelectedItems[0].SubItems[4].Text)))
                {
                    //Update texts
                    itemsEditor.Textbox_HashCode.Text = ListView_Inventory.SelectedItems[0].Text;
                    if (ListView_Inventory.SelectedItems.Count > 1)
                    {
                        itemsEditor.Textbox_HashCode.Text = "<Multiple Item Properties>";
                    }

                    //Update items
                    if (itemsEditor.ShowDialog() == DialogResult.OK)
                    {
                        foreach (ListViewItem currentItem in ListView_Inventory.SelectedItems)
                        {
                            currentItem.SubItems[2].Text = itemsEditor.Numeric_CurrentCount.Value.ToString();
                            currentItem.SubItems[3].Text = itemsEditor.Numeric_MaxCount.Value.ToString();
                            currentItem.SubItems[4].Text = itemsEditor.Textbox_Flags.Text;
                        }
                    }
                }
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
