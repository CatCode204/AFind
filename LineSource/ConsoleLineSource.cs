namespace LineSource
{
	public class ConsoleLineSource : LineSource
	{
		public override Line[] GetLines()
		{
			List<Line> lines = new List<Line>();
			string? s;

			int lineNum = 0;

			while ((s = Console.ReadLine()) != null)
			{
				Line newLine = new Line() { LineNumber = ++lineNum, Text = s};
				lines.Add(newLine);
			}

			return lines.ToArray();
		}
	}
}
