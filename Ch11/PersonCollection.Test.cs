using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCSharp
{
	public class Ch11
	{
		public static void Test()
		{
			Console.WriteLine("***** Fun with Indexers *****\n");
			
			PersonCollection myPeople = new PersonCollection();
			
			myPeople["Homer"] = new Person("Homer", "Simpson", 40);
			myPeople["Marge"] = new Person("Marge", "Simpson", 38);
			
			Person homer = myPeople["Homer"];
			Console.WriteLine(homer.ToString());
			
			Console.WriteLine();
		}
	}
}