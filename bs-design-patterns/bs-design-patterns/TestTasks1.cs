using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace bs_design_patterns
{
    class TestTasks1
    {
		public static void Main1()
		{
			var t = M1();
			t.ContinueWith(x => Console.WriteLine("after M1"));
		}

		async static Task<string> M1()
		{
			Console.WriteLine("before call M2");
			var txt = await M2();
			Console.WriteLine("after call M2");
			return txt;
		}

		async static Task<string> M2()
		{
			var lines = await File.ReadAllLinesAsync(@"C:\tmp\test1.txt");
			Console.WriteLine("after lines");
			return lines.ToString();
		}
	}
}
