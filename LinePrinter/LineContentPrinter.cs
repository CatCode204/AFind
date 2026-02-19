using LineSource;

namespace LinePrinter
{
	public class LineContentPrinter : LinePrinterStragety
	{
		public LineContentPrinter(Line[] linesToPrint) : base(linesToPrint) { }

		public override void PrintOneLine(Line line)
		{
			Console.WriteLine(line.Text);
		}
	}
}
