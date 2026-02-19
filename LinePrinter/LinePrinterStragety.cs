using LineSource;

namespace LinePrinter
{
	public abstract class LinePrinterStragety : PrinterStragety
	{
		public LinePrinterStragety(Line[] linesToPrint) : base(linesToPrint) {}

		public abstract void PrintOneLine(Line line);

		public override void Print()
		{
			foreach (Line line in linesToPrint)
				PrintOneLine(line);
		}
	}
}
