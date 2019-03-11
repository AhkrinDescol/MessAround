namespace MessAround
{
	public static class StructExperiments
	{
		public struct Point
		{
			public int X;
			public int Y;
		}

		public static int[] ReturnPointValues(Point p)
		{
			return new[] {p.X, p.Y};
		}
	}
	
	public class MyObject
	{
		public bool myObjBool = true;
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

		// Deconstructers return structs, hence the relevance in this file.
		public void Deconstruct(out int number, out MyObject obj)
		{
			number = myNum;
			obj = myObj;
		}
	}
}