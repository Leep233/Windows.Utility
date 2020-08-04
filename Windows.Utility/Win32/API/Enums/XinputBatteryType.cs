using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Windows.Utility.Win32.API.Enums
{
    public enum XinputBatteryType
    {

        BATTERY_TYPE_DISCONNECTED = 0x00,   // This device is not connected
        BATTERY_TYPE_WIRED = 0x01,   // Wired device, no battery
        BATTERY_TYPE_ALKALINE = 0x02,   // Alkaline battery source
        BATTERY_TYPE_NIMH = 0x03,   // Nickel Metal Hydride battery source
        BATTERY_TYPE_UNKNOWN = 0xFF    // Cannot determine the battery type

    }
}
