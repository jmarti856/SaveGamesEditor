using System.ComponentModel;

namespace SaveGamesEditor
{
    public class AvailableMapsConverter : TypeConverter
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
            return new StandardValuesCollection(HashTables.ReadHashTableSection(@"S:\Sphinx\Project\hashcodes.h", "HT_File_"));
        }
    }
}
