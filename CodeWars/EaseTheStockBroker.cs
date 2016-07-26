using System;
using System.Text;

namespace CodeWars
{
    public static class EaseTheStockBroker
    {
        public static string BalanceStatements(string lst)
        {
            var sb = new StringBuilder();
            var badCount = 0;
            var totalBuy = 0;
            var totalSell = 0;
            foreach (var order in lst.Split(','))
            {
                var splittedOrder = order.TrimStart().Split(' ');

                if (splittedOrder.Length != 4)
                {
                    return string.Empty;
                }

                int quantity;
                decimal price;
                
                if (splittedOrder[0].Contains(" ") || !int.TryParse(splittedOrder[1], out quantity) || !decimal.TryParse(splittedOrder[2], out price) || string.IsNullOrEmpty(splittedOrder[3]))
                {
                    sb.AppendFormat("{0} ;", order.TrimStart());
                    badCount++;
                    continue;
                }

                if (splittedOrder[3].ToUpper().Equals("B"))
                {
                    var val = Convert.ToDecimal(quantity)*price;
                    totalBuy += (int)decimal.Round(val);
                }
                else if(splittedOrder[3].ToUpper().Equals("S"))
                {
                    var val1 = Convert.ToDecimal(quantity) * price;
                    totalSell += (int)decimal.Round(val1);
                }
                else
                {
                    sb.AppendFormat("{0} ;", order.TrimStart());
                    badCount++;
                }
            }

            if (badCount > 0)
            {
                var r = string.Format("Buy: {0} Sell: {1}; Badly formed {2}: {3}", totalBuy, totalSell, badCount, sb);
                return r;
            }

            var r1 = string.Format("Buy: {0} Sell: {1}", totalBuy, totalSell);
            return r1;
        }

     
    }
}