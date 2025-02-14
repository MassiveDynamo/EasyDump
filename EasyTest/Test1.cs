using System.Runtime.InteropServices;

namespace EasyTest;

[TestClass]
public sealed class Test1
{
    [DllImport("Kernel32", EntryPoint = "GetCurrentThreadId", ExactSpelling = true)]
    public static extern Int32 GetCurrentWin32ThreadId();

    public required TestContext testContextInstance;

    /// <summary>
    /// Gets or sets the test context which provides
    /// information about and functionality for the current test run.
    /// </summary>
    public TestContext TestContext
    {
        get { return testContextInstance; }
        set { testContextInstance = value; }
    }

    [TestMethod, Timeout(1000)]
    public void TestMethod1()
    {
        int threadId = Thread.CurrentThread.ManagedThreadId;
        int unmanagedThreadId = GetCurrentWin32ThreadId();

        TestContext.WriteLine($"Managed Thread Id 0x{threadId:x}");
        TestContext.WriteLine($"Unmanaged Thread Id 0x{unmanagedThreadId:x}");
        Thread.Sleep(5000);
    }
}
