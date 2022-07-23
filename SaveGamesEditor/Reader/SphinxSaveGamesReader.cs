using System;
using System.IO;

namespace SaveGamesEditor.Reader
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    internal class SphinxSaveGamesReader
    {
        internal SphinxSaveGame ReadFile(string filePath)
        {
            SphinxSaveGame saveGameData = new SphinxSaveGame();
            using (BinaryReader BReader = new BinaryReader(File.OpenRead(filePath)))
            {
                ReadHeader(BReader, saveGameData);
                ReadNotes(BReader, 0x40, saveGameData.Notes_sphinx);
                ReadNotes(BReader, 0x98, saveGameData.Notes_mummy);

                ReadObjectives(BReader, saveGameData);

                ReadInventoryData(BReader, 0x3630, saveGameData.DartItemsSphinx);
                ReadInventoryData(BReader, 0x3EF8, saveGameData.QuestItemsSphinx);
                ReadInventoryData(BReader, 0x47C0, saveGameData.AbilityItemsSphinx);
                ReadInventoryData(BReader, 0x5088, saveGameData.AbilityPossession);
                ReadInventoryData(BReader, 0x5950, saveGameData.AbilityKa);
                ReadInventoryData(BReader, 0x73BC, saveGameData.MummyInventory);
            }

            return saveGameData;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadHeader(BinaryReader BReader, SphinxSaveGame saveGameData)
        {
            BReader.BaseStream.Seek(0, SeekOrigin.Begin);
            saveGameData.FileHeader.Version = BReader.ReadUInt32();
            saveGameData.FileHeader.VersionAgain = BReader.ReadUInt32();

            saveGameData.FileHeader.Time_sec = BReader.ReadUInt32();
            saveGameData.FileHeader.Scarabs = BReader.ReadUInt16();
            saveGameData.FileHeader.Health_ankhs = BReader.ReadUInt16();
            saveGameData.FileHeader.Crowns = BReader.ReadUInt16();

            BReader.BaseStream.Seek(0x24, SeekOrigin.Begin);
            saveGameData.Cur_map_hashcode = BReader.ReadUInt32();
            saveGameData.Cur_map_entrypoint = BReader.ReadUInt32();
            saveGameData.Cur_map_restard_id = BReader.ReadInt32();
            saveGameData.Cur_map_timer = BReader.ReadUInt32();

            BReader.BaseStream.Seek(0x3610, SeekOrigin.Begin);
            saveGameData.FileHeader.Health_thirds = BReader.ReadUInt32();
            saveGameData.FileHeader.Total_health_thirds = BReader.ReadUInt32();

            BReader.BaseStream.Seek(0xBCC4, SeekOrigin.Begin);
            saveGameData.sphinx_prog_buttons[0] = BReader.ReadUInt32();
            saveGameData.sphinx_prog_buttons[1] = BReader.ReadUInt32();
            saveGameData.sphinx_prog_buttons[2] = BReader.ReadUInt32();
            saveGameData.sphinx_prog_buttons[3] = BReader.ReadUInt32();

            //saveGameData.mummy_prog_buttons[0] = BReader.ReadUInt32();
            //saveGameData.mummy_prog_buttons[1] = BReader.ReadUInt32();
            //saveGameData.mummy_prog_buttons[2] = BReader.ReadUInt32();
            //saveGameData.mummy_prog_buttons[3] = BReader.ReadUInt32();
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadObjectives(BinaryReader BReader, SphinxSaveGame saveGameData)
        {
            //Seek offset
            BReader.BaseStream.Seek(0xEC, SeekOrigin.Begin);

            //Get number of stored objectives
            int storedObjectives = Math.Min(1700, BReader.ReadInt32());

            //Iterate over all saved objectives
            for (int i = 0; i < storedObjectives; i++)
            {
                //Get stored data
                Objective ObjectiveData = new Objective
                {
                    HashCode = BReader.ReadUInt32(),
                    Value = BReader.ReadUInt32()
                };

                //Save Data
                saveGameData.Objectives[i] = ObjectiveData;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadNotes(BinaryReader BReader, long startOffset, InventoryNote[] notesArray)
        {
            //Seek offset
            BReader.BaseStream.Seek(startOffset, SeekOrigin.Begin);

            //Iterate over all saved notes
            for (int i = 0; i < notesArray.Length; i++)
            {
                //Save Data
                InventoryNote noteData = new InventoryNote
                {
                    title_hashcode = BReader.ReadUInt32(),
                    desc_hashcode = BReader.ReadUInt32()
                };
                notesArray[i] = noteData;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void ReadInventoryData(BinaryReader BReader, long startOffset, InventoryItem[] containerList)
        {
            BReader.BaseStream.Seek(startOffset, SeekOrigin.Begin);

            //Get number of stored objectives
            int storedItems = BReader.ReadInt32();

            //Iterate over all saved objectives
            for (int i = 0; i < storedItems; i++)
            {
                //Get stored data
                InventoryItem itemData = new InventoryItem
                {
                    HashCode = BReader.ReadUInt32(),
                    CurrentCount = BReader.ReadInt32(),
                    MaxCount = BReader.ReadInt32(),
                    Flags = BReader.ReadUInt32()
                };

                //Save Data
                containerList[i] = itemData;
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
