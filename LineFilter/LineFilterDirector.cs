using System.Security.Cryptography.X509Certificates;

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
				if (filterOptions.IsCaseSensitive)
					lineFilterBuilder.SetContains(filterOptions.FilterContains, strToFilter);
				else
					lineFilterBuilder.SetCaseInSensitiveContains(filterOptions.FilterContains, strToFilter);

			if (filterOptions.FilterMaxLineNumber > 0)
				lineFilterBuilder.SetNumberLineToFilter(filterOptions.FilterMaxLineNumber);

			return lineFilterBuilder.Build();
		}
	}
}
