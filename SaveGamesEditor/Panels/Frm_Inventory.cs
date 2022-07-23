using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Inventory : DockContent
    {
        //------------------------------------------------------------------------------------------------------------------------------
        public Frm_Inventory()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------
        //  METHODS
        //-------------------------------------------------------------------------------------------
        public void ShowData(SphinxSaveGame fileLoadedData)
        {
            //Ensure that we have readed a save file
            if (fileLoadedData != null)
            {
                //Get objectives
                Dictionary<uint, string> itemsHashCodes = HashTables.ReadSectionKeyHexAndLabel(@"S:\Sphinx\Project\hashcodes.h", "HT_Item_");
                Dictionary<uint, string> filesHashCodes = HashTables.ReadSectionKeyHexAndLabel(@"S:\Sphinx\Project\hashcodes.h", "HT_File_");

                //Print objectives
                PrintItemsToListView(UserControl_DartItems.ListView_Inventory, fileLoadedData.DartItemsSphinx, itemsHashCodes);
                PrintItemsToListView(UserControl_QuestItems.ListView_Inventory, fileLoadedData.QuestItemsSphinx, itemsHashCodes);
                PrintItemsToListView(UserControl_AbilityItems.ListView_Inventory, fileLoadedData.AbilityItemsSphinx, itemsHashCodes, filesHashCodes);
                PrintItemsToListView(UserControl_AbilityPossession.ListView_Inventory, fileLoadedData.AbilityPossession, itemsHashCodes, filesHashCodes);
                PrintItemsToListView(UserControl_AbilityKa.ListView_Inventory, fileLoadedData.AbilityKa, itemsHashCodes, filesHashCodes);
                PrintItemsToListView(UserControl_MummyInventory.ListView_Inventory, fileLoadedData.MummyInventory, itemsHashCodes, filesHashCodes);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void PrintItemsToListView(ListView ItemsControl, InventoryItem[] itemsToPrint, Dictionary<uint, string> hashcodesLabels, Dictionary<uint, string> filesHashCodes = null)
        {
            ItemsControl.BeginUpdate();

            //Clear current items
            if (ItemsControl.Items.Count > 0)
            {
                ItemsControl.Items.Clear();
            }

            //Add new items
            for (int i = 0; i < itemsToPrint.Length; i++)
            {
                if (itemsToPrint[i] != null)
                {
                    //Get label
                    string hashcodeLabel = "Hashcode Not Found";
                    if (hashcodesLabels.ContainsKey(itemsToPrint[i].HashCode))
                    {
                        hashcodeLabel = hashcodesLabels[itemsToPrint[i].HashCode];
                    }
                    else if (filesHashCodes != null)
                    {
                        if (filesHashCodes.ContainsKey(itemsToPrint[i].HashCode))
                        {
                            hashcodeLabel = filesHashCodes[itemsToPrint[i].HashCode];
                        }
                    }

                    //Add item
                    ListViewItem item = new ListViewItem(new[] { hashcodeLabel, "0x" + itemsToPrint[i].HashCode.ToString("X8"), itemsToPrint[i].CurrentCount.ToString(), itemsToPrint[i].MaxCount.ToString(), itemsToPrint[i].Flags.ToString() });
                    ItemsControl.Items.Add(item);
                }
            }
            ItemsControl.EndUpdate();
        }

    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
