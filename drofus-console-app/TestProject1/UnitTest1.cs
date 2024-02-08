using drofus_console_app;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            VendingMachine vendingMachine = new VendingMachine();

            var actual = "";

            //var actual = vendingMachine.InsertMoney("insert 50");

            //This method does not return a string, but I supposed I could change it
            //So I return a string and then I could cw it in program.cs
            //I assume there is a different way of doing this, but I wanted to showcase that I know some unit testing
            //Albeit that it is limited

            var expected = "Current credit is 50";

            StringAssert.Contains(expected, actual);

            
        }
    }
}