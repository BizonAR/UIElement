using System;


namespace UIElement
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int maxValue = 100;

			Random random = new Random();

			int healthPercent = random.Next(maxValue + 1);
			string nameBar = "Health Bar";
			int lengthBar = 10;

			DrawBar(healthPercent, nameBar, lengthBar);
		}

		private static void DrawBar(int percent, string nameBar, int lengthBar)
		{
			char openingSymbol = '[';
			char closingSymbol = ']';
			char symbolFilledInBar = '#';
			char symbolEmptyInBar = '_';
			int maxPercent = 100;

			Console.Write($"{nameBar} при {percent}%: {openingSymbol}");
			int filledLength = lengthBar * percent / maxPercent;

			FillingBar(filledLength, symbolFilledInBar);

			int emptyLength = lengthBar - filledLength;

			FillingBar(emptyLength, symbolEmptyInBar);

			Console.Write(closingSymbol);
			Console.WriteLine();
		}

		private static void FillingBar(int count, char symbol)
		{
			for (int i = 0; i < count; i++)
			{
				Console.Write(symbol);
			}
		}
	}
}
