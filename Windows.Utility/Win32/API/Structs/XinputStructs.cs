using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Windows.Utility.Win32.API.Structs
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XinputGamePad
    {
        public short buttons;
        public byte leftTrigger;
        public byte rightTrigger;
        public short thumbLX;
        public short thumbLY;
        public short thumbRX;
        public short thumbRY;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XinputState
    {
        public uint packetNumber;
        public XinputGamePad gamepad;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XinputVibration//XinputVibration
    {
        public ushort leftMotorSpeed;
        public ushort rightMotorSpeed;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XinputCapabilities//XinputCapabilities
    {
        public byte type;
        public byte subType;
        public ushort flags;
        public XinputGamePad gamepad;
        public XinputVibration Vibration;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XinputBatteryInformation//XinputBatteryInformation
    {
        public byte batteryType;
        public byte batteryLevel;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XinputKeystroke//XinputKeystroke
    {
        public ushort virtualKey;
        public ushort unicode;
        public ushort flags;
        public byte userIndex;
        public byte hidCode;
    }
}
