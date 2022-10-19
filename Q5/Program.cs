using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "Allen";
			Console.Write("請輸入名字,不論大小寫:");
			string input = Console.ReadLine();

			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您沒有輸入");
				return;
			}
			if (name.ToLower() == input.ToLower())
			{
				Console.WriteLine("名字正確");
			}
			else
			{
				Console.WriteLine("名字錯誤");
			}
		}
	}
}
