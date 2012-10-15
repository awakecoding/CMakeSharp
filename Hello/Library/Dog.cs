using System;

namespace HelloLibrary
{
	public class Dog : IAnimal
	{
		public Dog ()
		{
		}
		
		public string Talk()
		{
			return "Woof";
		}
	}
}

