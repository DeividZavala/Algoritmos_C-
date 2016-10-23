using System;
using System.Linq;

namespace sum_max_min
{
	class MainClass
	{
		
		public static int Sum(int[] n)
		{
			Console.WriteLine (n.Sum () - n.Max () - n.Min ());
			return n==null||n.Length<3 ? 0:n.Sum()-n.Max()-n.Min();
		}
		/*
		public static int SumHard(int[] numbers)
		{
			if(numbers==null)
			{
				return 0;
			}
			if(numbers.Length<=1)
			{
				return 0;
			}
			int min=0;
			int max=0;
			for(int i=1; i<numbers.Length;i++)
			{
				if(numbers[i]<numbers[min])
				{
					min=i;
				}
				if(numbers[i]>numbers[max])
				{
					max=i;
				}
			}
			int result=0;
			for(int i=0; i<numbers.Length;i++)
			{
				if(i!=min && i!=max)
				{
					result+=numbers[i];
				}
			}
			Console.WriteLine (result);
			return result;
		}*/

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			int[] arr = new int[] { 6, 2, 1, 8, 10 };
			Sum (arr);
		}
	}
}
