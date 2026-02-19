namespace AFindOptions
{
	public class AFindOptionsBuilder
	{
		public bool IsContains { get; set; } = true;
		public bool IsCountMode { get; set; } = false;
		public bool IsShowLineNumbers { get; set; } = false;
		public bool IsCaseSensitive { get; set; } = true;
		public bool IsSkipOffline { get; set; } = true;
		public string Path { get; set; } = String.Empty;
		public string StrToFind { get; set; } = String.Empty;
		public bool IsHelpMode { get; set; } = false;

		private readonly AFindOptions options = new();

		public AFindOptions Build()
		{
			options.IsContains = IsContains;
			options.IsCountMode = IsCountMode;
			options.IsCaseSensitive = IsCaseSensitive;
			options.IsShowLineNumbers = IsShowLineNumbers;
			options.IsSkipOffline = IsSkipOffline;
			options.Path = Path;
			options.StrToFind = StrToFind;
			options.IsHelpMode = IsHelpMode;
			return options;
		}
	}
}
