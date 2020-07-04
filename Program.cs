using System;

namespace SolidRefactoring
{
	using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Program
	{
		private static Computer _computer;
		public static void Main()
		{
			_computer = new Computer();
			_computer.Test();
		}
	}

    public interface IComponent
    {
		public string doWork() ;
    }

	public abstract class Device {
		protected List<IComponent> components = new List<IComponent>();


		public Device() {
			components.Add(new MotherBoard());
			components.Add(new Cpu());
			components.Add(new Ram());
		}
		public void Test()
		{
			foreach (IComponent comp in components) {
				Console.WriteLine(comp.doWork()) ;
			}			
		}
	}

    public class Computer : Device
	{		
		public Computer()
		{
			components.Add(new HardDrive());
			components.Add(new PowerSupply());		
		}
	}

	public class Phone : Device
	{
		public Phone()
		{
			components.Add(new Screen());
            components.Add(new Battery());
        }
	}

	public class Mobile : Device { 
	}

	internal class PowerSupply : IComponent
	{
        public string doWork()
        {
			return ProducePower();
        }

        public string ProducePower()
		{
			return "Producing Power";
		}
	}

	internal class HardDrive : IComponent
	{
        public string doWork()
        {
			return WritingData();
        }

        public string WritingData()
		{
			return "Writing Data";
		}
	}

	internal class Ram : IComponent
	{
        public string doWork()
        {
			return StoringData();
        }

        public string StoringData()
		{
			return "Storing Data";
		}
	}

	internal class Cpu : IComponent
	{
		public string Calculate()
		{
			return "Calculating";
		}

        public string doWork()
        {
			return Calculate();
        }
    }

	internal class MotherBoard : IComponent
	{
        public string doWork()
        {
			return Motherboarding();
        }

        public string Motherboarding()
		{
			return "Connecting everything";
		}
	}

	internal class Screen : IComponent
	{
		public string doWork()
		{
			return Screening();
		}

		public string Screening()
		{
			return "Show something";
		}
	}


	internal class Battery : IComponent
	{
		public string doWork()
		{
			return StorePower();
		}

		public string StorePower()
		{
			return "Store and provide power";
		}
	}


}
