using LineSource;

namespace LineFilter
{
	public class LineNumberFilterDecorator : LineFilterDecorator
	{
		private readonly int lineNumberFilterer;

		public LineNumberFilterDecorator(LineFilter lineFilter,int lineNumberFilterer) : base(lineFilter)
		{
			this.lineNumberFilterer = lineNumberFilterer;
		}

		public override Line[] Filter(Line[] lines)
		{
			var filteredLines = lineFilter.Filter(lines);
			return filteredLines.Where(x => x.LineNumber <= lineNumberFilterer).ToArray();
		}
	}
}