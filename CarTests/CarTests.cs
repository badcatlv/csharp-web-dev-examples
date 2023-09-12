using Car;

namespace CarTests;

[TestClass]
public class CarTests
{
    //TODO: add emptyTest so we can configure our runtime environment
    //(remove this test before pushing to your personal GitHub account)
    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(10, 10, .100);
    }
    //TODO: constructor sets gasTankLevel properly
    Car.Car test_car;

    [TestInitialize] //initialize the test_car object here so we dont have to do it for every test that proceeds this
    public void CreateCarObject()
    {
        test_car = new Car.Car("Toyota", "Prius", 10, 50);
        //Assert.AreEqual(10, test_car.GasTankLevel, .001);
    }

    [TestMethod]
    public void TestInitialGasTank()
    {
        //Car.Car test_car = new Car.Car("Toyota", "Prius", 10, 50);
        Assert.AreEqual(10, test_car.GasTankLevel, .001);
    }


    //TODO: gasTankLevel is accurate after driving within tank range
    //TODO: gasTankLevel is accurate after attempting to drive past tank range
    //TODO: can't have more gas than tank size, expect an exception
}
