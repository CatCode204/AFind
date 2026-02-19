using LineSource;

namespace LinePrinter
{
	public class LineNumberPrinterDecorator : LinePrinterDecorator
	{
		public LineNumberPrinterDecorator(Line[] lines, LinePrinterStragety linePrinterStragety) : base(lines,linePrinterStragety) { }

		public override void PrintOneLine(Line line)
		{
			Console.Write($"[{line.LineNumber}]: ");
			linePrinterStragety.PrintOneLine(line);
		}
	}
}
