using LineSource;

namespace LinePrinter
{
	public class CountLinePrinterStragety : PrinterStragety
	{
		public CountLinePrinterStragety(Line[] linesToPrint) : base(linesToPrint) { }

		public override void Print()
		{
			Console.WriteLine($"Total number lines match: {linesToPrint.Length}");
		}
	}
}
