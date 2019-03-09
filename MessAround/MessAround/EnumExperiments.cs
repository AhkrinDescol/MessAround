using System;

namespace MessAround
{
	public static class EnumExperiments
	{
		public enum InnerEnumExample
		{
			ValueOne = 1,
			ValueTwo = 40,
			ValueThree = 3
		}

		public static int MyEnumValue(InnerEnumExample e)
	{
			return (int) e;
		}

		public static Array GetEnumElements(Enum e)
		{
			return Enum.GetValues(e.GetType());
		}
	}
}