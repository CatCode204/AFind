using LineSource;

namespace LineFilter
{
	public class ContainsCaseInsensitiveLineFilterDecorator : LineFilterDecorator
	{
		private readonly string strToFilter;

		public ContainsCaseInsensitiveLineFilterDecorator(LineFilter lineFilter, string strToFilter) : base(lineFilter)
		{
			this.strToFilter = strToFilter.ToUpper();
		}

		public override Line[] Filter(Line[] lines)
		{
			var linesFiltered = lineFilter.Filter(lines);
			return linesFiltered.Where(x => x.Text.ToUpper().Contains(strToFilter)).ToArray();
		}
	}
}
