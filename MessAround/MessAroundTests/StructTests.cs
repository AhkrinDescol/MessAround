using Xunit;
using MessAround;

namespace MessAroundTests
{
	// Testing to see the behaviour of a struct in relation to objects.
	public class StructTests
	{
		[Fact]
		public void StructsAreCopiedNotDoublyReferredTo()
		{
			StructExperiments.Point p1;
			p1.X = 1;
			p1.Y = 2;
			StructExperiments.Point p2 = p1;
			p1.X = 5;
			Assert.True(p1.X != p2.X);
		}

		[Fact]
		public void NewStructIsStillAValue()
		{
			var p1 = new StructExperiments.Point(); // X and Y are 0/default.
			var p2 = p1;
			p2.X = 1;
			Assert.True(p1.X != p2.X);
		}
	}
}