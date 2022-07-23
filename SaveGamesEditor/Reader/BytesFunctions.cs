namespace SaveGamesEditor
{
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------------------------------------------
    public static class BytesFunctions
    {

        //-------------------------------------------------------------------------------------------------------------------------------
        public static uint FlipUInt32(uint valueToFlip, bool isBigEndian)
        {
            uint finalData;
            if (isBigEndian)
            {
                finalData = (valueToFlip & 0xFF000000) >> (8 * 3) | /* 0x11______ -> 0x______11 */
                            (valueToFlip & 0x00FF0000) >> (8 * 1) | /* 0x__22____ -> 0x____22__ */
                            (valueToFlip & 0x0000FF00) << (8 * 1) | /* 0x____33__ -> 0x__33____ */
                            (valueToFlip & 0x000000FF) << (8 * 3);  /* 0x______44 -> 0x44______ */
            }
            else
            {
                finalData = valueToFlip;
            }
            return finalData;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        public static int FlipInt32(int valueToFlip, bool isBigEndian)
        {
            int finalData;

            if (isBigEndian && valueToFlip > 0)
            {
                finalData = (valueToFlip & 0x7F000000) >> (8 * 3) | /* 0x11______ -> 0x______11 */
                            (valueToFlip & 0x00FF0000) >> (8 * 1) | /* 0x__22____ -> 0x____22__ */
                            (valueToFlip & 0x0000FF00) << (8 * 1) | /* 0x____33__ -> 0x__33____ */
                            (valueToFlip & 0x000000FF) << (8 * 3);  /* 0x______44 -> 0x44______ */
            }
            else
            {
                finalData = valueToFlip;
            }
            return finalData;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        public static short FlipShort(short valueToFlip, bool isBigEndian)
        {
            short finalData;
            if (isBigEndian)
            {
                finalData = (short)((valueToFlip & 0xFF00) >> (8 * 1) | /* 0x11__ -> 0x__11 */
                                    (valueToFlip & 0x00FF) << (8 * 1)); /* 0x__22 -> 0x22__ */
            }
            else
            {
                finalData = valueToFlip;
            }

            return finalData;
        }

        //-------------------------------------------------------------------------------------------------------------------------------
        public static ushort FlipUShort(ushort valueToFlip, bool isBigEndian)
        {
            ushort finalData;

            if (isBigEndian)
            {
                //Flip input value
                finalData = (ushort)((valueToFlip & 0xFF00) >> (8 * 1) | /* 0x11__ -> 0x__11 */
                                     (valueToFlip & 0x00FF) << (8 * 1)); /* 0x__22 -> 0x22__ */
            }
            else
            {
                finalData = valueToFlip;
            }

            return finalData;
        }
    }

    //-------------------------------------------------------------------------------------------------------------------------------
}
