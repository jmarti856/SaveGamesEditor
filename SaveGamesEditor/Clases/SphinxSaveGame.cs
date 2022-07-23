namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public class SphinxSaveGame
    {
        //Header
        public SphinxSaveGame_Header FileHeader = new SphinxSaveGame_Header();

        //Current Map
        public uint Cur_map_hashcode;
        public uint Cur_map_entrypoint;
        public int Cur_map_restard_id;
        public uint Cur_map_timer;

        //Programmable Items
        internal uint[] sphinx_prog_buttons = new uint[4];
        internal uint[] mummy_prog_buttons = new uint[4];

        //Notes
        internal InventoryNote[] Notes_sphinx { get; set; } = new InventoryNote[10];
        internal InventoryNote[] Notes_mummy { get; set; } = new InventoryNote[10];

        //Objectives Array
        internal Objective[] Objectives { get; set; } = new Objective[1700];

        //Items
        internal InventoryItem[] DartItemsSphinx = new InventoryItem[140];
        internal InventoryItem[] QuestItemsSphinx = new InventoryItem[140];
        internal InventoryItem[] AbilityItemsSphinx = new InventoryItem[140];
        internal InventoryItem[] AbilityPossession = new InventoryItem[140];
        internal InventoryItem[] AbilityKa = new InventoryItem[140];

        internal InventoryItem[] MummyInventory = new InventoryItem[100];
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
