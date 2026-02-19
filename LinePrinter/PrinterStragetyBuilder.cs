using LineSource;

namespace LinePrinter
{
	public class PrinterStragetyBuilder
	{
		public PrintOptions PrintOptions { get; set; } = new();
		public PrinterStragety? Build(Line[] lines)
		{
			switch (PrintOptions.PrintMode)
			{
				case PrintMode.LINE_MODE:
					LinePrinterStragety contentPrinter = new LineContentPrinter(lines);
					if (PrintOptions.PrintLineNumber)
						contentPrinter = new LineNumberPrinterDecorator(lines, contentPrinter);
					if (!String.IsNullOrEmpty(PrintOptions.FileName))
						contentPrinter = new FileNamePrinterStragety(lines, contentPrinter,PrintOptions.FileName);
					return contentPrinter;

				case PrintMode.TOTAL_LINE_NUMBER:
					var countLinePrinter = new CountLinePrinterStragety(lines);
					return countLinePrinter;
			}

			throw new Exception();
		}
	}
}
