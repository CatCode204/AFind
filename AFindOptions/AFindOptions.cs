namespace AFindOptions
{
	public class AFindOptions
	{
		public bool IsContains { get; set; }
		public bool IsCountMode { get; set; }
		public bool IsShowLineNumbers { get; set; }
		public bool IsCaseSensitive { get; set; }
		public bool IsSkipOffline { get; set; }
		public string Path { get; set; } = String.Empty;
		public string StrToFind { get; set; } = String.Empty;
		public bool IsHelpMode { get; set; }
	}
}
