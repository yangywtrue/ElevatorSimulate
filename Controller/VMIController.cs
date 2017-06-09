using Common.Base;
using Common.Enum;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VMIController : Receiver<String>
    {
        private Elevator elevator;

        public event Action<string> onSendMessage;
        public event Action<string> onLogInfo;

        public VMIController(string deviceCode)
        {
            this.elevator = new Elevator(deviceCode);
        }

        #region 电梯属性
        public string DeviceCode
        {
            get
            {
                return this.elevator.DeviceCode;
            }
        }

        public int CurrentFloor
        {
            get
            {
                return this.elevator.CurrentFloor;
            }
        }
        public bool HasException
        {
            get
            {
                return this.elevator.HasException;
            }
        }
        public ElevatorDoorStatusEnum DoorStatus
        {
            get
            {
                return this.elevator.DoorStatus;
            }
        }
        public ElevatorDirectionEnum RunningDirection
        {
            get
            {
                return this.elevator.RunningDirection;
            }
        }
        public ElevatorControlModeEnum ControlMode
        {
            get
            {
                return this.elevator.ControlMode;
            }
        }
        #endregion

        public bool OpenDoor()
        {
            throw new NotImplementedException();
        }
        public bool CloseDoor()
        {
            throw new NotImplementedException();
        }
        public bool GoToFloor(int targetFloor)
        {
            throw new NotImplementedException();
        }

        public override void Process(string t)
        {
            LogReceMsg(t);

            return;
        }

        protected override bool IsAccept(string t)
        {
            string code = t.Substring(1, 1);
            if (code != this.DeviceCode)
            {
                return false;
            }
            return true;
        }

        private void LogSendMsg(string data)
        {
            LogInfo(data, "Send");
        }
        private void LogReceMsg(string data)
        {
            LogInfo(data, "Rece");
        }

        private void LogInfo(string data, string type)
        {
            string time = DateTime.Now.ToString("HH:mm:ss:ffff");
            string log = $"{time} - {DeviceCode}:{type}[{data}]";
            if (onLogInfo != null)
            {
                onLogInfo(log);
            }
        }
    }
}
