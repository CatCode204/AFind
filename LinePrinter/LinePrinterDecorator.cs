using LineSource;

namespace LinePrinter
{
	public abstract class LinePrinterDecorator : LinePrinterStragety
	{
		protected readonly LinePrinterStragety linePrinterStragety;

		public LinePrinterDecorator(Line[] lines,LinePrinterStragety linePrinterStragety) : base(lines)
		{
			this.linePrinterStragety = linePrinterStragety;
		}
	}
}
