using System;

namespace HelloLibrary
{
	public class Cat : IAnimal
	{
		public Cat ()
		{
		}
		
		public string Talk()
		{
			return "Meow";
		}
	}
}

