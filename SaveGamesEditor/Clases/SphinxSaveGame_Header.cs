using System.ComponentModel;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    [DefaultPropertyAttribute("Name")]
    public class SphinxSaveGame_Header
    {
        private ushort _Static_2500_b, _scarabs;
        private uint _Time_sec, _Health_ankhs, _health_thirds, _total_health_thirds, _version, _versionAgain, _Crowns;

        //Header
        [CategoryAttribute("Header Data"), DescriptionAttribute("Name of the customer")]
        public uint Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }

        [CategoryAttribute("Header Data"), DescriptionAttribute("Name of the customer")]
        public uint VersionAgain
        {
            get
            {
                return _versionAgain;
            }
            set
            {
                _versionAgain = value;
            }
        }

        [CategoryAttribute("Header Data"), DescriptionAttribute("Name of the customer")]
        public uint Crowns
        {
            get
            {
                return _Crowns;
            }
            set
            {
                _Crowns = value;
            }
        }

        [CategoryAttribute("Header Data"), DescriptionAttribute("Name of the customer")]
        public ushort Static_2500_b
        {
            get
            {
                return _Static_2500_b;
            }
            set
            {
                _Static_2500_b = value;
            }
        }

        [CategoryAttribute("General"), DescriptionAttribute("In 1/60ths of a second")]
        public uint Time_sec
        {
            get
            {
                return _Time_sec;
            }
            set
            {
                _Time_sec = value;
            }
        }

        [CategoryAttribute("General"), DescriptionAttribute("Total collected scarabs")]
        public ushort Scarabs
        {
            get
            {
                return _scarabs;
            }
            set
            {
                _scarabs = value;
            }
        }

        [CategoryAttribute("Health"), DescriptionAttribute("Whole Ankhs")]
        public uint Health_ankhs
        {
            get
            {
                return _Health_ankhs;
            }
            set
            {
                _Health_ankhs = value;
            }
        }

        [CategoryAttribute("Health"), DescriptionAttribute("Each piece has three parts")]
        public uint Health_thirds
        {
            get
            {
                return _health_thirds;
            }
            set
            {
                _health_thirds = value;
            }
        }

        [CategoryAttribute("Health"), DescriptionAttribute("Health ankhs * 3")]
        public uint Total_health_thirds
        {
            get
            {
                return _total_health_thirds;
            }
            set
            {
                _total_health_thirds = value;
            }
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
