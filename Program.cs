using System;
using System.Collections.Generic;
namespace BA2H
{
	class Program
	{
		public static int Hammingdistance(string p, string q)
		{
			if (p.Length != q.Length)
				return -1;
			int i = 0;
			int count = 0;
			while (i < p.Length)
			{
				if (p.Substring(i, 1) != q.Substring(i, 1))
					count++;


				i++;

			}
			return count;
		}
		public static int Distancebetweenpatternandstrings(string pattern, List<string> dna)
		{
			int k = pattern.Length;
			int distance = 0;
			foreach (string text in dna)
			{
				int hammingdistance = int.MaxValue;
				for (int i = 0; i < text.Length - k + 1; i++)
				{
					string s = text.Substring(i, k);
					if (hammingdistance > Hammingdistance(pattern, s))
						hammingdistance = Hammingdistance(pattern, s);
						

				}
				distance += hammingdistance;
			}
			return distance;
		}
		static void Main(string[] args)
		{
			string pattern = "AAA";
			List<string> pl = new List<string>();
			pl.Add("TTACCTTAAC");
			pl.Add("GATATCTGTC");
			pl.Add("ACGGCGTTCG");
			pl.Add("CCCTAAAGAG");
			pl.Add("CGTCAGAGGT");
			int g = Distancebetweenpatternandstrings(pattern, pl);
			Console.WriteLine("Udaljenost je:{0}", g);
			Console.WriteLine("kraj");
				
		}
	}
}
