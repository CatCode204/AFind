namespace LinePrinter
{
	public class PrinterContext
	{
		public PrinterStragety? Stragety { get; set; } = null;

		public void Excute()
		{
			Stragety?.Print();
		}
	}
}
