using System;
using Xunit;

namespace facsol;

public class UnitTests
{
    [Fact]
    public void negativethrowserror()
    {
        try{
            factorial.compute(-1);
        }
        catch (Exception e) {
            Assert.True(e.Message == "negative");
        }
    }

    [Fact]
    public void zerogivesone() {
        Assert.True(factorial.compute(0) == 1);
    }

    [Fact]
    public void onegivesone() {
        Assert.True(factorial.compute(1) == 1);
    }

    [Fact]
    public void twogivestwo() {
        Assert.True(factorial.compute(2) == 2);
    }

    [Fact]
    public void threegivessix() {
        Assert.True(factorial.compute(3) == 6);
    }
}
