using System;
namespace Tester
{
	public class MainClass
	{
		public static void Main (string[] args)
		{
			
			//Tester.DelegateUser.DelegateTest<int>.DelMain(args);
			
			//Tester.RefOut.RefOutTest.RefOutMain(args);

			//Tester.PartialUser.PartialMain(args);
			
			//Tester.Delegates.EventHandler.Sample.EHMain();
			
			// Tester.Misc.RenameTest.RNMain("hello world");
			//Tester.Misc.Sorter.Example.SorterMain();
			//Tester.Misc.RegexTest.RegexMain();
            Twiglet.Sample.Delegate.DelegateSampler.DelegateSamplerMain();
            Twiglet.Sample.Event.EventSampler.EventSamplerMain(args);
            Console.WriteLine("Finished");
		}
	}
}

