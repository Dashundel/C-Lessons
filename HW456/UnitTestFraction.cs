using HW456;

namespace Tests;

public class UnitTestFraction
{
    [Test]
    public void SubtractSuccses()
    {
        SimpleFractionStructure firstFraction = new SimpleFractionStructure(1, 3);
        SimpleFractionStructure secondFraction = new SimpleFractionStructure(2, 7);
        SimpleFractionStructure result = new SimpleFractionStructure(1, 21);
        
        Assert.That(SimpleFractionStructure.Subtract(firstFraction, secondFraction), Is.EqualTo(result));
    }
    
    [Test]
    public void MultiplySuccses()
    {
        SimpleFractionStructure firstFraction = new SimpleFractionStructure(1, 3);
        SimpleFractionStructure secondFraction = new SimpleFractionStructure(2, 6);
        SimpleFractionStructure result = new SimpleFractionStructure(1, 9); 

        Assert.That(SimpleFractionStructure.Multiply(firstFraction, secondFraction), Is.EqualTo(result));
    }
    
    [Test]
    public void DivisiveSuccses()
    {
        SimpleFractionStructure firstFraction = new SimpleFractionStructure(1, 3);
        SimpleFractionStructure secondFraction = new SimpleFractionStructure(2, 6);
        SimpleFractionStructure result = new SimpleFractionStructure(1, 1); 

        Assert.That(SimpleFractionStructure.Divisive(firstFraction, secondFraction), Is.EqualTo(result));
    }
    
    [Test] 
    public void SubtractFailed()
    {
        SimpleFractionStructure firstFraction = new SimpleFractionStructure(1, 3);
        SimpleFractionStructure secondFraction = new SimpleFractionStructure(1, 6);
        SimpleFractionStructure result = new SimpleFractionStructure(1, 1); 
        
        Assert.That(SimpleFractionStructure.Divisive(firstFraction, secondFraction), Is.Not.EqualTo(result));
    }
    
    [Test] 
    public void MultiplyFailed()
    {
        SimpleFractionStructure firstFraction = new SimpleFractionStructure(1, 3);
        SimpleFractionStructure secondFraction = new SimpleFractionStructure(1, 6);
        SimpleFractionStructure result = new SimpleFractionStructure(1, 1); 
        
        Assert.That(SimpleFractionStructure.Divisive(firstFraction, secondFraction), Is.Not.EqualTo(result));
    }
    
    [Test] 
    public void DivisiveFailed()
    {
        SimpleFractionStructure firstFraction = new SimpleFractionStructure(1, 3);
        SimpleFractionStructure secondFraction = new SimpleFractionStructure(0, 6);
        SimpleFractionStructure result = new SimpleFractionStructure(1, 1); 
        
        Assert.That(SimpleFractionStructure.Divisive(firstFraction, secondFraction), Is.Not.EqualTo(result));
    }
}