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
}