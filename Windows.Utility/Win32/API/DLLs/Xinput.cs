using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Utility.Win32.API.Structs;

namespace Windows.Utility.Win32.API.DLLs
{
   public class Xinput
    {
        public const int XUSER_MAX_COUNT = 4;
        public const int XUSER_INDEX_ANY = 0x000000FF;
        public const int XINPUT_FLAG_GAMEPAD = 0x00000001;
        public const int XINPUT_GAMEPAD_LEFT_THUMB_DEADZONE = 7849;
        public const int XINPUT_GAMEPAD_RIGHT_THUMB_DEADZONE = 7849;
        public const int XINPUT_GAMEPAD_TRIGGER_THRESHOLD = 7849;

        public const string DLLPATH = "xinput1_3.dll";

        [DllImport(DLLPATH, CallingConvention = CallingConvention.Winapi)]
        public static extern int XInputGetState(uint userIndex, out XinputState xinputState);


        [DllImport(DLLPATH, CallingConvention = CallingConvention.Winapi)]
        public static extern int XInputSetState(uint userIndex, ref XinputVibration vibration);

        [DllImport(DLLPATH, CallingConvention = CallingConvention.Winapi)]
        public static extern int XInputGetCapabilities(uint userIndex, ref XinputVibration vibration);

        [DllImport(DLLPATH, CallingConvention = CallingConvention.Winapi)]
        public static extern int XInputEnable(bool enable);

        [DllImport(DLLPATH, CallingConvention = CallingConvention.Winapi)]
        public static extern int XInputGetAudioDeviceIds(uint userIndex, string renderDeviceID, uint[] renderCount, string captureDeviceId, uint[] captureCount);

        [DllImport(DLLPATH, CallingConvention = CallingConvention.Winapi)]
        public static extern int XInputGetBatteryInformation(uint userIndex, bool devType, ref XinputBatteryInformation batteryInformation);
        [DllImport(DLLPATH, CallingConvention = CallingConvention.Winapi)]
        public static extern int XInputGetKeystroke(uint userIndex, uint reserved, out XinputKeystroke keystroke);

    }


}
