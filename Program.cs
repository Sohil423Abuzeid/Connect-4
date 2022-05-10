using System;
using static System.Console;

namespace connect_4
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLine("easy rule enter the number of he row ^_^");
			WriteLine("by : Smile Man ^_^\n team : Red Planet");
			for (int i = 0; i < 100; i++)
			{
				bool a = false;
				int s = 0;
				char[,] xo = new char[7, 6] {
				{'-','-','-','-','-','-'},
				{'-','-','-','-','-','-'},
				{'-','-','-','-','-','-'},
				{'-','-','-','-','-','-'},
				{'-','-','-','-','-','-'},
				{'-','-','-','-','-','-'},
				{'-','-','-','-','-','-'} };
				
				for (int o = 0; o <43; o++)//game
				{
					WriteLine("1|2|3|4|5|6|7");
					for (int x = 0; x < 6; x++)// print table
					{
						for (int c = 0; c < 7; c++)
						{
							Write("{0}|", xo[c,x]);
						}
						WriteLine();
					}
					int te;
					if (o % 2 == 0) te = 316;
					else te = 352;
					for (int b = 0; b < 4; b++)// win tester
					{
						for (int n = 0; n <6; n++)
							if ((xo[b,n]+ xo[b+1, n] + xo[b+2, n] + xo[b+3,n] ) ==te)
							{
								WriteLine("winner");
								a = true;
								break;
							}
						if (a) break;
						for (int m = 3; m < 6; m++)
							if ((xo[b,m] + xo[b + 1,m-1] + xo[b + 2,m-2] + xo[b + 3,m-3]) == te)
							{
								WriteLine("winner");
								a = true;
								break;
							}
						if (a) break;
						for (int m = 0; m < 3; m++)
							if ((xo[b, m] + xo[b + 1, m + 1] + xo[b + 2, m + 2] + xo[b + 3, m + 3]) == te)
							{
								WriteLine("winner");
								a = true;
								break;
							}
						if (a) break;
					}
					for (int b = 0; b <7; b++)//WORK
					{
						for (int n = 0; n < 3; n++)
							if ((xo[b, n] + xo[b,n+1] + xo[b,n+2] + xo[b,n+3]) == te)
							{
								WriteLine("winner");
								a = true;
								break;
							}
					}
					if (a) break;
					if (o == 43) { a = true; WriteLine("draw"); };
					if (a) break;        
					for (int v = 0; v < 100; v++)
					{
						s = int.Parse(ReadLine());
						if (s > 0 && s < 8) break;
						WriteLine("out of range");
					}
					for (int z = 5; z >-1; z--)
						if (xo[s-1,z] == '-')
						{
							if (o % 2 == 0) xo[(s-1), z] = 'X';
							else xo[s - 1, z] = 'O';
							break;
						}
				}
				WriteLine("want to play again ?(y,n)");
				char bol = Convert.ToChar(ReadLine());
				if (bol == 'n' || bol == 'N')
					break;
			}
			WriteLine("thanks bro");
			ReadKey();
		}
	}
}
