using System;

namespace FirstApplication.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, What is your name?");
			string name = Console.ReadLine();
			Console.WriteLine("Hello, {0}", name);
			Console.WriteLine("Hey,{0} where you from?", name);
			string town = Console.ReadLine();
			Console.WriteLine("Hello {0} from {1}", name, town);
			Console.WriteLine("{0}, at this moment you in {1}?", name, town);
			Console.ReadLine();

		}
	}
}