using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace DTO
{
    public class VMIResponse
    {
        public string Msg { get; private set; }

        public string BeginChr { get; private set; }
        public string DeviceCode { get; private set; }
        public string Data { get; private set; }
        public string State { get; private set; }

        public string CurrentFloor { get; private set; }
        public string ControlMode { get; private set; }
        public string RunStatus { get; private set; }
        public string DoorStatus { get; private set; }
        public string Exception { get; private set; }
        public string Grating1 { get; private set; }
        public string Grating2 { get; private set; }

        public string CheckSum { get; private set; }
        public string EndChr { get; private set; }

        public bool IsValid { get; private set; }

        public VMIResponse(string msg)
        {
            this.Msg = msg;
            if (msg.Length == 16)
            {
                this.BeginChr = msg.Substring(0, 1);
                this.DeviceCode = msg.Substring(1, 1);
                this.Data = msg.Substring(2, 2);
                this.State = msg.Substring(4, 2);

                this.CurrentFloor = msg.Substring(6, 1);
                this.ControlMode = msg.Substring(7, 1);
                this.RunStatus = msg.Substring(8, 1);
                this.DoorStatus = msg.Substring(9, 1);
                this.Exception = msg.Substring(10, 1);
                this.Grating1 = msg.Substring(11, 1);
                this.Grating2 = msg.Substring(12, 1);

                this.CheckSum = msg.Substring(13, 2);
                this.EndChr = msg.Substring(15, 1);
            }

            this.IsValid = checkIsValid();
        }

        public override string ToString()
        {
            return this.Msg;
        }

        private bool checkIsValid()
        {
            string msg = this.ToString();
            if (msg.Length != 16)
            {
                return false;
            }

            if (this.BeginChr != ":" || this.EndChr != "!")
            {
                return false;
            }

            if (this.CheckSum != CalcCheckSum())
            {
                return false;
            }

            //响应码为错
            if (this.State == "07")
            {
                return false;
            }

            return true;
        }

        private string CalcCheckSum(bool trimBeginEnd = true)
        {
            string data = this.ToString();
            if (trimBeginEnd)
            {
                data = data.Substring(1, data.Length - 4);
            }

            return MessageHelper.CalcCheckSum(data);
        }
    }
}
