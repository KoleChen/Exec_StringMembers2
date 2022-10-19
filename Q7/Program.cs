using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入您的手機號碼:");
			string PhoneNumber =Console.ReadLine();
			if(string.IsNullOrEmpty(PhoneNumber))
			{
				Console.WriteLine("您沒有輸入號碼");
				return;
			}
			if(PhoneNumber.Length!=10)
			{
				Console.WriteLine("號碼輸入格式錯誤");
				return;
			}
			else
			{
				string NewNumber =PhoneNumber.Substring(0,4)+new string('*',4)+PhoneNumber.Substring(8,2);
				Console.WriteLine(NewNumber);
			}

		}
	}
}
