using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Windows.Utility.Win32.API.Structs;

namespace Windows.Utility.Win32.API.DLLs
{
   public class MonitorConfiguration
    {
        public const string DLLPath = "Dxva2.dll";

        /// <summary>
        /// 检索监视器的最小，最大和当前宽度或高度
        /// </summary>
        /// <param name="monitor">处理物理监视器。要获取监视器句柄，请调用GetPhysicalMonitorsFromHMONITOR或GetPhysicalMonitorsFromIDirect3DDevice9。</param>
        /// <param name="sizeType">0宽度 1 高度 </param>
        /// <param name="minimumWidthOrHeight">接收最小宽度或高度</param>
        /// <param name="currentWidthOrHeight">接收当前的宽度或高度</param>
        /// <param name="maximunwidthOrHeight">接收最大宽度或高度</param>
        /// <returns></returns>
        [DllImport(DLLPath)]
        public static extern int GetMonitorDisplayAreaSize(IntPtr monitor, int sizeType, IntPtr minimumWidthOrHeight, IntPtr currentWidthOrHeight, IntPtr maximunwidthOrHeight);

        /// <summary>
        /// 检索与HMONITOR监视器句柄关联的物理监视器
        /// </summary>
        /// <param name="hMonitor">监视器手柄。监视器句柄由多个“多显示器监视器”功能返回，包括EnumDisplayMonitors和MonitorFromWindow，它们是图形设备接口（GDI）的一部分</param>
        /// <param name="physicalMonitorArraySize">要获取所需的数组大小，请调用GetNumberOfPhysicalMonitorsFromHMONITOR</param>
        /// <param name="physicalMonitorArray">指向PHYSICAL_MONITOR结构数组的指针。调用者必须分配数组</param>
        /// <returns></returns>
        [DllImport(DLLPath)]
        public static extern int GetPhysicalMonitorsFromHMONITOR(  IntPtr hMonitor,  int physicalMonitorArraySize,   PhysicalMonitor[] physicalMonitorArray);

        /// <summary>
        ///检索与HMONITOR监视器句柄关联的物理监视器的数量
        /// </summary>
        /// <param name="hMonitor"> 监视器句柄。监视器句柄由多个“多显示器监视器”功能返回，包括EnumDisplayMonitors和MonitorFromWindow，它们是图形设备接口（GDI）的一部分</param>
        /// <param name="pdwNumberOfPhysicalMonitors">接收与监视器句柄关联的物理监视器的数量。</param>
        /// <returns>要获取扩展的错误信息，请调用GetLastError。</returns>
        [DllImport(DLLPath)]
        public static extern int GetNumberOfPhysicalMonitorsFromHMONITOR(IntPtr hMonitor,IntPtr pdwNumberOfPhysicalMonitors);

        /// <summary>
        /// 关闭一系列物理监视器句柄
        /// </summary>
        /// <param name="monitorArraySize">数组中的元素数</param>
        /// <param name="physicalMonitorArray">结构数组的指针</param>
        /// <returns></returns>
        [DllImport(DLLPath)]
        public static extern int DestroyPhysicalMonitors(int monitorArraySize, PhysicalMonitor[] physicalMonitorArray);
    }
}
