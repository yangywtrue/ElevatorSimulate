﻿using Common.Base;
using Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Elevator
    {
        public string DeviceCode { get; private set; }
        public int CurrentFloor
        {
            get
            {
                return Floors.Where(p => p.Value == true).Select(p => p.Key).FirstOrDefault();
            }
        }
        public bool HasException { get; set; } = false;
        public ElevatorDoorStatusEnum DoorStatus { get; set; } = ElevatorDoorStatusEnum.Closed;
        public ElevatorDirectionEnum RunningDirection { get; set; } = ElevatorDirectionEnum.Unknown;
        public ElevatorControlModeEnum ControlMode { get; set; } = ElevatorControlModeEnum.Automation;

        public int TopFloor
        {
            get
            {
                return this.Floors.Keys.Last();
            }
        }

        public Dictionary<int, bool> Floors { get; } = new Dictionary<int, bool>()
        {
            [1] = true,
            [2] = false,
            [3] = false,
            [4] = false
        };

        public Elevator(string deviceCode)
        {
            this.DeviceCode = deviceCode;
        }

        

    }
}
