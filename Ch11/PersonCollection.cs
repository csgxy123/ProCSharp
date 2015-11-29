using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCSharp
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		
		public Person(string first, string last, int age)
		{
			FirstName = first;
			LastName = last;
			Age = age;
		}
		
		public override string ToString()
		{
			return FirstName + " " + LastName + " " + Age;
		}
	}
	public class PersonCollection : IEnumerable
	{
		private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();
		
		public Person this[string name]
		{
			get { return (Person)listPeople[name]; }
			set { listPeople[name] = value; }
		}
		
		public void ClearPeople()
		{
			listPeople.Clear();
		}
		
		public int Count
		{
			get { return listPeople.Count; }
		}
		
		IEnumerator IEnumerable.GetEnumerator()
		{
			return listPeople.GetEnumerator();
		}
	}
}