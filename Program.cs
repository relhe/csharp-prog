public class Program
{
	public static void Main(string[] args)
	{
		string name;
		string firstName;
		Console.Write("Enter your first name: ");
		firstName = Console.ReadLine();
		Console.Write("Enter your last name: ");
		name = Console.ReadLine();
		Console.WriteLine($"Hello {firstName} {name}! you are welcome to C# programming.");
	}
}