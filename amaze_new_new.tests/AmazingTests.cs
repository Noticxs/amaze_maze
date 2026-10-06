namespace Tests;

[TestFixture]
public class AmazingTests
{
    [Test]
    public void Seed0Size15X20()
    {
        var expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
:--:--:--:--:--:--:--:--:--:--:  :--:--:--:--:
I                             I        I     I 
:  :--:--:--:--:  :--:--:  :--:  :--:--:  :--:
I           I     I     I  I     I     I     I 
:--:--:--:  :  :  :  :  :--:  :  :  :  :--:  :
I        I  I  I     I  I     I     I     I  I 
:--:  :  :--:  :  :--:  :  :--:--:--:--:  :  :
I     I  I     I     I     I  I           I  I 
:  :--:  :  :--:--:  :--:--:  :  :--:  :--:  :
I  I  I     I        I     I  I     I     I  I 
:  :  :  :--:  :--:--:  :--:  :--:  :--:  :  :
I  I  I     I  I     I        I     I  I  I  I 
:  :  :--:  :--:  :  :  :--:--:  :--:  :  :  :
I  I     I     I  I  I        I  I     I  I  I 
:  :  :  :--:  :--:  :--:  :  :  :  :--:  :  :
I  I  I     I     I  I     I  I  I        I  I 
:  :--:--:  :  :  :  :  :  :--:  :  :--:--:  :
I           I  I     I  I  I     I     I  I  I 
:--:--:--:--:  :--:--:  :  :  :--:--:  :  :  :
I     I  I        I     I  I  I        I     I 
:  :  :  :  :  :  :  :--:  :  :--:--:--:  :--:
I  I  I     I  I     I     I  I        I     I 
:--:  :  :--:  :--:--:  :--:  :  :--:  :--:  :
I     I  I     I        I     I  I     I  I  I 
:  :--:  :  :--:  :--:--:  :--:  :  :--:  :  :
I        I  I     I     I     I  I        I  I 
:  :--:--:  :--:--:  :  :--:  :  :--:--:  :  :
I        I     I     I     I  I  I     I     I 
:--:--:  :--:  :  :  :--:  :  :  :  :--:--:  :
I     I     I  I  I  I     I     I  I        I 
:  :  :--:  :  :  :  :  :--:--:--:  :  :--:--:
I  I        I     I  I           I  I  I     I 
:  :--:--:--:--:--:--:--:  :--:  :  :  :--:  :
I  I        I  I  I     I     I  I           I 
:  :--:  :  :--:--:  :  :--:  :--:--:--:--:--:
I     I  I  I     I  I  I           I        I 
:--:  :  :  :  :  :  :--:  :--:--:--:  :--:--:
I     I  I     I     I              I        I 
:  :--:--:--:--:  :  :  :  :  :--:  :--:--:  :
I                 I  I     I     I           I 
:--:--:--:--:--:--:--:--:--:--:--:  :--:--:--:
";
        Amazing.random = new Random(0);
        Amazing.doit(15, 20);
        System.Console.WriteLine(Amazing.result);
        Assert.That(Amazing.result, Is.EqualTo(expected), "Should have the maze that was expected");
    }

    [Test]
    public void Seed100Size4X5()
    {
        var expected = @"Amazing - Copyright by Creative Computing, Morristown, NJ
:--:--:--:  :
I           I 
:  :--:  :--:
I     I  I  I 
:--:  :  :  :
I  I  I     I 
:  :  :--:  :
I  I     I  I 
:  :--:  :  :
I        I  I 
:--:--:--:  :
";
        Amazing.random = new Random(100);
        Amazing.doit(4, 5);

        Assert.That(Amazing.result, Is.EqualTo(expected), "Should have the maze that was expected");
    }
}
