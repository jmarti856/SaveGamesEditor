using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Notes : DockContent
    {

        //------------------------------------------------------------------------------------------------------------------------------
        public Frm_Notes()
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
                Dictionary<uint, string> hashcodesLabels = HashTables.ReadSectionKeyHexAndLabel(@"S:\Sphinx\Project\hashcodes.h", "HT_Text");
                PrintNotes(ListView_SphinxNotes, fileLoadedData.Notes_sphinx, hashcodesLabels);
                PrintNotes(ListView_MummyNotes, fileLoadedData.Notes_mummy, hashcodesLabels);
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------
        private void PrintNotes(UserControl_NotesEditor listBoxControl, InventoryNote[] NotesToPrint, Dictionary<uint, string> hashcodesLabels)
        {
            //Clear control if required
            if (listBoxControl.ListView_Notes.Items.Count > 0)
            {
                listBoxControl.ListView_Notes.Items.Clear();
            }

            //Display Objectives
            listBoxControl.ListView_Notes.BeginUpdate();
            foreach(InventoryNote noteToPrint in NotesToPrint)
            {
                if (noteToPrint.title_hashcode != 0)
                {
                    //Get label
                    string hashcodeTitleLabel = "Hashcode Not Found";
                    string hashcodeDescLabel = "Hashcode Not Found";
                    if (hashcodesLabels.ContainsKey(noteToPrint.title_hashcode))
                    {
                        hashcodeTitleLabel = hashcodesLabels[noteToPrint.title_hashcode];
                    }
                    if (hashcodesLabels.ContainsKey(noteToPrint.desc_hashcode))
                    {
                        hashcodeDescLabel = hashcodesLabels[noteToPrint.desc_hashcode];
                    }

                    ListViewItem item = new ListViewItem(new[] { hashcodeTitleLabel, "0x"+noteToPrint.title_hashcode.ToString("X8"), hashcodeDescLabel, "0x" + noteToPrint.desc_hashcode.ToString("X8") });
                    listBoxControl.ListView_Notes.Items.Add(item);
                }
            }
            listBoxControl.ListView_Notes.EndUpdate();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
