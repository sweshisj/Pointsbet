using System.Text;
using System.Linq;//5. Select and Join methods comes under Linq

namespace PointsBet_Backend_Online_Code_Test
{
    public class StringFormatter
    {

        //1. Corrected typo from "Sepatated" to "Separated" in 'ToCommaSeparatedList' method name
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            //2. Handle null or empty input array
            if (items == null || items.length == 0)
            {
                return string.empty;
            }

            // 3. Optimization : Quote each item individually using Select method instead of iterating the items
            var qry = items.Select(item => $"{quote}{item}{quote}");

            //4. Join the quoted items using ", " and return it
            return string.Join(", ", qry);
        }
    }
}
