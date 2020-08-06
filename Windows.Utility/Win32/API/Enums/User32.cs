using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Utility.Win32.API.Enums
{
    /// <summary>
    /// 虚拟按键
    /// </summary>
    public enum VirtualKeyCodes : byte
    {
        /// <summary>
        /// 鼠标左键
        /// </summary>
        VK_LBUTTON = 0x01,
        /// <summary>
        /// 鼠标右键
        /// </summary>
        VK_RBUTTON = 0x02,
        /// <summary>
        /// 控制中断处理
        /// </summary>
        VK_CANCEL = 0x03,
        /// <summary>
        /// 鼠标中键（三键鼠标）
        /// </summary>
        VK_MBUTTON = 0x04,
        /// <summary>
        /// X1鼠标按钮
        /// </summary>
        VK_XBUTTON1 = 0x05,
        /// <summary>
        /// X2鼠标按钮
        /// </summary>
        VK_XBUTTON2 = 0x06,
        /// <summary>
        /// 未定义
        /// </summary>
        Undefined = 0x07,
        /// <summary>
        /// BACKSPACE键
        /// </summary>
        VK_BACK = 0x08,
        /// <summary>
        /// TAB键
        /// </summary>
        VK_TAB = 0x09,
        /// <summary>
        /// 清除键
        /// </summary>
        VK_CLEAR = 0x0C,
        /// <summary>
        /// 回车键
        /// </summary>
        VK_RETURN = 0x0D,
        /// <summary>
        /// SHIFT键
        /// </summary>
        VK_SHIFT = 0x10,
        /// <summary>
        /// CTRL键
        /// </summary>
        VK_CONTROL = 0x11,
        /// <summary>
        /// ALT键
        /// </summary>
        VK_MENU = 0x12,
        /// <summary>
        /// 暂停键
        /// </summary>
        VK_PAUSE = 0x13,
        /// <summary>
        /// 大写锁定键
        /// </summary>
        VK_CAPITAL = 0x14,
        /// <summary>
        /// IME假名模式
        /// </summary>
        VK_KANA = 0x15,
        /// <summary>
        /// IME Hanguel模式（保持兼容性；使用VK_HANGUL）
        /// </summary>
        VK_HANGUEL = 0x15,
        /// <summary>
        /// IME韩文模式
        /// </summary>
        VK_HANGUL = 0x15,
        /// <summary>
        /// 输入法开启
        /// </summary>
        VK_IME_ON = 0x16,
        /// <summary>
        /// IME Junja模式
        /// </summary>
        VK_JUNJA = 0x17,
        /// <summary>
        /// IME最终模式
        /// </summary>
        VK_FINAL = 0x18,
        /// <summary>
        /// IME Hanja模式
        /// </summary>
        VK_HANJA = 0x19,
        /// <summary>
        /// IME汉字模式
        /// </summary>
        VK_KANJI = 0x19,
        /// <summary>
        /// 输入法关闭
        /// </summary>
        VK_IME_OFF = 0x1A,
        /// <summary>
        /// ESC键
        /// </summary>
        VK_ESCAPE = 0x1B,
        /// <summary>
        /// 输入法转换
        /// </summary>
        VK_CONVERT = 0x1C,
        /// <summary>
        /// 输入法转换
        /// </summary>
        VK_NONCONVERT = 0x1D,
        /// <summary>
        /// 输入法接受
        /// </summary>
        VK_ACCEPT = 0x1E,
        /// <summary>
        /// 输入法模式更改请求
        /// </summary>
        VK_MODECHANGE = 0x1F,
        /// <summary>
        /// 空格键
        /// </summary>
        VK_SPACE = 0x20,
        /// <summary>
        /// PAGE UP键
        /// </summary>
        VK_PRIOR = 0x21,
        /// <summary>
        /// PAGE DOWN键
        /// </summary>
        VK_NEXT = 0x22,
        /// <summary>
        /// 结束键
        /// </summary>
        VK_END = 0x23,
        /// <summary>
        /// HOME键
        /// </summary>
        VK_HOME = 0x24,
        /// <summary>
        /// 左箭头键
        /// </summary>
        VK_LEFT = 0x25,
        /// <summary>
        /// 向上箭头键
        /// </summary>
        VK_UP = 0x26,
        /// <summary>
        /// 右箭头键
        /// </summary>
        VK_RIGHT = 0x27,
        /// <summary>
        /// 向下键
        /// </summary>
        VK_DOWN = 0x28,
        /// <summary>
        /// 选择键
        /// </summary>
        VK_SELECT = 0x29,
        /// <summary>
        /// Print键
        /// </summary>
        VK_PRINT = 0x2A,
        /// <summary>
        /// 执行键
        /// </summary>
        VK_EXECUTE = 0x2B,
        /// <summary>
        /// PRINT SCREEN键
        /// </summary>
        VK_SNAPSHOT = 0x2C,
        /// <summary>
        /// INS键
        /// </summary>
        VK_INSERT = 0x2D,
        /// <summary>
        /// DEL键
        /// </summary>
        VK_DELETE = 0x2E,
        /// <summary>
        /// 帮助键
        /// </summary>
        VK_HELP = 0x2F,
        VK_0 = 0X30,
        VK_1 = 0X31,
        VK_2 = 0X32,
        VK_3 = 0X33,
        VK_4 = 0X34,
        VK_5 = 0X35,
        VK_6 = 0X36,
        VK_7 = 0X37,
        VK_8 = 0X38,
        VK_9 = 0X39,
        VK_A = 0X41,
        VK_B = 0X42,
        VK_C = 0X43,
        VK_D = 0X44,
        VK_E = 0X45,
        VK_F = 0X46,
        VK_G = 0X47,
        VK_H = 0X48,
        VK_I = 0X49,
        VK_J = 0X4A,
        VK_K = 0X4B,
        VK_L = 0X4C,
        VK_M = 0X4D,
        VK_N = 0X4E,
        VK_O = 0X4F,
        VK_P = 0X50,
        VK_Q = 0X51,
        VK_R = 0X52,
        VK_S = 0X53,
        VK_T = 0X54,
        VK_U = 0X55,
        VK_V = 0X56,
        VK_W = 0X57,
        VK_X = 0X58,
        VK_Y = 0X59,
        VK_Z = 0X5A,
        /// <summary>
        /// 左Windows键（自然键盘）
        /// </summary>
        VK_LWIN = 0x5B,
        /// <summary>
        /// 右Windows键（自然键盘）
        /// </summary>
        VK_RWIN = 0x5C,
        /// <summary>
        /// 应用程序键（自然键盘）
        /// </summary>
        VK_APPS = 0x5D,
        /// <summary>
        /// 电脑睡眠键
        /// </summary>
        VK_SLEEP = 0x5F,
        VK_NUMPAD0 = 0x60,
        VK_NUMPAD1 = 0x61,
        VK_NUMPAD2 = 0x62,
        VK_NUMPAD3 = 0x63,
        VK_NUMPAD4 = 0x64,
        VK_NUMPAD5 = 0x65,
        VK_NUMPAD6 = 0x66,
        VK_NUMPAD7 = 0x67,
        VK_NUMPAD8 = 0x68,
        VK_NUMPAD9 = 0x69,
        /// <summary>
        /// 乘键
        /// </summary>
        VK_MULTIPLY = 0x6A,
        /// <summary>
        /// 加
        /// </summary>
        VK_ADD = 0x6B,
        /// <summary>
        /// 分隔键
        /// </summary>
        VK_SEPARATOR = 0x6C,
        /// <summary>
        /// 减键
        /// </summary>
        VK_SUBTRACT = 0x6D,
        /// <summary>
        /// 十进制键
        /// </summary>
        VK_DECIMAL = 0x6E,
        /// <summary>
        /// 分割键
        /// </summary>
        VK_DIVIDE = 0x6F,

        VK_F1 = 0x70,

        VK_F2 = 0x71,

        VK_F3 = 0x72,

        VK_F4 = 0x73,

        VK_F5 = 0x74,

        VK_F6 = 0x75,

        VK_F7 = 0x76,

        VK_F8 = 0x77,

        VK_F9 = 0x78,

        VK_F10 = 0x79,

        VK_F11 = 0x7A,

        VK_F12 = 0x7B,

        VK_F13 = 0x7C,

        VK_F14 = 0x7D,

        VK_F15 = 0x7E,

        VK_F16 = 0x7F,

        VK_F17 = 0x80,

        VK_F18 = 0x81,

        VK_F19 = 0x82,

        VK_F20 = 0x83,

        VK_F21 = 0x84,

        VK_F22 = 0x85,

        VK_F23 = 0x86,
        VK_F24 = 0x87,
        /// <summary>
        /// NUM LOCK键
        /// </summary>
        VK_NUMLOCK = 0x90,
        /// <summary>
        /// 滚动锁定键
        /// </summary>
        VK_SCROLL = 0x91,
        /// <summary>
        /// 左SHIFT键
        /// </summary>
        VK_LSHIFT = 0xA0,
        /// <summary>
        /// 右SHIFT键
        /// </summary>
        VK_RSHIFT = 0xA1,
        /// <summary>
        ///左CONTROL键
        /// </summary>
        VK_LCONTROL = 0xA2,
        /// <summary>
        /// 右CONTROL键
        /// </summary>
        VK_RCONTROL = 0xA3,
        /// <summary>
        /// 左MENU键
        /// </summary>
        VK_LMENU = 0xA4,
        /// <summary>
        /// 右键MENU键
        /// </summary>
        VK_RMENU = 0xA5,
        VK_BROWSER_BACK = 0xA6,
        VK_BROWSER_FORWARD = 0xA7,
        VK_BROWSER_REFRESH = 0xA8,
        VK_BROWSER_STOP = 0xA9,
        VK_BROWSER_SEARCH = 0xAA,
        VK_BROWSER_FAVORITES = 0xAB,
        VK_BROWSER_HOME = 0xAC,
        VK_VOLUME_MUTE = 0xAD,
        VK_VOLUME_DOWN = 0xAE,
        VK_VOLUME_UP = 0xAF,
        VK_MEDIA_NEXT_TRACK = 0xB0,
        VK_MEDIA_PREV_TRACK = 0xB1,
        VK_MEDIA_STOP = 0xB2,
        VK_MEDIA_PLAY_PAUSE = 0xB3,
        VK_LAUNCH_MAIL = 0xB4,
        VK_LAUNCH_MEDIA_SELECT = 0xB5,
        VK_LAUNCH_APP1 = 0xB6,
        VK_LAUNCH_APP2 = 0xB7,
        VK_OEM_1 = 0xBA,
        VK_OEM_PLUS = 0xBB,
        VK_OEM_COMMA = 0xBC,
        VK_OEM_MINUS = 0xBD,
        VK_OEM_PERIOD = 0xBE,
        VK_OEM_2 = 0xBF,
        VK_OEM_3 = 0xC0,
        VK_OEM_4 = 0xDB,
        VK_OEM_5 = 0xDC,
        VK_OEM_6 = 0xDD,
        VK_OEM_7 = 0xDE,
        VK_OEM_8 = 0xDF,
        VK_OEM_102 = 0xE2,
        VK_PROCESSKEY = 0xE5,
        VK_PACKET = 0xE7,
        VK_ATTN = 0xF6,
        VK_CRSEL = 0xF7,
        VK_EXSEL = 0xF8,
        VK_EREOF = 0xF9,
        VK_PLAY = 0xFA,
        VK_ZOOM = 0xFB,
        VK_NONAME = 0xFC,
        VK_PA1 = 0xFD,
        VK_OEM_CLEAR = 0xFE
    }
}
