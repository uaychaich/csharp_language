/*
    Author: Uaychai Chotjaratwanich
    Modified Date: 2023-01-21
*/

public static class HelperClass
{
    public static int SyncMethod1()
    {
        System.Threading.Thread.Sleep(5000);
        return 5;
    }

    public static async Task<int> AsyncMethod1()
    {
        await System.Threading.Tasks.Task.Delay(5000);
        return 5;
    }
}