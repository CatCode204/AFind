using LineSource;

namespace LineFilter
{
	public class NoLineFilter : LineFilter
	{
		public override Line[] Filter(Line[] lines)
		{
			return lines;
		}
	}
}
