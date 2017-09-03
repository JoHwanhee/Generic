using System.Collections.Generic;
using System.Linq;

namespace IntroduceGeneric
{
    public class AttandanceBook
    {
        public Dictionary<string, int> LateDayRecord = new Dictionary<string, int>
        {
            {"조환희",3},
            {"염희웅",5},
            {"박진규",1},
            {"홍성찬",2},
        };

        public int GetSumOfAllLateDay()
        {
            return LateDayRecord.Sum(x => x.Value);
        }
    }
}