using LineSource;

namespace LineFilter
{
	public class NoContainsStrLineFilterDecorator : LineFilterDecorator
	{
		private readonly string strToFilter;
		public NoContainsStrLineFilterDecorator(LineFilter lineFilter, string strToFilter) : base(lineFilter)
		{
			this.strToFilter = strToFilter;
		}

		public override Line[] Filter(Line[] lines)
		{
			var filteredLines = lineFilter.Filter(lines);
			return filteredLines.Where(x => !x.Text.Contains(strToFilter)).ToArray();
		}
	}
}
