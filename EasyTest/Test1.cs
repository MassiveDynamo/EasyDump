using System.Runtime.InteropServices;

namespace EasyTest;

[TestClass]
public sealed class Test1
{
    [DllImport("Kernel32", EntryPoint = "GetCurrentThreadId", ExactSpelling = true)]
    public static extern Int32 GetCurrentWin32ThreadId();

    [TestMethod, Timeout(1000)]
    public void TestMethod1()
    {
        int threadId = Thread.CurrentThread.ManagedThreadId;
        int unmanagedThreadId = GetCurrentWin32ThreadId();

        Console.WriteLine($"Managed Thread Id {threadId:x}");
        Console.WriteLine($"Unmanaged Thread Id {unmanagedThreadId:x}");
        Thread.Sleep(5000);
    }
}
