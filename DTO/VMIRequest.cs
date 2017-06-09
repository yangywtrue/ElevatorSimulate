using Qisda.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VMIRequest
    {
        public string BeginChr
        {
            get
            {
                return ":";
            }
        }
        public string DeviceCode { get; private set; }
        public string Cmd { get; private set; }
        public string Data { get; private set; }
        public string CheckSum { get; private set; }
        public string EndChr
        {
            get
            {
                return "!";
            }
        }

        public VMIRequest(string msg)
        {
            this.DeviceCode = msg.Substring(1, 1);
            this.Cmd = msg.Substring(2, 2);
            this.Data = msg.Substring(4, 2);
            this.CheckSum = msg.Substring(6, 2);
        }

        public VMIRequest(string deviceCode, string cmd, string data)
        {
            this.DeviceCode = deviceCode;
            this.Cmd = cmd;
            this.Data = data;
            this.CheckSum = CalcCheckSum();
        }

        public override string ToString()
        {
            StringBuilder builer = new StringBuilder();
            builer.Append(BeginChr);
            builer.Append(DeviceCode);
            builer.Append(Cmd);
            builer.Append(Data); ;
            builer.Append(CheckSum);
            builer.Append(EndChr);

            return builer.ToString();
        }

        private string CalcCheckSum(bool trimBeginEnd = true)
        {
            string data = this.ToString();
            if (trimBeginEnd)
            {
                data = data.Substring(1, data.Length - 4);
            }

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
