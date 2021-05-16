using System;
using System.Collections.Generic;
using System.Text;

namespace JBank.Lib.Model
{
    public class AccountType
    {
        public static decimal GetMinBalance(string type)
        {
            var AccountTypes = new Dictionary<string, decimal> { { "savings", 1000 }, { "current", 0 } };

            decimal res = 0;
            foreach (KeyValuePair<string, decimal> kvp in AccountTypes)
            {
                if (kvp.Key == type)
                    res = kvp.Value;
            }
            return res;
        }
    }
}
