using LineSource;

namespace LineFilter
{
	public class ContainsStrLineFilterDecorator : LineFilterDecorator
	{
		private readonly string strToFilter;
		public ContainsStrLineFilterDecorator(LineFilter lineFilter, string strToFilter) : base(lineFilter) 
		{
			this.strToFilter = strToFilter;	
		}

		public override Line[] Filter(Line[] lines)
		{
			var filteredLines = lineFilter.Filter(lines);
			return filteredLines.Where(x => x.Text.Contains(strToFilter)).ToArray();
		}
	}
}
