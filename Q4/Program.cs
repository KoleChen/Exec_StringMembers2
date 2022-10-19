using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string date = "1100225";
			string year = date.Substring(0, 3);
			int year1 =Convert.ToInt32(year);
			year1 = year1 + 1911;
			Console.WriteLine($"{year1}{date.Substring(3,4)}");

		}
	}
}
