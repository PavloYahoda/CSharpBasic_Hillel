using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public static class Helper
    {
        
        public static string createBankAccountNumber(int length)
        {
            string str = "0123456789";
            string accountNumber = "UA";
            Random random = new Random();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(str.Length);
                result.Append(str[index]);
            }
            return accountNumber + result.ToString();
        }
        

    }
}
