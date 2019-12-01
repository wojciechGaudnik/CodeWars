using System;
using System.Text;

namespace Katas
{
    public class OrdersSummary
    {
        public static String balanceStatements(String lst)
        {
            if (lst.Length == 0) return "Buy: 0 Sell: 0";
            StringBuilder answer = new StringBuilder();
            double buy = 0;
            double sell = 0;
            int badly = 0;
            foreach (var order in lst.Split(", "))
            {
                try
                {
                    string[] orderSplit = order.Split(" ");
                    if(!orderSplit[2].Contains("."))throw new Exception("");
                    if (orderSplit[3] == "B")
                    {
                        int quantity = Convert.ToInt32(orderSplit[1]);
                        double price = Convert.ToDouble(orderSplit[2]);
                        buy += quantity * price;
                    }
                    else if (orderSplit[3] == "S")
                    {
                        int quantity = Convert.ToInt32(orderSplit[1]);
                        double price = Convert.ToDouble(orderSplit[2]);
                        sell += quantity * price;
                    }
                }
                catch (Exception)
                {
                    badly++;
                    answer.Append(order + " ;");
                }
            }
            if(badly > 0) answer.Insert(0, String.Format("; Badly formed {0}: ", badly));
            answer.Insert(0, String.Format("Sell: {0:0}", sell));
            answer.Insert(0, String.Format("Buy: {0:0} ", buy));
            return answer.ToString();
        }
    }
}