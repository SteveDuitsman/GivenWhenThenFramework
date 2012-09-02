using NUnit.Framework;
using Rhino.Mocks;

namespace TestFixtures
{
	public class Given_When_Then_Mocked_Test_Base
	{
		protected MockRepository Mocks;

		[SetUp]
		public void MainSetup()
		{
			SetupMembers();
			Mocks = new MockRepository();
			using (Mocks.Record())
			{
				SetupMockedInterfaces();
				SetupMockedEntityUnderTest();
			}
			using (Mocks.Playback())
			{
				Given();
				When();
			}
		}

		[TearDown]
		protected void MainTearDown()
		{
			Cleanup();
		}

		/// <summary>
		/// This is where any member setup goes.  
		/// Properties, Fields, Etc. that assist in SetupMockedInterfaces
		/// </summary>
		protected virtual void SetupMembers() { }

		/// <summary>
		/// This is where the Interfaces that support the Entity Under Test are setup and mocked.  
		///	Lots of expects calls here.
		/// 
		/// Derived classes could override this as:
		///		base.SetupMockedInterfaces();
		///		//	Custom Interface setup
		/// </summary>
		protected virtual void SetupMockedInterfaces() { }

		/// <summary>
		/// This is where the entity under test 
		///	(that we call methods on in the When or Then methods) 
		///	is created from the mocked interfaces.
		/// </summary>
		protected virtual void SetupMockedEntityUnderTest() { }

		protected virtual void Given() { }
		protected virtual void When() { }
		protected virtual void Cleanup() { }
	}
}