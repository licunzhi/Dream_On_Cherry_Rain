using System;
namespace OperatorConsoleApp
{
	public class DelegateTest
	{

		static int num = 10;
		public DelegateTest()
		{
		}

		public static int AddNum(int p)
		{
			return num + p;
		}



        public static int MinusNum(int p)
        {
            return num - p;
        }
    }
}

