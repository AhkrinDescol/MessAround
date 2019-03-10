using System;

namespace MessAround
{
	internal static class Program
	{
		private static void Main()
		{
			Console.WriteLine("Hello, World!");
			var baseObj = new DeconstructTest();
			(var myNum, var myObj) = baseObj;
			Console.WriteLine($"{myNum} {myObj.thingy}");
			myObj.thingy = false;
			Console.WriteLine($"{myNum} {baseObj.myObj.thingy}");
		}
	}
	
	public class MyObject
	{
		public bool thingy = true;
	}
	
	public class DeconstructTest
	{
		public int myNum;
		public MyObject myObj;

		public DeconstructTest()
		{
			myNum = 5;
			myObj = new MyObject();
		}

		public void Deconstruct(out int number, out MyObject obj)
		{
			number = myNum;
			obj = myObj;
		}
	}
}