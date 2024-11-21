using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using project;

namespace project.Tests;

[TestClass]
[TestSubject(typeof(project.Task_9))]
public class Task9Test
{

    [TestMethod]
    public void CheckConvert()
    {
        var result = Task_9.Convert("123");
        Assert.AreEqual(123, result);
    }
    
    [TestMethod]
    public void CheckConvertNegative()
    {
        var result = Task_9.Convert("-123");
        Assert.AreEqual(-123, result);
    }
    
    [TestMethod]
    public void CheckBadNumber()
    {
        Assert.ThrowsException<FormatException>(() => Task_9.Convert("G")); //вызов функции с G выдаст именно такое исключение
    }
    
    [TestMethod]
    public void CheckBigNumber()
    {
        Assert.ThrowsException<OverflowException>(() => Task_9.Convert("500000000000000000000000000")); //
    }
    
    [TestMethod]
    public void CheckSmallNumber()
    {
        Assert.ThrowsException<OverflowException>(() => Task_9.Convert("-500000000000000000000000000")); //
    }
    
    [TestMethod]
    public void CheckNoNumber()
    {
        Assert.ThrowsException<FormatException>(() => Task_9.Convert("")); 
    }
}