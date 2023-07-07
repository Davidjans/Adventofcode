

class Program
{
	
	static void Main(string[] args)
	{
		
		String[] lines = File.ReadLines("D:/HKU/AdventOfCode/AOC2/input.txt").ToArray<string>();

		Console.WriteLine("Dis is da answer for 1: " + DavidDay2_1(lines));

		Console.WriteLine("Dis is da answer for 2: " + DavidDay2_2(lines));


		int DavidDay2_1(string[] lines)
		{
			int xPos = 0;
			int depth = 0;
			for (int i = 0; i < lines.Length; i++)
			{
				if (lines[i].Contains("up"))
				{
					depth -= int.Parse(lines[i][lines[i].Length - 1].ToString());
				}
				else if (lines[i].Contains("down"))
				{
					depth += int.Parse(lines[i][lines[i].Length - 1].ToString());
				}
				else if (lines[i].Contains("forward"))
				{
					xPos += int.Parse(lines[i][lines[i].Length - 1].ToString());
				}
			}
			return xPos * depth;
		}

		int DavidDay2_2(string[] lines)
		{
			int xPos = 0;
			int depth = 0;
			int aim = 0;
			for (int i = 0; i < lines.Length; i++)
			{
				int number = 0;
				if (lines[i].Contains("up"))
				{
					number = int.Parse(lines[i][lines[i].Length - 1].ToString());
					aim -= number;
					//depth -= number;
					
				}
				else if (lines[i].Contains("down"))
				{
					number = int.Parse(lines[i][lines[i].Length - 1].ToString());
					aim += number;
					//depth += number;
				}
				else if (lines[i].Contains("forward"))
				{
					number = int.Parse(lines[i][lines[i].Length - 1].ToString());
					xPos += number;
					depth += number * aim;
				}
			}
			return xPos * depth;
		}
	}
}