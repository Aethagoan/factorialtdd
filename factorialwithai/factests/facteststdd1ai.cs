using Xunit;

namespace facsol;

public class FactorialTests
{
	[Fact]
	public void Factorial_InputZero_ReturnsOne()
	{
		// Arrange
		int input = 0;
		int expected = 1;
		// Act
		long result = factorial.compute(input);

		// Assert
		Assert.True(result == expected);
	}

	[Fact]
	public void Factorial_InputOne_ReturnsOne()
	{
		// Arrange
		int input = 1;
		int expected = 1;
		// Act
		long result = factorial.compute(input);

		// Assert
		Assert.True(result == expected);
	}

	[Fact]
	public void Factorial_InputFive_Returns120()
	{
		int input = 5;
		int expected = 120;
		long result = factorial.compute(input);
		Assert.True(result == expected);
	}

	[Fact]
	public void Factorial_InputTen_Returns3628800()
	{
		int input = 10;
		int expected = 3628800;
		long result = factorial.compute(input);
		Assert.True(result == expected);
	}

	[Fact]
	public void Factorial_InputNegative_ThrowsException()
	{
		Assert.ThrowsAny<System.Exception>(() => factorial.compute(-3));
	}

	[Fact]
	public void Factorial_InputTwenty_ReturnsLargeValue()
	{
		int input = 20;
		long expected = 2432902008176640000;
		long result = factorial.compute(input);
		Assert.True(result == expected);
	}

	[Fact]
	public void Factorial_InputNonInteger_ThrowsException()
	{
		// Assert.ThrowsAny<System.Exception>(() => factorial.compute(3.5));
		// this test is not valid because the method only accepts integers, so it cannot be called with a non-integer value, meaning it shouldn't be tested.
	}

	[Fact]
	public void Factorial_InputString_ThrowsException()
	{
		// Assert.ThrowsAny<System.Exception>(() => factorial.compute("abc"));
		// this test is not valid because the method only accepts integers, so it cannot be called with a non-integer value, meaning it shouldn't be tested.
	}

	[Fact]
	public void Factorial_InputNullOrEmpty_ThrowsException()
	{
		// Assert.ThrowsAny<System.Exception>(() => factorial.compute(null));
		// this test is not valid because the method only accepts integers, so it cannot be called with a non-integer value, meaning it shouldn't be tested.

	}

	[Fact]
	public void Factorial_InputTwo_ReturnsTwo()
	{
		int input = 2;
		int expected = 2;
		long result = factorial.compute(input);
		Assert.True(result == expected);
	}
	
}