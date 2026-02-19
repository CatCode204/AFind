namespace LineSource
{
	public class FileLineSource : LineSource
	{
		public string Path { get; private set; }

		public FileLineSource(string path)
		{
			Path = path;
		}

		public override Line[] GetLines()
		{
			using (var reader = new StreamReader(new FileStream(Path, FileMode.Open, FileAccess.Read)))
			{
				List<Line> lines = new List<Line>();
				int lineNum = 0;
				string? s;
				while ((s = reader.ReadLine()) != null)
				{
					Line newLine = new Line() { Text = s, LineNumber = ++lineNum }; 
					lines.Add(newLine);
				}
				return lines.ToArray();
			}
			throw new FileNotFoundException();
		}
	}
}
