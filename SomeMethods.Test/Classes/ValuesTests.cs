using SomeMethods.Classes;
using System;

namespace SomeMethods.Test.Classes.Classes;

public class ValuesTests
{
    [TestCase(3,5,7,0)]
    [TestCase(2,0,25,12)]
    [TestCase(3,62,21,-13)]
    public void EquationReturnXTests(int a, int b, int c, int expected)
    {
        Values values = new Values();
        int actual = values.EquationReturnX(a, b, c);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void EquationReturnXTests_WhenDivideByZero_ShouldArgumentException()
    {
        Values values = new Values();
        int a = 0;
        int b = 5;
        int c = 7;
        Assert.Throws<ArgumentException>(()=> values.EquationReturnX(a,b,c));
    }
    
    [TestCase(3,1,4)]
    [TestCase(3,8,-5)]
    [TestCase(5,5,25)]
    public void CompareNumbersAndCalculateTests(int a, int b, int expected)
    {
        Values values = new Values();
        int actual = values.CompareNumbersAndCalculate(a, b);

        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(25,"двадцать пять")]
    [TestCase(31,"тридцать один")]
    [TestCase(66,"шестьдесят шесть")]
    public void NotationOfNumberTests(int value, string expected)
    {
        Values values = new Values();
        string actual = values.NotationOfNumber(value);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void NotationOfNumberTests_WhenArgumentLessTen_ShouldArgumentException()
    {
        Values values = new Values();
        int value = 0;

        Assert.Throws<ArgumentException>(()=> values.NotationOfNumber(value));
    }
    
    [Test]
    public void NotationOfNumberTests_WhenArgumentBiggestNinetyNine_ShouldArgumentException()
    {
        Values values = new Values();
        int value = 110;

        Assert.Throws<ArgumentException>(()=> values.NotationOfNumber(value));
    }
    
    [TestCase(5,true)]
    [TestCase(15,false)]
    [TestCase(25,true)]
    [TestCase(0,true)]
    [TestCase(-120,false)]
    public void FindRangeTests(int value, bool expected)
    {
        Values values = new Values();
        bool actual = values.FindRange(value);

        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(-10,20,4)]
    [TestCase(15,35,3)]
    [TestCase(0,21,4)]
    public void ReturnSummOfValuesFromAtoBDivOnSevenTests(int a,int b, int expected)
    {
        Values values = new Values();
        int actual = values.ReturnSummOfValuesFromAtoBDivOnSeven(a,b);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void ReturnSummOfValuesFromAtoBDivOnSevenTests_WhenFirstArgBiggestSecond_ShouldArgumentException()
    {
        Values values = new Values();
        int a = 10;
        int b = 2;

        Assert.Throws<ArgumentException>(()=> values.ReturnSummOfValuesFromAtoBDivOnSeven(a,b));
    }
    
    [TestCase(3,2)]
    [TestCase(5,5)]
    [TestCase(7,13)]
    public void FindFibonachiValueTests(int value, int expected)
    {
        Values values = new Values();
        int actual = values.FindFibonachiValue(value);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void FindFibonachiValueTests_WhenArgumentLessZero_ShouldArgumentException()
    {
        Values values = new Values();
        int value = -2;

        Assert.Throws<ArgumentException>(()=> values.FindFibonachiValue(value));
    }
    
    [TestCase(77,2)]
    [TestCase(76,1)]
    [TestCase(8,0)]
    [TestCase(15672,3)]
    [TestCase(0,0)]
    public void FindOddValuesOfNumberTests(int value, int expected)
    {
        Values values = new Values();
        int actual = values.FindOddValuesOfNumber(value);

        Assert.AreEqual(expected, actual);
    }
    
    [TestCase(132,231)]
    [TestCase(874165,561478)]
    [TestCase(1067834,4387601)]
    [TestCase(541,145)]
    public void ReverseValueTests(int value, int expected)
    {
        Values values = new Values();
        int actual = values.ReverseValue(value);

        Assert.AreEqual(expected, actual);
    }
    
    [Test]
    public void ReverseValueTests_WhenArgumentFinishOnZero_ShouldArgumentException()
    {
        Values values = new Values();
        int value = 230;

        Assert.Throws<ArgumentException>(()=> values.ReverseValue(value));
    }
    
    [TestCase(541,145, true)]
    [TestCase(541,768, false)]
    [TestCase(0,0, true)]
    [TestCase(341231,56634231, true)]
    public void CompareValuesTests(int a, int b, bool expected)
    {
        Values values = new Values();
        bool actual = values.CompareValues(a,b);

        Assert.AreEqual(expected, actual);
    }
}