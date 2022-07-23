using System.Collections.Generic;
using WeifenLuo.WinFormsUI.Docking;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Level : DockContent
    {
        private Dictionary<uint, string> FilesArray;

        //------------------------------------------------------------------------------------------------------------------------------
        public Frm_Level()
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
                UserControl_HashCodeSelector.ComboBox_HashCodeLabel.SelectedValue = fileLoadedData.Cur_map_hashcode;
                UserControl_HashCodeSelector.TextBox_HashCode.Text = "0x" + fileLoadedData.Cur_map_hashcode.ToString("X8");
                Numeric_Entrance.Value = fileLoadedData.Cur_map_entrypoint;
                Numeric_RestartID.Value = fileLoadedData.Cur_map_restard_id;
                Numeric_Timer.Value = fileLoadedData.Cur_map_timer;
            }
        }

        //-------------------------------------------------------------------------------------------
        //  METHODS
        //-------------------------------------------------------------------------------------------
        private void LoadHashCodes()
        {
            FilesArray = HashTables.ReadSectionKeyHexAndLabel(@"S:\Sphinx\Project\hashcodes.h", "HT_File_");

            //Add items to comboboxes
            UserControl_HashCodeSelector.SetDictionaryToCombobox(FilesArray);
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
