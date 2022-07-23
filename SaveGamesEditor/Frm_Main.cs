using SaveGamesEditor.Reader;
using SaveGamesEditor.Writer;
using System;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public partial class Frm_Main : Form
    {
        private string currentFilePath = string.Empty;
        SphinxSaveGame saveGameFile;

        //Declare Forms
        Frm_FileHeader saveGameFileHeader;
        Frm_Objectives saveGameObjectives;
        Frm_Notes saveGameNotes;
        Frm_Inventory saveGameInventory;
        Frm_Level saveGameLevel;
        Frm_Programmable saveGameProgrammableItems;

        //-------------------------------------------------------------------------------------------------------------------------------
        public Frm_Main()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;

                //Read Save Game File
                SphinxSaveGamesReader Reader = new SphinxSaveGamesReader();
                saveGameFile = Reader.ReadFile(currentFilePath);

                //Display Data
                saveGameFileHeader.ShowData(saveGameFile);
                saveGameObjectives.ShowData(saveGameFile);
                saveGameNotes.ShowData(saveGameFile);
                saveGameInventory.ShowData(saveGameFile);
                saveGameLevel.ShowData(saveGameFile);
                saveGameProgrammableItems.ShowData(saveGameFile);

                //Update title bar
                Text = string.Format("{0} - [{1}]", Application.ProductName, currentFilePath);
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_SaveFile_Click(object sender, EventArgs e)
        {
            //Clone file 
            SphinxSaveGame saveGameToWrite = new SphinxSaveGame
            {
                Notes_sphinx = (InventoryNote[])saveGameFile.Notes_sphinx.Clone(),
                Notes_mummy = (InventoryNote[])saveGameFile.Notes_mummy.Clone(),
                Objectives = (Objective[])saveGameFile.Objectives.Clone(),
                DartItemsSphinx = (InventoryItem[])saveGameFile.DartItemsSphinx.Clone(),
                QuestItemsSphinx = (InventoryItem[])saveGameFile.QuestItemsSphinx.Clone(),
                AbilityItemsSphinx = (InventoryItem[])saveGameFile.AbilityItemsSphinx.Clone(),
                AbilityPossession = (InventoryItem[])saveGameFile.AbilityPossession.Clone(),
                AbilityKa = (InventoryItem[])saveGameFile.AbilityKa.Clone(),
                MummyInventory = (InventoryItem[])saveGameFile.MummyInventory.Clone()
            };
            saveGameToWrite.FileHeader.Version = saveGameFile.FileHeader.Version;
            saveGameToWrite.FileHeader.VersionAgain = saveGameFile.FileHeader.VersionAgain;
            saveGameToWrite.FileHeader.Crowns = saveGameFile.FileHeader.Crowns;
            saveGameToWrite.FileHeader.Static_2500_b = saveGameFile.FileHeader.Static_2500_b;
            saveGameToWrite.FileHeader.Time_sec = saveGameFile.FileHeader.Time_sec;
            saveGameToWrite.Cur_map_hashcode = saveGameFile.Cur_map_hashcode;
            saveGameToWrite.Cur_map_entrypoint = saveGameFile.Cur_map_entrypoint;
            saveGameToWrite.FileHeader.Health_ankhs = saveGameFile.FileHeader.Health_ankhs;
            saveGameToWrite.FileHeader.Health_thirds = saveGameFile.FileHeader.Health_thirds;
            saveGameToWrite.FileHeader.Total_health_thirds = saveGameFile.FileHeader.Total_health_thirds;
            saveGameToWrite.sphinx_prog_buttons[0] = saveGameFile.sphinx_prog_buttons[0];
            saveGameToWrite.sphinx_prog_buttons[1] = saveGameFile.sphinx_prog_buttons[1];
            saveGameToWrite.sphinx_prog_buttons[2] = saveGameFile.sphinx_prog_buttons[2];
            saveGameToWrite.sphinx_prog_buttons[3] = saveGameFile.sphinx_prog_buttons[3];


            //Write file
            WriteSaveGameFile saveGameWriter = new WriteSaveGameFile();
            saveGameWriter.Write(@"C:\Users\Jordi Martinez\Downloads\test.save", saveGameToWrite);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Main_Shown(object sender, EventArgs e)
        {
            //Initialize forms
            saveGameFileHeader = new Frm_FileHeader();
            saveGameInventory = new Frm_Inventory();
            saveGameNotes = new Frm_Notes();
            saveGameLevel = new Frm_Level();
            saveGameProgrammableItems = new Frm_Programmable();
            saveGameObjectives = new Frm_Objectives();

            //Show & dock forms
            string userConfigFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Dock Settings.xml");
            DeserializeDockContent _deserializeDockContent = new DeserializeDockContent(DeserializeDockContent);
            if (File.Exists(userConfigFile))
            {
                dockPanel.LoadFromXml(userConfigFile, _deserializeDockContent);
            }
            else
            {
                userConfigFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Default Dock Settings.xml");
                if (File.Exists(userConfigFile))
                {
                    dockPanel.LoadFromXml(userConfigFile, _deserializeDockContent);
                }
            }

            //Update menus
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void UpdateWindowMenuChecks()
        {
            MenuItem_ShowFormHeader.Checked = !saveGameFileHeader.IsHidden;
            MenuItem_ShowFormObjective.Checked = !saveGameObjectives.IsHidden;
            MenuItem_ShowFormNotes.Checked = !saveGameNotes.IsHidden;
            MenuItem_Inventory.Checked = !saveGameInventory.IsHidden;
            MenuItem_Level.Checked = !saveGameLevel.IsHidden;
            MenuItem_ProgrammableItems.Checked = !saveGameProgrammableItems.IsHidden;
        }



        //-------------------------------------------------------------------------------------------------------------------------------
        private IDockContent DeserializeDockContent(string persistString)
        {
            if (persistString == typeof(Frm_FileHeader).ToString())
            {
                return saveGameFileHeader;
            }
            if (persistString == typeof(Frm_Objectives).ToString())
            {
                return saveGameObjectives;
            }
            if (persistString == typeof(Frm_Notes).ToString())
            {
                return saveGameNotes;
            }
            if (persistString == typeof(Frm_Inventory).ToString())
            {
                return saveGameInventory;
            }
            if (persistString == typeof(Frm_Level).ToString())
            {
                return saveGameLevel;
            }
            if (persistString == typeof(Frm_Programmable).ToString())
            {
                return saveGameProgrammableItems;
            }
            return null;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dock conifg
            string configFile = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Dock Settings.xml");
            dockPanel.SaveAsXml(configFile);
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Window_Popup(object sender, EventArgs e)
        {
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ShowFormHeader_Click(object sender, EventArgs e)
        {
            saveGameFileHeader.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ShowFormObjective_Click(object sender, EventArgs e)
        {
            saveGameObjectives.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ShowFormNotes_Click(object sender, EventArgs e)
        {
            saveGameNotes.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Inventory_Click(object sender, EventArgs e)
        {
            saveGameInventory.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_Level_Click(object sender, EventArgs e)
        {
            saveGameLevel.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void MenuItem_ProgrammableItems_Click(object sender, EventArgs e)
        {
            saveGameProgrammableItems.Show(dockPanel, DockState.Float);
            UpdateWindowMenuChecks();
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
