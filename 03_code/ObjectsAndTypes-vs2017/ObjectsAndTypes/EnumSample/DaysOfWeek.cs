using System;

/**
 * 这里对星期的枚举很讲究
 * 用八位数表示，星期。再用位运算符去进行操作
 * 最终的情况很是费解，但是通过这种方式可以唯一确定对应日期或日期段
 */
namespace EnumSample
{
    [Flags]
    public enum DaysOfWeek
    {
        Monday = 0x1,
        Tuesday = 0x2,
        Wednesday = 0x4,
        Thursday = 0x8,
        Friday = 0x10,
        Saturday = 0x20,
        Sunday = 0x40,
        Weekend = Saturday | Sunday,
        Workday = 0x1f,
        AllWeek = Workday | Weekend
        //Monday = 1,
        //Tuesday = 2,
        //Wednesday = 3,
        //Thursday = 4,
        //Friday = 5,
        //Saturday = 6,
        //Sunday = 7,
        //Weekend = Saturday | Sunday,
        //Workday = 8,
        //AllWeek = Workday | Weekend
    }
}