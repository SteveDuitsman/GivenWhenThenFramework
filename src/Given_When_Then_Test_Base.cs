using NUnit.Framework;

namespace TestFixtures
{
	public class Given_When_Then_Test_Base
	{
		[SetUp]
		public void MainSetup()
		{
			Given();
			When();
		}


		[TearDown]
		protected void MainTearDown()
		{
			Cleanup();
		}

		protected virtual void Given() { }
		protected virtual void When() { }
		protected virtual void Cleanup() { }
	}
}
