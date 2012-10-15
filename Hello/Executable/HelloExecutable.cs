using System;
using System.Collections.Generic;

using HelloLibrary;

namespace HelloExecutable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Hello, World!");
			
			List<IAnimal> animals = new List<IAnimal>();
			
			animals.Add(new Cat());
			animals.Add(new Dog());

			foreach (IAnimal animal in animals)
				Console.WriteLine(animal.Talk());
		}
	}
}
