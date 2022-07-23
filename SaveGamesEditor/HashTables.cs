using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SaveGamesEditor
{
    internal static class HashTables
    {
        //-------------------------------------------------------------------------------------------
        //  HASHTABLES
        //-------------------------------------------------------------------------------------------
        internal static Dictionary<uint, string> ReadSectionKeyHexAndLabel(string hashTableFilePath, string hashTableSection)
        {
            Dictionary<uint, string> AvailableHashCodes = new Dictionary<uint, string>();
            using (StreamReader file = new StreamReader(hashTableFilePath))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    if (ln.Contains(hashTableSection))
                    {
                        Match hexMatch = Regex.Match(ln, @"0[xX][0-9a-fA-F]+");
                        Match labelMatch = Regex.Match(ln, @"#define\s(\w+)");
                        if (labelMatch.Length > 0 && hexMatch.Length > 0)
                        {
                            uint hexValue = Convert.ToUInt32(hexMatch.Value.ToString(), 16);
                            if (!AvailableHashCodes.ContainsKey(hexValue))
                            {
                                AvailableHashCodes.Add(hexValue, labelMatch.Groups[1].Value.Trim());
                            }
                        }
                    }
                }
                file.Close();
            }

            return AvailableHashCodes;
        }

        //------------------------------------------------------------------------------------------------------------------------------
        internal static Dictionary<string, uint> ReadSectionKeyLabelAndHex(string hashTableFilePath, string hashTableSection)
        {
            Dictionary<string, uint> AvailableHashCodes = new Dictionary<string, uint>();
            using (StreamReader file = new StreamReader(hashTableFilePath))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    if (ln.Contains(hashTableSection))
                    {
                        Match hexMatch = Regex.Match(ln, @"0[xX][0-9a-fA-F]+");
                        Match labelMatch = Regex.Match(ln, @"#define\s(\w+)");
                        if (labelMatch.Length > 0 && hexMatch.Length > 0)
                        {
                            string label = labelMatch.Groups[1].Value.Trim();
                            if (!AvailableHashCodes.ContainsKey(label))
                            {
                                AvailableHashCodes.Add(label, Convert.ToUInt32(hexMatch.Value.ToString(), 16));
                            }
                        }
                    }
                }
                file.Close();
            }

            return AvailableHashCodes;
        }

        //------------------------------------------------------------------------------------------------------------------------------
        internal static string[] ReadHashTableSection(string hashTableFilePath, string hashTableSection)
        {
            HashSet<string> AvailableHashCodes = new HashSet<string>();
            using (StreamReader file = new StreamReader(hashTableFilePath))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    if (ln.Contains(hashTableSection))
                    {
                        Match regexMatch = Regex.Match(ln, @"#define\s(\w+)");
                        if (regexMatch.Length > 0)
                        {
                            AvailableHashCodes.Add(regexMatch.Groups[1].Value);
                        }
                    }
                }
                file.Close();
            }

            return AvailableHashCodes.ToArray();
        }
    }
}
