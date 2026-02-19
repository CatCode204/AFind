namespace LineSource
{
	public class LineSourceFactory
	{
		public static LineSource[] CreateFileLinesSource(string path, bool isSkipOffline)
		{
			string pattern;
			int lastSepIndx = path.LastIndexOf(Path.PathSeparator);

			if (lastSepIndx < 0)
			{
				pattern = path;
				path = ".";
			} else
			{
				pattern = path[(lastSepIndx + 1)..];
				path = path[..lastSepIndx];
			}

			var directoryInfo = new DirectoryInfo(path);

			if (directoryInfo.Exists)
			{
				var files = directoryInfo.GetFiles(pattern);

				if (isSkipOffline)
				{
					files = files.Where(f => !f.Attributes.HasFlag(FileAttributes.Offline)).ToArray();
				}

				return files.Select(f => new FileLineSource(f.FullName)).ToArray();
			}

			throw new DirectoryNotFoundException();
		}

		public static LineSource CreateConsoleLineSource()
		{
			return new ConsoleLineSource();
		}
	}
}