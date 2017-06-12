using Common.Base;
using Common.Enum;
using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utility;

namespace Controller
{
    public class VMIController : Receiver<String>
    {
        public static int EachFloorRunningTime = Convert.ToInt32(ConfigurationManager.AppSettings["EachFloorRunningTime"]);
        public static int DoorStatusChangeTime = Convert.ToInt32(ConfigurationManager.AppSettings["DoorStatusChangeTime"]);

        private Elevator elevator;

        public event Action<string> onSendMessage;
        public event Action<string> onLogInfo;

        private TaskQueue taskQueue = new TaskQueue();

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

        public void OpenDoor()
        {
            if (this.elevator.DoorStatus == ElevatorDoorStatusEnum.Opened ||
                this.elevator.DoorStatus == ElevatorDoorStatusEnum.Opening)
            {
                return;
            }

            Task task = new Task(() =>
              {
                  if (this.elevator.DoorStatus == ElevatorDoorStatusEnum.Closing)
                  {
                      while (true)
                      {
                          if (this.elevator.DoorStatus == ElevatorDoorStatusEnum.Closed)
                          {
                              break;
                          }
                          Thread.Sleep(500);
                      }
                  }

                  this.elevator.DoorStatus = ElevatorDoorStatusEnum.Opening;
                  Thread.Sleep(DoorStatusChangeTime);

                  this.elevator.DoorStatus = ElevatorDoorStatusEnum.Opened;
                  Thread.Sleep(DoorStatusChangeTime);
              });

            taskQueue.Enqueue(task);
        }
        public void CloseDoor()
        {
            if (this.elevator.DoorStatus==ElevatorDoorStatusEnum.Closed ||
                this.elevator.DoorStatus == ElevatorDoorStatusEnum.Closing)
            {
                return;
            }

            Task task = new Task(() =>
            {
                if (this.elevator.DoorStatus == ElevatorDoorStatusEnum.Opening)
                {
                    while (true)
                    {
                        if (this.elevator.DoorStatus == ElevatorDoorStatusEnum.Opened)
                        {
                            break;
                        }
                        Thread.Sleep(500);
                    }
                }

                this.elevator.DoorStatus = ElevatorDoorStatusEnum.Closing;
                Thread.Sleep(DoorStatusChangeTime);

                this.elevator.DoorStatus = ElevatorDoorStatusEnum.Closed;
                Thread.Sleep(DoorStatusChangeTime);
            });

            taskQueue.Enqueue(task);
        }
        public void GoToFloor(int targetFloor)
        {
            if (targetFloor>this.elevator.TopFloor)
            {
                targetFloor = this.elevator.TopFloor;
            }

            if (this.CurrentFloor == targetFloor)
            {
                return;
            }

            Task task = new Task(() =>
            {
                if (this.elevator.DoorStatus == ElevatorDoorStatusEnum.Opening)
                {
                    while (true)
                    {
                        if (this.elevator.DoorStatus == ElevatorDoorStatusEnum.Opened)
                        {
                            break;
                        }
                        Thread.Sleep(500);
                    }
                }

                if (this.elevator.DoorStatus == ElevatorDoorStatusEnum.Opened)
                {
                    CloseDoor();
                    GoToFloor(targetFloor);
                    return;
                }

                if (this.elevator.DoorStatus==ElevatorDoorStatusEnum.Closing)
                {
                    while (true)
                    {
                        if (this.elevator.DoorStatus == ElevatorDoorStatusEnum.Closed)
                        {
                            break;
                        }
                        Thread.Sleep(500);
                    }
                }

                ElevatorDirectionEnum direct = ElevatorDirectionEnum.Unknown;
                int seed = 0;
                if (targetFloor>CurrentFloor)
                {
                    direct = ElevatorDirectionEnum.Up;
                    seed = 1;
                }
                if (targetFloor<CurrentFloor)
                {
                    direct = ElevatorDirectionEnum.Down;
                    seed = -1;
                }

                for (int i = this.CurrentFloor; i != targetFloor + seed; i = i + seed)
                {
                    this.elevator.RunningDirection = direct;
                    Thread.Sleep(EachFloorRunningTime);
                    setElevatorFloor(i);
                }
                this.elevator.RunningDirection = ElevatorDirectionEnum.Stop;
            });

            taskQueue.Enqueue(task);
        }

        public bool SetException(bool hasException)
        {
            this.elevator.HasException = hasException;

            return true;
        }

        public override void Process(string t)
        {
            LogReceMsg(t);

            VMIRequest request = new VMIRequest(t);

            switch (request.Data)
            {
                case "01":
                    GoToFloor(1);
                    break;
                case "02":
                    GoToFloor(2);
                    break;
                case "03":
                    GoToFloor(3);
                    break;
                case "04":
                    GoToFloor(4);
                    break;
                case "05":
                    OpenDoor();
                    break;
                case "06":
                    CloseDoor();
                    break;
                case "11":
                    ReportElevatorStatus(request);
                    break;
                default:
                    break;
            }

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

        private void ReportElevatorStatus(VMIRequest request)
        {
            string data = request.Data;
            string status = "05";
            int currentFloor = this.CurrentFloor;
            string controlMode = ((int)this.ControlMode).ToString();
            string runningStatus= ((int)this.RunningDirection).ToString();
            string doorStatus = "0";

            switch (this.DoorStatus)
            {
                case ElevatorDoorStatusEnum.Unknown:
                    doorStatus = "0";
                    break;
                case ElevatorDoorStatusEnum.Opened:
                    doorStatus = "1";
                    break;
                case ElevatorDoorStatusEnum.Closed:
                    doorStatus = "3";
                    break;
                case ElevatorDoorStatusEnum.Opening:
                    doorStatus = "2";
                    break;
                case ElevatorDoorStatusEnum.Closing:
                    doorStatus = "4";
                    break;
                default:
                    break;
            }

            string hasException = this.HasException ? "1" : "2";
            string body = $"{this.DeviceCode}{data}{status}{currentFloor}{controlMode}{runningStatus}{doorStatus}{hasException}00";
            string checkSum = MessageHelper.CalcCheckSum(body);

            string msg = $":{body}{checkSum}!";

            if (this.onSendMessage!=null)
            {
                this.onSendMessage(msg);
            }

            LogSendMsg(msg);
        }

        private void setElevatorFloor(int floor)
        {
            for (int i = 0; i < this.elevator.Floors.Keys.Count; i++)
            {
                int f = this.elevator.Floors.Keys.ElementAt(i);
                if (f == floor)
                {
                    this.elevator.Floors[f] = true;
                }
                else
                {
                    this.elevator.Floors[f] = false;
                }
            }
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
            string log = $"{time} - 电梯{DeviceCode}:{type}[{data}]";
            if (onLogInfo != null)
            {
                onLogInfo(log);
            }
        }
    }
}
