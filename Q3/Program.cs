using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value1 = "aLLeN kUO";
			string value2 = value1.ToLower();//先將所有字串改成小寫
			Console.WriteLine(value2.Substring(0,1).ToUpper()+value2.Substring(1,5)+value2.Substring(6,1).ToUpper()+value2.Substring(7,2));
			                  //取出字串的第0位並且變成大寫"A"+取出字串的第1位並往後取5位"llen "+取出字串的第6位並且變成大寫"K"+取出字串第7位並往後取兩位"uo"
		}
	}
}
