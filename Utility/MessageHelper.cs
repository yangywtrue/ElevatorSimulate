using Qisda.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class MessageHelper
    {
        public static string CalcCheckSum(string data)
        {
            int sum = 0;
            foreach (char chr in data.ToCharArray())
            {
                if (chr == '\t')
                {
                    continue;
                }
                sum += QStrings.Asc(chr.ToString());
            }
            string hex = Convert.ToString(sum, 16);
            if (hex.Length >= 2)
            {
                return hex.Substring(hex.Length - 2, 2).ToUpper();
            }
            else
            {
                return hex.ToUpper();
            }
        }
    }
}
