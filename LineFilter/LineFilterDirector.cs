namespace LineFilter
{
	public class LineFilterDirector
	{
		private readonly LineFilterBuilder lineFilterBuilder;
		public LineFilterDirector(LineFilterBuilder lineFilterBuilder) 
		{
			this.lineFilterBuilder = lineFilterBuilder;
		}

		public LineFilter Direct(FilterOptions filterOptions)
		{
			foreach (var strToFilter in filterOptions.FilterStrings)
				lineFilterBuilder.SetContains(filterOptions.FilterContains, strToFilter);

			if (filterOptions.FilterMaxLineNumber > 0)
				lineFilterBuilder.SetNumberLineToFilter(filterOptions.FilterMaxLineNumber);

			return lineFilterBuilder.Build();
		}
	}
}
