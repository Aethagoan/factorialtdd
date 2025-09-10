namespace facsol;

public class factorial
{
	public static long compute(int n)
	{
		if (n < 0)
		{
			throw new ArgumentException("Input must be a non-negative integer.");
		}
		if (n == 0)
		{
			return 1;
		}
		long result = 1;
		for (int i = 1; i <= n; i++)
		{
			result *= i;
		}
		return result;
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		int n = -1;
		if (args.Length > 0)
		{
			if (!int.TryParse(args[0], out n) || n < 0)
			{
				Console.WriteLine("Invalid input. Please enter a non-negative integer.");
				return;
			}
		}
		else
		{
			Console.Write("Enter a non-negative integer: ");
			string input = Console.ReadLine();
			if (!int.TryParse(input, out n) || n < 0)
			{
				Console.WriteLine("Invalid input. Please enter a non-negative integer.");
				return;
			}
		}

		string output = "";
		for (int i = 0; i <= n; i++)
		{
			long result = factorial.compute(i);
			output += $"{result},{i}\n";
		}

		Console.WriteLine(output);

		string filePath = "factorial_output.txt";
		using (var writer = new StreamWriter(filePath))
		{
			writer.Write(output);
		}

	}
}