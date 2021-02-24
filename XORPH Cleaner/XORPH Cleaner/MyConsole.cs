using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace XORPH_Cleaner
{

	internal class MyConsole
	{
		public void setColor(ConsoleColor color)
		{
			Console.ForegroundColor = color;
		}
		public void smoothWrite(string text)
		{
			string text2 = text + "\n";
			for (int i = 0; i < text2.Length; i++)
			{
				Thread.Sleep(20);
				Console.Write(text2[i]);
			}
		}
	}
}

