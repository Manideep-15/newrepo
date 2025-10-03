using Xunit;
using StringUtils;

namespace StringUtils.Tests;

public class StringHelperTests
{
    [Fact]
    public void IsPalindrome_WithPalindrome_ReturnsTrue()
    {
        Assert.True(StringHelper.IsPalindrome("madam"));
        Assert.True(StringHelper.IsPalindrome("Race car"));
    }

    [Fact]
    public void IsPalindrome_WithNonPalindrome_ReturnsFalse()
    {
        Assert.False(StringHelper.IsPalindrome("hello"));
    }

    [Fact]
    public void Reverse_WithValidString_ReturnsReversed()
    {
        Assert.Equal("olleh", StringHelper.Reverse("hello"));
    }

    [Fact]
    public void Reverse_WithNull_ReturnsNull()
    {
        Assert.Null(StringHelper.Reverse(null));
    }

    [Fact]
    public void WordCount_WithWords_ReturnsCorrectCount()
    {
        Assert.Equal(4, StringHelper.WordCount("This is a test"));
    }

    [Fact]
    public void WordCount_WithEmptyString_ReturnsZero()
    {
        Assert.Equal(0, StringHelper.WordCount(""));
    }
}
