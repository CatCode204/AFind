namespace LineFilter
{
	public class FilterOptions
	{
		public bool FilterContains { get; set; } = true;
		public List<String> FilterStrings { get; set; } = new List<String>();
		public int FilterMaxLineNumber { get; set; } = -1; // if less than 0 than no filter on line number
	}
}
