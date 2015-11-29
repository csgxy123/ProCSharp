using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCSharp
{
	public class Ch10
	{
		public static void Test()
		{
			Console.WriteLine("***** More Fun With Lambdas *****\n");
			
			Car c1 = new Car("SlugBug", 100, 10);
			
			c1.AboutToBlow += (sender, e) => { Console.WriteLine(e.msg); };
			c1.Exploded += (sender, e) => { Console.WriteLine(e.msg); };
			
			Console.WriteLine("\n***** Speeding up *****");
			for (int i = 0; i < 6; ++i)
				c1.Accelerate(20);
				
			Console.WriteLine();
		}
	}
}