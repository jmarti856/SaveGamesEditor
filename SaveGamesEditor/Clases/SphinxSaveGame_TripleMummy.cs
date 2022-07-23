using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    [DefaultPropertyAttribute("Name")]
    public class SphinxSaveGame_TripleMummy
    {
        uint _mummy1Active, _mummy2Active, _mummy3Active;

        //Mummy 1 Active
        [CategoryAttribute("Mummy 1"), DescriptionAttribute("Name of the customer")]
        public uint Mummy1Active
        {
            get
            {
                return _mummy1Active;
            }
            set
            {
                _mummy1Active = value;
            }
        }

        //Mummy 2 Active
        [CategoryAttribute("Mummy 2"), DescriptionAttribute("Name of the customer")]
        public uint Mummy2Active
        {
            get
            {
                return _mummy2Active;
            }
            set
            {
                _mummy2Active = value;
            }
        }

        //Mummy 3 Active
        [CategoryAttribute("Mummy 3"), DescriptionAttribute("Name of the customer")]
        public uint Mummy3Active
        {
            get
            {
                return _mummy3Active;
            }
            set
            {
                _mummy3Active = value;
            }
        }
    }
}
