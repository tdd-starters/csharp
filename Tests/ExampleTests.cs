using Example;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Greet()
    {
        Assert.That(MyClass.Greet(), Is.EqualTo("Hello World!"));
    }
}
