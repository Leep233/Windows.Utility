using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Windows.Utility.Win32.API.Structs
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DevMode
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string deviceName;

        public short specVersion;
        public short driverVersion;
        public short size;
        public short driverExtra;
        public int fields;
        public int positionX;
        public int positionY;
        public int displayOrientation;
        public int displayFixedOutput;
        public short color;
        public short duplex;
        public short resolution;
        public short option;
        public short collate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string formName;

        public short logPixels;
        public short bitsPerPel;
        public int pelsWidth;
        public int pelsHeight;
        public int displayFlags;
        public int displayFrequency;
        public int iCMMethod;
        public int iCMIntent;
        public int mediaType;
        public int ditherType;
        public int reserved1;
        public int reserved2;
        public int panningWidth;
        public int panningHeight;


        public DevMode(int flag)
        {
            size = (short)Marshal.SizeOf(typeof(DevMode));
            deviceName = string.Empty;
            formName = string.Empty;

            logPixels=
            bitsPerPel=
            color =
            duplex=
            resolution=
            option=
            collate=
            specVersion =
            driverVersion =
            size =
            driverExtra = 0;

            pelsWidth=
            pelsHeight=
            displayFlags =
            displayFrequency=
            iCMMethod=
            iCMIntent=
            mediaType=
            ditherType=
            reserved1=
            reserved2=
            panningWidth=
            panningHeight=
            fields =
            positionX =
            positionY =
            displayOrientation =
            displayFixedOutput = 0;

        }   
            
    };      
}
