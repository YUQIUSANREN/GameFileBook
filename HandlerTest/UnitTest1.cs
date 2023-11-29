using BookHandlers.FileHandler;

namespace HandlerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            USNHandler usn = new USNHandler();
            var result = usn.GetFileList(usn.DrivesNotContainC.FirstOrDefault()!);
        }
    }
}