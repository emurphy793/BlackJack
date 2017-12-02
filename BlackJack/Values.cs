using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Values
    {
        internal static object getHandValue(List<Card> myHand)
        {
            int total = 0;
            foreach (var item in myHand)
            {
                total += item.PointValue;
            }
            return total;
        }
    }
}
