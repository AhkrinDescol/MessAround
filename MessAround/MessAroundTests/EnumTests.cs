using Xunit;
using MessAround;

namespace MessAroundTests
{
	public class EnumTests
	{
		private enum OuterEnumExample
        {
            ValueOne = 5,
            ValueTwo = 29,
            ValueThree = 342
        }
    
		[Theory]
		[InlineData(EnumExperiments.InnerEnumExample.ValueOne, 1)]
		[InlineData(EnumExperiments.InnerEnumExample.ValueTwo, 40)]
		[InlineData(EnumExperiments.InnerEnumExample.ValueThree, 3)]
		public void MyEnumValueReturnsInnerInt(EnumExperiments.InnerEnumExample e, int expected)
		{
			Assert.Equal(expected, EnumExperiments.MyEnumValue(e));
		}

		[Fact]
		public void GetEnumElementsReturnsArray()
		{
			var elementsMap = EnumExperiments.GetEnumElements(OuterEnumExample.ValueOne);
			Assert.Equal(elementsMap.GetValue(0), OuterEnumExample.ValueOne);
			Assert.Equal(elementsMap.GetValue(1), OuterEnumExample.ValueTwo);
			Assert.Equal(elementsMap.GetValue(2), OuterEnumExample.ValueThree);
		}
	}
}