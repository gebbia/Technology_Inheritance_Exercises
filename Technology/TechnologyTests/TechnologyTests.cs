using Technology_Inheritance_Exercises;

namespace TechnologyTests
{
    [TestClass]
    public class TechnologyTests
    { 
            [TestMethod]
            public void TestIncreasingRam()
            {
                Computer testingComputer = new(2, 3, true);
                Assert.AreEqual(2, testingComputer.Ram);
                testingComputer.AddRam(3);
                Assert.AreEqual(5, testingComputer.Ram);
            }


            [TestMethod]
            public void TestIncreasingStorage()
            {
                Computer testingComputer = new(2, 3, true);
                Assert.AreEqual(3, testingComputer.Storage);
                testingComputer.AddStorage(2);
                Assert.AreEqual(5, testingComputer.Storage);
            }

            [TestMethod]
            public void TestTakingSelfies()
            {
                Smartphone testingSmartphone = new(2, 3, true, 800);
                testingSmartphone.TakeSelfie(800);
                Assert.AreEqual(1600, testingSmartphone.NumberOfSelfies);
            }


            [TestMethod]
            public void TestLaptopCanAddRam()
            {
                Laptop testingLaptop = new(2, 3, true, 4);
                Assert.AreEqual(2, testingLaptop.Ram);
                testingLaptop.AddRam(3);
                Assert.AreEqual(5, testingLaptop.Ram);
            }

            [TestMethod]
            public void TestLaptopCanAddStorage()
            {
                Laptop testingLaptop = new(2, 3, true, 4);
                Assert.AreEqual(3, testingLaptop.Storage);
                testingLaptop.AddStorage(2);
                Assert.AreEqual(5, testingLaptop.Storage);
            }

            [TestMethod]
            public void TestSmartphoneCanAddStorage()
            {
                Smartphone testingSmartphone = new(2, 3, true, 800);
                Assert.AreEqual(3, testingSmartphone.Storage);
                testingSmartphone.AddStorage(2);
                Assert.AreEqual(5, testingSmartphone.Storage);
            }

            [TestMethod]
            public void TestSmartphoneCanAddRam()
            {
                Smartphone testingSmartphone = new(2, 3, true, 800);
                Assert.AreEqual(2, testingSmartphone.Ram);
                testingSmartphone.AddRam(3);
                Assert.AreEqual(5, testingSmartphone.Ram);
            }

            [TestMethod]
            public void TestIsClunkyReturnsFalseWhenWeightIsLessThan5()
            {
                Laptop testingLaptop = new(2, 3, true, 4);
                testingLaptop.IsClunky();
                Assert.IsFalse(testingLaptop.IsClunky());
            }

            [TestMethod]
            public void TestIsClunkyReturnsTrueWhenWeightIsGreaterThan5()
            {
                Laptop testingLaptop = new(2, 3, true, 9);
                testingLaptop.IsClunky();
                Assert.IsTrue(testingLaptop.IsClunky());
            }

            [TestMethod]
            public void TestInheritsId()
            {
                Computer testingComputer = new(2, 3, true);
                Assert.AreEqual(1, testingComputer.Id);

                Computer testingComputer2 = new(4, 6, true);
                Assert.AreEqual(2, testingComputer2.Id);
            }

            [TestMethod]
            public void TestInheritingBaseConstructor()
            {
            Smartphone testingSmartphone = new(2, 3, true, 800);
            Assert.IsNotNull(testingSmartphone.Id);
            }
        }

}