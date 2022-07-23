using System.IO;
using System.Text;

namespace SaveGamesEditor.Writer
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public class WriteSaveGameFile
    {
        //-------------------------------------------------------------------------------------------------------------------------------
        internal void Write(string filePath, SphinxSaveGame fileData)
        {
            using (BinaryWriter BWriter = new BinaryWriter(File.Open(filePath, FileMode.Create, FileAccess.Write, FileShare.Read)))
            {
                BWriter.Write(fileData.FileHeader.Version);
                BWriter.Write(fileData.FileHeader.VersionAgain);
                BWriter.Write(fileData.FileHeader.Crowns);
                BWriter.Write(fileData.FileHeader.Static_2500_b);
                BWriter.Write(fileData.FileHeader.Time_sec);
                BWriter.Write(fileData.FileHeader.Health_ankhs);
                BWriter.Write((ushort)0);
                BWriter.Write(Encoding.ASCII.GetBytes("SPHINX"));
                BWriter.Write(0);
                BWriter.Write(0);
                BWriter.Write(0xA8A80000);
                BWriter.Write(fileData.Cur_map_hashcode);
                BWriter.Write(fileData.Cur_map_entrypoint);
                BWriter.Write(-1);
                BWriter.Write(698);
                BWriter.Write((int)fileData.FileHeader.Time_sec);
                BWriter.Write(0xA8A8A8A8);
                BWriter.Write(0xA8A8A8A8);

                //Write Sphinx Notes
                for (int i = 0; i < fileData.Notes_sphinx.Length; i++)
                {
                    BWriter.Write(fileData.Notes_sphinx[i].title_hashcode);
                    BWriter.Write(fileData.Notes_sphinx[i].desc_hashcode);
                }

                //Write Mummy Notes
                BWriter.Write(0);
                BWriter.Write(0xA8A8A8A8);
                for (int i = 0; i < fileData.Notes_mummy.Length; i++)
                {
                    BWriter.Write(fileData.Notes_mummy[i].title_hashcode);
                    BWriter.Write(fileData.Notes_mummy[i].desc_hashcode);
                }

                //Write objectives
                BWriter.Write(0);
                BWriter.Write(fileData.Objectives.Length);
                for (int i = 0; i < fileData.Objectives.Length; i++)
                {
                    Objective currentObjective = fileData.Objectives[i];
                    if (currentObjective == null)
                    {
                        BWriter.Write(0);
                        BWriter.Write(0);
                    }
                    else
                    {
                        BWriter.Write(currentObjective.HashCode);
                        BWriter.Write(currentObjective.Value);
                    }
                }

                //Unknown Section
                for (int i = 0; i < 8; i++)
                {
                    BWriter.Write(0xDDDDDDDD);
                }

                //Write Darts
                WriteInventoryItems(BWriter, fileData.DartItemsSphinx);

                //Write Quest
                BWriter.Write(0xDDDDDDDD);
                WriteInventoryItems(BWriter, fileData.QuestItemsSphinx);

                //Write Ability
                BWriter.Write(0xDDDDDDDD);
                WriteInventoryItems(BWriter, fileData.AbilityItemsSphinx);

                //Write Ability Possession
                BWriter.Write(0xDDDDDDDD);
                WriteInventoryItems(BWriter, fileData.AbilityPossession);

                //Write Ability KA
                BWriter.Write(0xDDDDDDDD);
                WriteInventoryItems(BWriter, fileData.AbilityKa);

                //Write Empty section???
                for (int i = 0; i < 1124; i++)
                {
                    BWriter.Write(0xA8A8A8A8);
                }

                //Unknown Section
                for (int i = 0; i < 6; i++)
                {
                    BWriter.Write(0xDDDDDDDD);
                }

                //Write Mummy Inventory
                WriteInventoryItems(BWriter, fileData.MummyInventory);

                //Write Empty section???
                for (int i = 0; i < 1124; i++)
                {
                    BWriter.Write(0xA8A8A8A8);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private void WriteInventoryItems(BinaryWriter BWriter, InventoryItem[] itemsArray)
        {
            BWriter.Write(CountArrayItems(itemsArray));
            for (int i = 0; i < itemsArray.Length; i++)
            {
                InventoryItem currentItem = itemsArray[i];
                if (currentItem == null)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        BWriter.Write(0xA8A8A8A8);
                    }
                }
                else
                {
                    BWriter.Write(currentItem.HashCode);
                    BWriter.Write(currentItem.CurrentCount);
                    BWriter.Write(currentItem.MaxCount);
                    BWriter.Write(currentItem.Flags);
                }
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        private int CountArrayItems(InventoryItem[] itemsArray)
        {
            int counter = 0;
            for (int i = 0; i < itemsArray.Length; i++)
            {
                if (itemsArray[i] != null)
                {
                    counter++;
                }
            }

            return counter;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
