using System;

namespace FirstApplication.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Please, enter your name:");
		    var name = Console.ReadLine();
			Console.WriteLine("Please, enter your age: ");
	        var age = checked((byte)int.Parse(Console.ReadLine()));
			Console.WriteLine("Your name is {0} and age is {1} ", name, age);
			Console.Write("Please, enter your date of birth: ");
			var birthdate = Console.ReadLine();
			Console.WriteLine("Your birthdate is {0}", birthdate);


		} 

	}
}