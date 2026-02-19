using LineSource;

namespace LineFilter
{
	public abstract class LineFilter
	{
		public abstract Line[] Filter(Line[] lines);
	}
}