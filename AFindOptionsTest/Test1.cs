using AFindOptions;

namespace AFindOptionsTest
{
	[TestClass]
	public sealed class Test1
	{
		[TestMethod]
		public void TestAFindOptionsDirector1()
		{
			string[] args = { "/v", "/c", "/n", "/i", "/offline", "/?"};
			AFindOptionsBuilder builder = new AFindOptionsBuilder();
			var director = new AFindOptionsDirector(builder);
			var options = director.Direct(args);

			Assert.IsNotNull(options);
			Assert.IsFalse(options.IsContains);
			Assert.IsTrue(options.IsCountMode);
			Assert.IsTrue(options.IsShowLineNumbers);
			Assert.IsFalse(options.IsCaseSensitive);
			Assert.IsFalse(options.IsSkipOffline);
			Assert.IsEmpty(options.StrToFind);
			Assert.IsEmpty(options.Path);
			Assert.IsTrue(options.IsHelpMode);
		}

		[TestMethod]
		public void TestAFindOptionsDirector2()
		{
			string[] args = { "Hello World", "hello.txt" };
			AFindOptionsBuilder builder = new AFindOptionsBuilder();
			var director = new AFindOptionsDirector(builder);
			var options = director.Direct(args);

			Assert.IsNotNull(options);
			Assert.IsTrue(options.IsContains);
			Assert.IsFalse(options.IsCountMode);
			Assert.IsFalse(options.IsShowLineNumbers);
			Assert.IsTrue(options.IsCaseSensitive);
			Assert.IsTrue(options.IsSkipOffline);
			Assert.AreEqual("Hello World", options.StrToFind);
			Assert.AreEqual("hello.txt", options.Path);
			Assert.IsFalse(options.IsHelpMode);
		}
	}
}
