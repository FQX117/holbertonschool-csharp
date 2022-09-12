using NUnit.Framework;

namespace MyMath.Tests
{
	[testc]
	public class Tests
	{

		[testm]
		public void Test1()
		{
			int[,] matrix = new int[2, 2] { { 6, 2 }, { 2, 4 } };
			int num = 2;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(new int[2, 2] { { 3, 1 }, { 1, 2 } }, output);
		}
		[testm]
		public void Test2()
		{
			int[,] matrix = null;
			int num = 2;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(null, output);
		}
		[testm]
		public void Test3()
		{
			int[,] matrix = new int[2, 2] { { 6, 2 }, { 2, 4 } };
			int num = 0;

			int[,] output = Matrix.Divide(matrix, num);

			Assert.AreEqual(null, output);
		}

	}
}