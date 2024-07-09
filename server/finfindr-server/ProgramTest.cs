using NUnit.Framework;

[TestFixture] // This attribute is necessary to indicate a test class
public class YourTestClass // Define a class to contain the test method
{
    [TestCase(5, 5, 10)]
    [TestCase(-1, -1, -2)]
    public void TestAddition(int a, int b, int expected) // Test method must be inside a class
    {
        Calculator calculator = new Calculator();
        int res = calculator.addNumbers(a, b);
        Assert.AreEqual(expected, res);
    }
}
