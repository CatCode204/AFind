namespace LineFilter
{
	public abstract class LineFilterDecorator : LineFilter
	{
		protected LineFilter lineFilter;

		public LineFilterDecorator(LineFilter lineFilter)
		{
			this.lineFilter = lineFilter;
		}
	}
}
