using System;

namespace FirstApplication.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			const string MyName = "Anton";
            ushort age = 27;
			bool pet = false;
			double foot = 43;


			Console.WriteLine("Hello, my name is " + MyName);
			Console.WriteLine("I'm " + age);
            Console.WriteLine("Do I have a pet?" + pet);
			Console.WriteLine("My shoe size is" + foot);

			Console.ReadKey();



		}

	}
}