using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Windows.Utility.Win32.API.Structs
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DisplayDevice
    {
        public int cb;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;
        public int StateFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;

        public DisplayDevice(int stateFlags = 0)
        {
            DeviceID = string.Empty;
            DeviceKey = string.Empty;
            StateFlags = stateFlags;
            DeviceString = string.Empty;
            DeviceName = string.Empty;
            cb = Marshal.SizeOf(typeof(DisplayDevice));
        }

    };
}
