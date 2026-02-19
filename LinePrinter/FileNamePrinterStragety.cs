using LineSource;

namespace LinePrinter
{
	public class FileNamePrinterStragety : LinePrinterDecorator
	{
		private readonly string filename;
		public FileNamePrinterStragety(Line[] lines, LinePrinterStragety linePrinterStragety, string filename) : base(lines,linePrinterStragety) 
		{
			this.filename = filename;
		}

		public override void PrintOneLine(Line line)
		{
			Console.Write($"[{filename}]::");
			linePrinterStragety.PrintOneLine(line);
		}

		public override void Print()
		{
			Console.WriteLine($"==============================={filename}==============================");
			base.Print();
		}
	}
}
