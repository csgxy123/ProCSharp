using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCSharp
{
	// Derived from class EventArgs to pass customed 
	// data to the delegates
	public class CarEventArgs : EventArgs
	{
		public readonly string msg;
		public CarEventArgs(string message)
		{
			msg = message;
		}
	}
	public class Car
	{
		public int CurrentSpeed { get; set; }
		public int MaxSpeed { get; set; }
		public string PetName { get; set; }
		private bool carIsDead;
		
		public Car()
		{
			MaxSpeed = 100;
		}
		public Car(string name, int maxSp, int currSp)
		{
			CurrentSpeed = currSp;
			MaxSpeed = maxSp;
			PetName = name;
		}
		
		public void Accelerate(int delta)
		{
			if (carIsDead)
			{
				if (Exploded != null)
				{
					Exploded(this, new CarEventArgs("Sorry, this car is dead..."));
				}
			}
			else
			{
				CurrentSpeed += delta;
				
				if (10 == (MaxSpeed - CurrentSpeed) && AboutToBlow != null)
				{
					AboutToBlow(this, new CarEventArgs("Careful buddy! Gonna blow!"));
				}
				
				if (CurrentSpeed >= MaxSpeed)
					carIsDead = true;
				else
					Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
			}
		}
		
		// Define the delegate type
		public delegate void CarEngineHander<T>(object sender, T e);
		
		// Event is used to simplify using delegates
		public event CarEngineHander<CarEventArgs> Exploded;
		public event CarEngineHander<CarEventArgs> AboutToBlow;
	}
}