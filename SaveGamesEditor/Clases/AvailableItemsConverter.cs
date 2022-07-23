using System;
using System.ComponentModel;

namespace SaveGamesEditor
{
    class AvailableItemsConverter : TypeConverter
    {
        public override bool
        GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true; // display drop
        }

        public override bool
        GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true; // drop-down vs combo
        }

        public override StandardValuesCollection
        GetStandardValues(ITypeDescriptorContext context)
        {
            // note you can also look at context etc to build list
            string[] ItemsArray = HashTables.ReadHashTableSection(@"S:\Sphinx\Project\hashcodes.h", "HT_Item_");
            string[] FilesArray = HashTables.ReadHashTableSection(@"S:\Sphinx\Project\hashcodes.h", "HT_File_");

            //Merge strings
            string[] mergedString = new string[ItemsArray.Length + FilesArray.Length];
            Array.Copy(ItemsArray, mergedString, ItemsArray.Length);
            Array.Copy(FilesArray, 0, mergedString, ItemsArray.Length, FilesArray.Length);

            return new StandardValuesCollection(mergedString);
        }
    }
}
