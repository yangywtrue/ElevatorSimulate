using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Enum
{
    public enum ElevatorDoorStatusEnum
    {
        Unknown = 0,
        Opened = 1,
        Closed = 2,
        Opening = 3,
        Closing = 4
    }

    public enum ElevatorDirectionEnum
    {
        Unknown = 0,
        Up = 1,
        Down = 2,
        Stop = 3
    }

    public enum ElevatorControlModeEnum
    {
        Unkown = 0,
        Automation = 1,
        Manul = 2
    }
}
