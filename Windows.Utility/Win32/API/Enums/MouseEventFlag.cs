using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Windows.Utility.Win32.API.Enums
{
    public enum MouseEventFlag : uint
    {
        /// <summary>
        /// 鼠标移动事件
        /// </summary>
        Move = 0x0001,

        /// <summary>
        /// 鼠标左键按下事件
        /// </summary>
        LeftDown = 0x0002,
        LeftUp = 0x0004,
        RightDown = 0x0008,
        RightUp = 0x0010,
        MiddleDown = 0x0020,
        MiddleUp = 0x0040,
        XDown = 0x0080,
        XUp = 0x0100,
        Wheel = 0x0800,
        VirtualDesk = 0x4000,
        /// <summary>
        /// 设置鼠标坐标为绝对位置（dx,dy）,否则为距离最后一次事件触发的相对位置
        /// </summary>
        Absolute = 0x8000
    }
}
