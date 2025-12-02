/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-28
*/
using System;
namespace UayExtension;
public static class DateTimeExtension
{
    public static string UayDateTimeFormat(this DateTime dt, bool isshowtime)
    {
        return isshowtime?$"{dt:yyyy-MM-ddTHH:mm:ss}":$"{dt:yyyy-MM-dd}";
    }
}