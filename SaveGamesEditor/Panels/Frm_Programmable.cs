using System.Collections.Generic;
using System.Linq;
using WeifenLuo.WinFormsUI.Docking;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Programmable : DockContent
    {
        private Dictionary<uint, string> ItemsArray;
        private Dictionary<uint, string> FilesArray;

        //------------------------------------------------------------------------------------------------------------------------------
        public Frm_Programmable()
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
                LoadHashCodes();
                UserControl_Sphinx_ProgrammableLB.ComboBox_HashCodeLabel.SelectedValue = fileLoadedData.sphinx_prog_buttons[0];
                UserControl_Sphinx_ProgrammableLB.TextBox_HashCode.Text = "0x" + fileLoadedData.sphinx_prog_buttons[0].ToString("X8");

                UserControl_Sphinx_ProgrammableRB.ComboBox_HashCodeLabel.SelectedValue = fileLoadedData.sphinx_prog_buttons[1];
                UserControl_Sphinx_ProgrammableRB.TextBox_HashCode.Text = "0x" + fileLoadedData.sphinx_prog_buttons[1].ToString("X8");

                UserControl_Sphinx_ProgrammableY.ComboBox_HashCodeLabel.SelectedValue = fileLoadedData.sphinx_prog_buttons[3];
                UserControl_Sphinx_ProgrammableY.TextBox_HashCode.Text = "0x" + fileLoadedData.sphinx_prog_buttons[3].ToString("X8");
            }
        }

        //-------------------------------------------------------------------------------------------
        //  METHODS
        //-------------------------------------------------------------------------------------------
        private void LoadHashCodes()
        {
            // note you can also look at context etc to build list
            ItemsArray = HashTables.ReadSectionKeyHexAndLabel(@"S:\Sphinx\Project\hashcodes.h", "HT_Item_");
            FilesArray = HashTables.ReadSectionKeyHexAndLabel(@"S:\Sphinx\Project\hashcodes.h", "HT_File_");

            //Merge strings
            Dictionary<uint, string> merged = ItemsArray.Concat(FilesArray).ToLookup(x => x.Key, x => x.Value).ToDictionary(x => x.Key, g => g.First());

            //Add items to comboboxes
            UserControl_Sphinx_ProgrammableLB.SetDictionaryToCombobox(merged);
            UserControl_Sphinx_ProgrammableRB.SetDictionaryToCombobox(merged);
            UserControl_Sphinx_ProgrammableY.SetDictionaryToCombobox(merged);
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
