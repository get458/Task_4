using System.Runtime.InteropServices.JavaScript;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ConsoleApp1;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestBiggest()
    {
        Assert.IsTrue(ConsoleApp1.Program.CountBiggest(3, 2));
        Assert.IsFalse(ConsoleApp1.Program.CountBiggest(2, 3));
    }

    [Test]
    public void TestMetr()
    {
        Assert.That(ConsoleApp1.Program.ReturnMetr(100), Is.EqualTo(1));
        Assert.That(ConsoleApp1.Program.ReturnMetr(1000), Is.EqualTo(10));
    }

    [Test]
    public void TestDate()
    {
        Assert.IsFalse(ConsoleApp1.Program.IsDateValid(2022, 2, 30));
        Assert.IsFalse(ConsoleApp1.Program.IsDateValid(2022, 2, 31));
        Assert.IsTrue(ConsoleApp1.Program.IsDateValid(2022, 2, 10));
    }

    [Test]
    public void TestAuth()
    {
        Assert.IsTrue(ConsoleApp1.Program.Auth("kirill", "kirill123"));
        Assert.IsFalse(ConsoleApp1.Program.Auth("kirill43", "kirill13"));
    }

    [Test]
    public void TestReg()
    {
        Assert.IsTrue(ConsoleApp1.Program.Reg("kir1", "kir123", "kir123@mail.ru", new DateOnly(2002, 10, 27)));
    }
}