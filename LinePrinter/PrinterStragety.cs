using LineSource;

namespace LinePrinter
{
	public abstract class PrinterStragety
	{
		protected readonly Line[] linesToPrint;

		public PrinterStragety(Line[] linesToPrint)
		{
			this.linesToPrint = linesToPrint;
		}

		public abstract void Print();
	}
}
