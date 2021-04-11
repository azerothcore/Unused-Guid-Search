using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace UnusedGuidSearcher
{
    public static class SearchGuids
    {
        // table name, primary key
        private static readonly Dictionary<string, string> SupportedTables = new Dictionary<string, string>
        {
            {"`creature_template`", "`entry`"},
            {"`creature`", "`guid`"},
            {"`gameobject_template`", "`entry`"},
            {"`gameobject`", "`guid`"},
            {"`waypoint_scripts`", "`id`"},
            {"`pool_template`", "`entry`"},
            {"`game_event`", "`eventEntry`"},
            {"`gossip_menu`", "`MenuID`"},
            {"`npc_text`", "`ID`"},
            {"`page_text`", "`ID`"},
            {"`acore_string`", "`entry`"},
            {"`trinity_string`", "`entry`"},
        };

        public static IEnumerable<string> GetSupportedTableNames()
        {
            return SupportedTables.Keys;
        }

        public class Options
        {
            public string ConnectionString { get; set; }
            public string Table { get; set; }
            public bool Consecutive { get; set; }
            public int Count { get; set; }
            public int Minimum { get; set; }
        }

        private static List<int> GetExistingGuids(string connectionString, string table)
        {
            var guids = new List<int>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var query = new MySqlCommand(string.Format("SELECT {0} FROM {1}", SupportedTables[table], table), connection))
                    using (var reader = query.ExecuteReader())
                        while (reader != null && reader.Read())
                            guids.Add(reader.GetInt32(0));
            }

            return guids;
        }

        public static IEnumerable<int> Search(Options options)
        {
            var existingGuids = GetExistingGuids(options.ConnectionString, options.Table);

            var minGuid = options.Minimum;
            var possibleGuids = Enumerable.Range(1, existingGuids.Last());
            var missingGuids = possibleGuids.Except(existingGuids).SkipWhile(i => i < minGuid).ToArray();
            IEnumerable<int> selectedMissingGuids;

            if (missingGuids.Length == 0)
                selectedMissingGuids = Enumerable.Range(Math.Max(existingGuids.Last() + 1, minGuid), options.Count);
            else if (options.Consecutive)
                selectedMissingGuids = GetConsecutiveGuids(missingGuids, options.Count) ??
                                       Enumerable.Range(Math.Max(existingGuids.Last() + 1, minGuid), options.Count);
            else
                selectedMissingGuids = missingGuids.Take(options.Count);

            return selectedMissingGuids;
        }

        private static IEnumerable<int> GetConsecutiveGuids(IList<int> input, long count)
        {
            if (count == 1)
                return new List<int> { input[0] };

            var result = new List<int>();

            for (var i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1] - 1)
                    result.Add(input[i]);
                else
                    result.Clear();

                if (result.Count >= count)
                    return result;
            }

            return result.Count < count ? null : result;
        }
    }
}
